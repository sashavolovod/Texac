using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Texac;
using Texac.Common;
using Microsoft.Reporting.WinForms;

namespace Texac.Ekon.Inventory
{
    public partial class InventoryControl : UserControl
    {
        private InventoryEntity inventory;
        public InventoryControl()
        {
            InitializeComponent();
        }

        private async void tsbImportFromInventory_Click(object sender, EventArgs e)
        {
            tsbReport.Enabled = false;

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
                                tsbReport.Enabled = true;
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

        private void dgvInventory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvInventory.Rows[e.RowIndex];
            var item = row.DataBoundItem as InventoryEntry;
            if (item == null) return;

            if (item.remainingQty == 0 &&
                (
                    item.factReadyDate!=null 
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

        private void tsbReport_Click(object sender, EventArgs e)
        {
            bsInventory.EndEdit();

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("parPeriod", inventory.period);

            ReportDataSource rds = new ReportDataSource("DataSet1", inventory.entries);

            ReportForm reportForm = new ReportForm("Texac.Ekon.Inventory.InventoryReport.rdlc", "Материальный отчет ИнЦ", parameters, rds);


            reportForm.Show();

        }

    }
}
