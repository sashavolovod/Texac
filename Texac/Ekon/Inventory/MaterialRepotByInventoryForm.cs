using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Texac.Common;
using System.Threading.Tasks;
using System.ComponentModel;
using Texac.Net;
using Texac.Services;
using System.IO;
using ExcelDataReader;
using System.Data;
using System.Linq;

namespace Texac.Ekon.Inventory
{
    public partial class MaterialReportByInventoryForm : Texac.Win.TexacForm
    {
        private readonly TexacApiClient _api;

        private InventoryEntity inventory;
        private bool isChanged = false;

        private readonly InventoryService _service = new InventoryService();

        public MaterialReportByInventoryForm(long inventoryId)
        {
            _api = TexacApi.Client;

            InitializeComponent();
            if (inventoryId > 0)
                LoadInventory(inventoryId);
            else
                ParseExcelFile();

            dgvInventory.RowPrePaint += DgvInventory_RowPrePaint;
            tsbReport.Click += TsbReport_Click;

            dgvInventory.CellValueChanged += (s, e) => isChanged = true;

            this.FormClosing += InventoryForm_FormClosing;
        }

        private async void ParseExcelFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Настройка диалогового окна
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                openFileDialog.Title = "Выберите файл Excel";
                openFileDialog.Multiselect = false;

                // Показать диалог и проверить, выбран ли файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Чтение Excel-файла
                        string filePath = openFileDialog.FileName;
                        string fileContent = GetFileContentFromExcel(filePath);

                        if (!string.IsNullOrEmpty(fileContent))
                        {
                            // Парсинг содержимого файла
                            Cursor = Cursors.WaitCursor;
                            try
                            {
                                await LoadInventoryAsync(fileContent);
                            }
                            finally
                            {
                                Cursor = Cursors.Default;
                                isChanged = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не удалось прочитать содержимое файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async Task LoadInventoryAsync(string fileContent)
        {
            inventory = await Task.Run(() =>
                InventoryParser.ParseInventoryData(fileContent)
            );

            bsInventory.DataSource =
                new BindingList<InventoryEntry>(inventory.entries);
        }

        private string ConvertDataTableToText(DataTable table)
        {
            var sb = new System.Text.StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                var fields = row.ItemArray.Select(field => field?.ToString() ?? "");
                sb.AppendLine(string.Join("\t", fields));
            }
            return sb.ToString();
        }

        public string GetFileContentFromExcel(string filePath)
        {
            try
            {
                // Регистрируем кодировку для корректной обработки русских символов
                //System.Text.Encoding. RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = false // Заголовки обрабатываем вручную
                            }
                        });

                        // Предполагаем, что данные на первом листе
                        DataTable table = result.Tables[0];
                        string fileContent = ConvertDataTableToText(table);
                        return fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении Excel-файла: {ex.Message}");
                return string.Empty;
            }
        }

        private void DgvInventory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvInventory.Rows[e.RowIndex];
            var item = row.DataBoundItem as InventoryEntry;
            if (item == null) return;

            if (item.remainingQty == 0 &&
                (
                    item.factReadyDate != null
                    &&
                    !(item.factReadyDate >= inventory.startDate && item.factReadyDate <= inventory.endDate))
                )
            {
                row.DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void TsbReport_Click(object sender, EventArgs e)
        {
            bsInventory.EndEdit();

            if (inventory == null)
                return;

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("parPeriod", inventory.period);
            ReportDataSource rds = new ReportDataSource("DataSet1", inventory.entries);
            ReportForm reportForm = new ReportForm("Texac.Ekon.Inventory.InventoryReport.rdlc", "Материальный отчет ИнЦ", parameters, rds);
            reportForm.Show();
        }


        private async Task LoadInventory(long id)
        {
            inventory = await UiApi.SafeCall(() => _service.GetByIdAsync(id), "Ошибка загрузки");
            if (inventory == null)
                return;

            bsInventory.DataSource = new BindingList<InventoryEntry>(inventory.entries);
            isChanged = false;
        }

        public async Task<InventoryEntity> SaveInventoryReport()
        {
            var saved = await _service.SaveAsync(inventory);

            // обновим id на случай POST
            inventory.inventoryEntityId = saved.inventoryEntityId;
            isChanged = false;

            return saved;
        }

        private async void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvInventory.EndEdit();
            bsInventory.EndEdit();

            if (!isChanged) return;

            var r = MessageBox.Show("Сохранить изменения отчёта?", "Texac",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (r == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            if (r == DialogResult.Yes)
            {
                e.Cancel = true;
                Cursor.Current = Cursors.WaitCursor;

                await UiApi.SafeCall(async () => { await SaveInventoryReport(); }, "Ошибка сохранения");
                Cursor.Current = Cursors.Default;
                isChanged = false;
                this.Close();
            }
        }

    }
}
