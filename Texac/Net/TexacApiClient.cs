using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Texac.Net
{
    public sealed class TexacApiClient
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerSettings _jsonSettings;

        public TexacApiClient(string baseUrl)
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri(baseUrl);
            _http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TexacHttpClient", "1.0"));
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            _jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "yyyy-MM-ddTHH:mm:ss" // без timezone -> LocalDateTime на бэкенде
            };
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var resp = await _http.GetAsync(url);
            var body = await resp.Content.ReadAsStringAsync();
            EnsureSuccess(resp, body);
            return JsonConvert.DeserializeObject<T>(body, _jsonSettings);
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest data)
        {
            var resp = await _http.PostAsync(url, MakeJsonContent(data));
            var body = await resp.Content.ReadAsStringAsync();
            EnsureSuccess(resp, body);
            return JsonConvert.DeserializeObject<TResponse>(body, _jsonSettings);
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest data)
        {
            var resp = await _http.PutAsync(url, MakeJsonContent(data));
            var body = await resp.Content.ReadAsStringAsync();
            EnsureSuccess(resp, body);
            return JsonConvert.DeserializeObject<TResponse>(body, _jsonSettings);
        }

        public async Task DeleteAsync(string url)
        {
            var resp = await _http.DeleteAsync(url);
            var body = await resp.Content.ReadAsStringAsync();
            EnsureSuccess(resp, body);
        }

        private StringContent MakeJsonContent(object data)
        {
            string json = JsonConvert.SerializeObject(data, _jsonSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static void EnsureSuccess(HttpResponseMessage resp, string body)
        {
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException(
                    $"HTTP {(int)resp.StatusCode} ({resp.ReasonPhrase})\n{body}");
        }
    }
}