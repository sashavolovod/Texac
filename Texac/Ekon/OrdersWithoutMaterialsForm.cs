using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.Ekon
{
    public partial class OrdersWithoutMaterialsForm : Form
    {
        public OrdersWithoutMaterialsForm()
        {
            InitializeComponent();
            

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadOrders();
        }

        private async void LoadOrders()
        {
            Cursor = Cursors.WaitCursor;
            await LoadOrdersAsync();
            Cursor = Cursors.Default;
        }

        private async Task LoadOrdersAsync()
        {
            string sql = @"
SELECT 
    o.NППЗаказа,
    o.NЗаказа,
    zc.МО
FROM 
    Заказы AS o
    INNER JOIN ЗаказыВЦеху AS zc 
        ON o.NППЗаказа = zc.NППЗаказа
WHERE
    (o.NЗаказа LIKE '23%' OR o.NЗаказа LIKE '208%')
    AND (o.Кол_во - IIf(IsNull(o.ФКол_во), 0, o.ФКол_во) > 0)
    AND zc.МО IS NOT NULL
    AND o.pause = false
    AND NOT EXISTS (
        SELECT 1
        FROM tblTrebovanieDetails t
        WHERE t.OrderId = o.NППЗаказа
    )
    AND EXISTS (
        SELECT 1
        FROM МатериальнаяКарта mk
        WHERE mk.NППЗаказа = o.NППЗаказа
          AND mk.Склад NOT IN (71, 750)
    );";

            DataTable table = await Task.Run(() =>
            {
                var dt = new DataTable();

                using (var conn = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
                using (var cmd = new OleDbCommand(sql, conn))
                using (var da = new OleDbDataAdapter(cmd))
                {
                    conn.Open();
                    da.Fill(dt);
                }

                return dt;
            });

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}

