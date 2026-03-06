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
using System.Net.Http;
using Newtonsoft.Json;
using Texac.Services;
using Texac.Net;

namespace Texac.Ekon.Inventory
{
    public partial class InventoryControl : UserControl
    {

        private readonly InventoryService _inventoryService = new InventoryService();

        public InventoryControl()
        {
            InitializeComponent();
        }


        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            await LoadInventoryListAsync();
        }

        private async Task LoadInventoryListAsync()
        {
            var list = await UiApi.SafeCall(() => _inventoryService.GetListAsync(), "Ошибка загрузки списка документов");
            if (list == null)
                return;

            bsInventory.DataSource = new SortableBindingList<InventoryEntity>(list);
        }

        private void tsbImportFromInventory_Click(object sender, EventArgs e)
        {
            actAddInventory();
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actOpenInventory();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            actDeleteInventory();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            actOpenInventory();
        }

        private async void actAddInventory()
        {
            new MaterialReportByInventoryForm(-1).ShowDialog();
            await LoadInventoryListAsync();
        }

        private void actOpenInventory()
        {
            if (bsInventory.Position < 0)
                return;

            var item = bsInventory.Current as InventoryEntity;
            if (item == null)
                return;
            new MaterialReportByInventoryForm(item.inventoryEntityId).ShowDialog();

        }

        private async void actDeleteInventory()
        {
            var item = bsInventory.Current as InventoryEntity;
            if (item == null)
                return;

            var result = MessageBox.Show( $"Удалить документ \"{item.period}\"?", "Texac", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            bool ok = false;

            await UiApi.SafeCall(async () =>  
            { await _inventoryService.DeleteAsync(item.inventoryEntityId);
                ok = true;
            }, "Ошибка удаления документа");

            if (ok)
                await LoadInventoryListAsync();
        }

        private void dgvInventory_MouseDown(object sender, MouseEventArgs e)
        {
            var dgv = sender as DataGridView;
            var hti = dgv.HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                if (dgv.SelectedRows.Count == 1)
                    dgv.CurrentCell = dgv[hti.ColumnIndex, hti.RowIndex];
            }
        }
    }
}
