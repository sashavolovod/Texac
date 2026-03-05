using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Texac.Common;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Text;
using Texac.Net;
using Texac.Services;

namespace Texac.Ekon.Inventory
{
    public partial class MaterialRepotByInventoryForm : Texac.Win.TexacForm
    {
        private readonly TexacApiClient _api;

        private InventoryEntity inventory;
        private bool isChanged = false;

        private readonly InventoryService _service = new InventoryService();

        public MaterialRepotByInventoryForm(int inventoryId)
        {
            _api = TexacApi.Client;

            InitializeComponent();

            LoadInventory(inventoryId);

            dgvInventory.RowPrePaint += DgvInventory_RowPrePaint;
            tsbReport.Click += TsbReport_Click;

            dgvInventory.CellValueChanged += (s, e) => isChanged = true;

            this.FormClosing += InventoryForm_FormClosing;


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
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("parPeriod", inventory.period);
            ReportDataSource rds = new ReportDataSource("DataSet1", inventory.entries);
            ReportForm reportForm = new ReportForm("Texac.Ekon.Inventory.InventoryReport.rdlc", "Материальный отчет ИнЦ", parameters, rds);
            reportForm.Show();
        }


        private async Task LoadInventory(int id)
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
