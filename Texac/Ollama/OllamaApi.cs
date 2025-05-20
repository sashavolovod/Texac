using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Ollama
{
    public class OllamaApi
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;
        private List<ChatMessage> _chatHistory;

        public OllamaApi(string baseUrl = "http://172.16.11.173:11434")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _chatHistory = new List<ChatMessage>();
        }

        public class ChatMessage
        {
            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("content")]
            public string Content { get; set; }

            [JsonIgnore]
            public DateTime Timestamp { get; set; }
        }

        public class ChatRequest
        {
            [JsonProperty("model")]
            public string Model { get; set; }

            [JsonProperty("messages")]
            public List<ChatMessage> Messages { get; set; }

            [JsonProperty("stream")]
            public bool Stream { get; set; }
        }

        public class ChatResponse
        {
            [JsonProperty("model")]
            public string Model { get; set; }

            [JsonProperty("message")]
            public ChatMessage Message { get; set; }

            [JsonProperty("done")]
            public bool Done { get; set; }
        }

        public List<ChatMessage> GetChatHistory()
        {
            return _chatHistory;
        }

        public void ClearContext()
        {
            _chatHistory.Clear();
        }

        public async Task<string> SendMessageAsync(string message, string modelName)
        {
            try
            {
                var request = new ChatRequest
                {
                    Model = modelName,
                    Messages = _chatHistory,
                    Stream = false
                };

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                string requestUri = $"{_baseUrl}/api/chat";

                using (var response = await _client.PostAsync(requestUri, content))
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ChatResponse>(jsonResponse);

                    if (result?.Message != null)
                    {
                        result.Message.Timestamp = DateTime.Now;
                        _chatHistory.Add(result.Message);
                        return result.Message.Content;
                    }
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public async Task StreamMessageAsync(string message, String modelName, Action<string> onChunk)
        {
            try
            {

                var request = new ChatRequest
                {
                    Model = modelName,
                    Messages = _chatHistory,
                    Stream = true
                };

                string json = JsonConvert.SerializeObject(request);
                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                StringBuilder fullResponse = new StringBuilder();
                ChatMessage assistantMessage = new ChatMessage
                {
                    Role = "assistant",
                    Content = "",
                    Timestamp = DateTime.Now
                };

                using (var response = await _client.PostAsync($"{_baseUrl}/api/chat", content))
                using (var reader = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = await reader.ReadLineAsync();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        var chunk = JsonConvert.DeserializeObject<ChatResponse>(line);
                        if (chunk?.Message?.Content != null)
                        {
                            fullResponse.Append(chunk.Message.Content);
                            onChunk(chunk.Message.Content);
                        }
                    }
                }

                assistantMessage.Content = fullResponse.ToString();
                _chatHistory.Add(assistantMessage);
            }
            catch (Exception ex)
            {
                onChunk($"Error: {ex.Message}");
            }
        }
    }
}
