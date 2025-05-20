using System;
using System.Drawing;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;
using TheArtOfDev.HtmlRenderer.Core.Entities;
using System.Linq;

namespace Texac.Ollama
{
    public class MarkdownViewer : Panel
    {
        private readonly HtmlPanel _htmlPanel;
        private string _markdown = string.Empty;

        public string Markdown
        {
            get { return _markdown; }
            set
            {
                _markdown = value;
                UpdateContent();
            }
        }

        public MarkdownViewer()
        {
            // Настройка HTML панели
            _htmlPanel = new HtmlPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(0, 255, 255, 255),
                AutoScroll = false,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10, 10, 10, 10)
            };

            // Добавление обработчика для ссылок
            _htmlPanel.LinkClicked += HtmlPanel_LinkClicked;

            // Базовые стили для Markdown
            _htmlPanel.BaseStylesheet = @"
            body { font-family: 'Segoe UI', Arial, sans-serif; line-height: 1.3; padding: 10px; }
            .question {
                background-color: #f8f9fa;
                border-left: 4px solid #5a9bd5;
                padding: 10px 15px;
                margin-bottom: 10px;
            }
            .answer {
                border-left: 4px solid #70ad47;
                padding-left: 15px;
                margin-bottom: 10px;
            }
            code { font-family: Consolas, monospace; background-color: #f5f5f5; padding: 2px 4px; border-radius: 3px; }
            pre { background-color: #f5f5f5; padding: 16px; border-radius: 6px; overflow-x: auto; }
            pre code { background-color: transparent; padding: 0; }
            blockquote { border-left: 4px solid #ddd; margin: 0; padding-left: 16px; color: #666; }
            table { border-collapse: collapse; width: 100%; }
            th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }
            th { background-color: #f5f5f5; }
            img { max-width: 100%; height: auto; }
            hr { border: 0; border-top: 1px solid #ddd; }
            h1, h2, h3, h4, h5, h6 { color: #333; }
            a { color: #0366d6; }
            ul, ol { padding-left: 20px; }
        ";
            Controls.Add(_htmlPanel);
        }

        private void UpdateContent()
        {
            if (string.IsNullOrEmpty(_markdown))
            {
                _htmlPanel.Text = string.Empty;
                return;
            }
            _htmlPanel.Text = _markdown;
        }

        private void HtmlPanel_LinkClicked(object sender, HtmlLinkClickedEventArgs e)
        {
            try
            {
                Uri uri;
                if (Uri.TryCreate(e.Link, UriKind.Absolute, out uri))
                {
                    System.Diagnostics.Process.Start(uri.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии ссылки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ScrollToEnd()
        {
            _htmlPanel.AutoScrollPosition = new Point(0, _htmlPanel.DisplayRectangle.Height);

        }

    }
}
