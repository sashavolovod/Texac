using System;
using Markdig;
using System.Web;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Texac.Ollama.OllamaApi;

namespace Texac.Ollama
{
    public partial class OllamaControl : UserControl
    {
        private readonly OllamaApi _ollamaApi;
        private StringBuilder currentResponse;
        private MarkdownViewer chatViewer;
        private readonly MarkdownPipeline _pipeline;

        public class ModelAIEntity
        {
            public string modelName { get; set; }
            public string modelTitle { get; set; }
        }

        List<ModelAIEntity> models = new List<ModelAIEntity>();

        public OllamaControl()
        {
            models.Add(new ModelAIEntity { modelName = "llama3.2", modelTitle = "llama3.2 3b" });
            models.Add(new ModelAIEntity { modelName = "llama3.1", modelTitle = "llama3.1 8b" });
            models.Add(new ModelAIEntity { modelName = "deepseek-r1:8b", modelTitle = "deepseek-r1  8b" });
            models.Add(new ModelAIEntity { modelName = "deepseek-r1:14b", modelTitle = "deepseek-r1  14b" });
            models.Add(new ModelAIEntity { modelName = "llama3.3", modelTitle = "llama3.3 70b" });

            InitializeComponent();
            currentResponse = new StringBuilder();

            chatViewer = new MarkdownViewer
            {
                Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right,
                Location = new Point(43, 25),
                Size = new Size(913, 222),
                TabIndex = 2
            };

            Controls.Add(chatViewer);

            cbModelAI.DataSource = models;
            cbModelAI.ValueMember = "modelName";
            cbModelAI.DisplayMember = "modelTitle";
            cbModelAI.SelectedIndex = 1;

            // Настройка Markdig для поддержки расширенных возможностей
            _pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSoftlineBreakAsHardlineBreak()
                .Build();

            _ollamaApi = new OllamaApi("http://172.16.11.173:11434");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _ollamaApi.ClearContext();
            chatViewer.Markdown = "История диалога очищена";
        }

        private void UpdateChatDisplay(bool isStreaming = false)
        {
            var history = _ollamaApi.GetChatHistory();
            var markdownBuilder = new StringBuilder();

            foreach (var message in history)
            {
                if(message.Role == "user")
                {
                    markdownBuilder.AppendLine("<div class='question'>");
                    markdownBuilder.AppendLine($"<strong>Вопрос  ({message.Timestamp:HH:mm:ss}):</strong>");
                    markdownBuilder.AppendLine(Markdown.ToHtml(HttpUtility.HtmlEncode(message.Content), _pipeline));
                    markdownBuilder.AppendLine("</div>");
                }
                else
                {
                    markdownBuilder.AppendLine("<div class='answer'>");
                    markdownBuilder.AppendLine($"<strong>Ответ:  ({message.Timestamp:HH:mm:ss}):</strong>");
                    markdownBuilder.AppendLine(Markdown.ToHtml(HttpUtility.HtmlEncode(message.Content), _pipeline));
                    markdownBuilder.AppendLine("</div>");
                }
            }

            // Если идет стриминг, добавляем текущий ответ
            if (isStreaming && currentResponse.Length > 0)
            {
                markdownBuilder.AppendLine("<div class='answer'>");
                markdownBuilder.AppendLine($"<strong>Ответ:  ({DateTime.Now:HH:mm:ss}):</strong><br/>");
                // markdownBuilder.AppendLine(Markdown.ToHtml(HttpUtility.HtmlEncode(currentResponse.ToString()), _pipeline));
                markdownBuilder.AppendLine(Markdown.ToHtml(currentResponse.ToString(), _pipeline));
                markdownBuilder.AppendLine("</div>");
            }

            chatViewer.Markdown = markdownBuilder.ToString();

            chatViewer.ScrollToEnd();
        }


        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
                return;

            sendButton.Enabled = false;
            string userMessage = inputTextBox.Text;
            inputTextBox.Text = string.Empty;

            var history = _ollamaApi.GetChatHistory();

            var userChatMessage = new ChatMessage
            {
                Role = "user",
                Content = userMessage,
                Timestamp = DateTime.Now
            };
            history.Add(userChatMessage);

            // Обновляем дисплей с сообщением пользователя
            UpdateChatDisplay();

            try
            {
                var response = await _ollamaApi.SendMessageAsync(userMessage, cbModelAI.SelectedValue.ToString());

                UpdateChatDisplay();
            }
            catch (Exception ex)
            {
                chatViewer.Markdown = Markdown.ToHtml($"### Ошибка\n\n```\n{ex.Message}\n```", _pipeline);
            }
            finally
            {
                sendButton.Enabled = true;
            }
        }


        private async void SendButtonOld_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
                return;

            sendButton.Enabled = false;
            clearButton.Enabled = false;
            string userMessage = inputTextBox.Text;
            inputTextBox.Text = string.Empty;
            currentResponse.Clear();

            var history = _ollamaApi.GetChatHistory();

            var userChatMessage = new ChatMessage
            {
                Role = "user",
                Content = userMessage,
                Timestamp = DateTime.Now
            };
            history.Add(userChatMessage);

            // Обновляем дисплей с сообщением пользователя
            UpdateChatDisplay();
            string modelName = cbModelAI.SelectedValue.ToString();
            try
            {
                await _ollamaApi.StreamMessageAsync(userMessage, modelName, chunk =>
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => HandleStreamChunk(chunk)));
                    }
                    else
                    {
                        HandleStreamChunk(chunk);
                    }
                });
                UpdateChatDisplay();
            }
            catch (Exception ex)
            {
                chatViewer.Markdown = Markdown.ToHtml($"### Ошибка\n\n```\n{ex.Message}\n```",_pipeline);
            }
            finally
            {
                sendButton.Enabled = true;
                clearButton.Enabled = true;
            }
        }

        private void HandleStreamChunk(string chunk)
        {
            currentResponse.Append(chunk);
            UpdateChatDisplay(true); // Передаем true для обозначения режима стриминга
        }

    }
}
