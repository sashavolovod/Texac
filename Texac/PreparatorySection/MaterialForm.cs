using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.PreparatorySection
{
    public partial class MaterialForm : Form
    {
        Color evenColor = SystemColors.ButtonFace;
        Color oddColor = Color.White;

        private List<MaterialOrderGridRow> _allMaterials;


        public MaterialForm()
        {
            InitializeComponent();

            var requirementIds = new List<int> { 13801, 13804, 13805, 13808, 13809, 13810, 18084, 18228, 18595, 22498, 22499, 22500, 22501, 22502, 22503, 22504, 22505, 22506, 22507, 22508, 22509, 22510, 22511, 22512, 22513, 22514, 22515, 22516, 22517, 22518, 22519, 22520, 22521, 22522, 22523, 22524, 22525, 22526, 22527, 22528, 22529, 22530, 22531, 22532, 22533, 22534, 22535, 22536, 22537, 22538, 22539, 22540, 22541, 22542, 22543, 22544, 22545, 22546, 22547, 22548, 22549, 22551, 22552, 22553, 22554, 22555, 22570, 22556, 22557, 22558, 22559, 22560, 22561, 22562, 22563, 22565, 22566, 22567, 22568, 22569, 22571, 22573, 22574, 22576, 22577, 22578, 22579, 22580, 22581 };

            _allMaterials = DbHelper.GetMaterialData(requirementIds);
            // var data = CreateTestData();
            InitGrid(_allMaterials);
            InitWarehouseFilter(_allMaterials);
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            IEnumerable<MaterialOrderGridRow> query = _allMaterials;

            // --- фильтр по складу ---
            if (listBoxWarehouse.SelectedItem != null &&
                listBoxWarehouse.SelectedItem.ToString() != "Все")
            {
                int warehouseId;
                if (int.TryParse(listBoxWarehouse.SelectedItem.ToString(), out warehouseId))
                {
                    query = query.Where(x => x.WarehouseId == warehouseId);
                }
            }

            // --- фильтр по MaterialId ---
            if (!string.IsNullOrWhiteSpace(txtMaterialId.Text))
            {
                int materialId;
                if (int.TryParse(txtMaterialId.Text, out materialId))
                {
                    query = query.Where(x => x.MaterialId == materialId);
                }
            }

            // --- фильтр по MaterialName ---
            if (!string.IsNullOrWhiteSpace(txtMaterialName.Text))
            {
                string text = txtMaterialName.Text.ToLower();
                query = query.Where(x =>
                    x.MaterialName != null &&
                    x.MaterialName.ToLower().Contains(text));
            }

            dataGridView.DataSource = query.ToList();
        }


        private void InitWarehouseFilter(List<MaterialOrderGridRow> data)
        {
            var warehouses = data
                .Select(x => x.WarehouseId)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            listBoxWarehouse.Items.Clear();
            listBoxWarehouse.Items.Add("Все");
            foreach (var w in warehouses)
                listBoxWarehouse.Items.Add(w);

            listBoxWarehouse.SelectedIndex = 0;
        }

        private void listBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtMaterialId_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtMaterialName_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void InitGrid(List<MaterialOrderGridRow> data)
        {
            string qtyFormat = "#,0.###;-#,0.###;''";

            dataGridView.ShowCellToolTips = true;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView.Columns.Clear();

            // --- Фиксированные колонки ---
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaterialId",
                HeaderText = "Код материала",
                Name = "MaterialId",
                Width = 60,
                ReadOnly = true
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaterialName",
                HeaderText = "Материал",
                Name = "MaterialName",
                Width = 300,
                ReadOnly = true
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitName",
                HeaderText = "Ед.изм.",
                Name = "UnitName",
                Width = 60,
                ReadOnly = true
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalRequested",
                HeaderText = "Затребовано всего",
                Name = "TotalRequested",
                ReadOnly = true
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalReceived",
                HeaderText = "Получено всего",
                Name = "TotalReceived",
                DividerWidth = 2
            });

            // --- Динамические колонки по максимальному числу заказов ---
            int maxOrders = data.Max(m => m.Orders.Count);

            for (int i = 0; i < maxOrders; i++)
            {
                Color backColor = (i % 2 == 0) ? SystemColors.ButtonFace : Color.White;

                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = $"Order{i}_Requested",
                    HeaderText = "Затр.",
                    Tag = i,
                    Width = 60,
                    ReadOnly = true
                });

                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = $"Order{i}_Received",
                    HeaderText = "Получ.",
                    Tag = i,
                    Width = 60,
                    DividerWidth = 2,
                    ReadOnly = false
                });
            }

            // Выравнивание фиксированных столбцов
            dataGridView.Columns["UnitName"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["TotalRequested"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["TotalRequested"].DefaultCellStyle.Format = qtyFormat;

            dataGridView.Columns["TotalReceived"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["TotalReceived"].DefaultCellStyle.Format = qtyFormat;

            // Выравнивание динамических колонок заказов
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (col.Name.EndsWith("_Requested") || col.Name.EndsWith("_Received"))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Format = qtyFormat;
                }
            }
        }


        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return; 

            var row = dataGridView.Rows[e.RowIndex].DataBoundItem as MaterialOrderGridRow;
            if (row == null) return;

            var column = dataGridView.Columns[e.ColumnIndex];


            var indexObj = column.Tag as int?;
            if (!indexObj.HasValue)
                return;

            int index = indexObj.Value;

            var orders = row.Orders.Values
                .OrderBy(o => o.OrderNumber)
                .ToList();

            if (index >= orders.Count)
            {
                e.Value = null;
                return;
            }

            var info = orders[index];

            if (column.Name.EndsWith("_Requested"))
                e.Value = info.RequestedQuantity;

            if (column.Name.EndsWith("_Received"))
                e.Value = info.ReceivedQuantity;
        }


        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var row = dataGridView.Rows[e.RowIndex].DataBoundItem as MaterialOrderGridRow;
            if (row == null) return;

            var column = dataGridView.Columns[e.ColumnIndex];

            var indexObj = column.Tag as int?;
            if (!indexObj.HasValue)
                return;

            int index = indexObj.Value;

            var orders = row.Orders.Values
                .OrderBy(o => o.OrderNumber)
                .ToList();

            if (index >= orders.Count)
                return;

            var info = orders[index];

        }

        private void dataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var row = dataGridView.Rows[e.RowIndex].DataBoundItem as MaterialOrderGridRow;
            if (row == null) return;

            var column = dataGridView.Columns[e.ColumnIndex];
            var indexObj = column.Tag as int?;
            if (!indexObj.HasValue) return;

            int index = indexObj.Value;

            var orders = row.Orders.Values
                .OrderBy(o => o.OrderNumber)
                .ToList();

            if (index >= orders.Count) return;

            var info = orders[index];

            e.ToolTipText =
                $"Заказ №{info.OrderNumber}\n" +
                $"Требование №{info.RequirementNumber}\n" +
                $"Дата: {info.RequirementDate:d}";
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var row = dataGridView.Rows[e.RowIndex].DataBoundItem as MaterialOrderGridRow;
            if (row == null) return;

            var column = dataGridView.Columns[e.ColumnIndex];

            // только столбцы "Получено"
            if (!column.Name.EndsWith("_Received"))
                return;

            var indexObj = column.Tag as int?;
            if (!indexObj.HasValue)
                return;

            int index = indexObj.Value;

            var orders = row.Orders.Values
                .OrderBy(o => o.OrderNumber)
                .ToList();

            if (index >= orders.Count)
                return;

            var info = orders[index];

            // --- проверка, изменилось ли значение ---
            var cellValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (cellValue == null || cellValue.ToString() == info.ReceivedQuantity.ToString())
            {
                // значение не менялось — ничего не делаем
                return;
            }

            // пытаемся распарсить
            double newValue;
            if (!double.TryParse(cellValue.ToString(), out newValue))
            {
                MessageBox.Show("Введите числовое значение");
                dataGridView.CancelEdit();
                return;
            }

            // бизнес-ограничение
            if (newValue < 0 || newValue > info.RequestedQuantity)
            {
                MessageBox.Show("Получено не может превышать затребованное");
                dataGridView.CancelEdit();
                return;
            }

            // обновляем модель
            info.ReceivedQuantity = newValue;

            // пересчитываем итоги по материалу
            row.TotalReceived = row.Orders.Values.Sum(o => o.ReceivedQuantity);

            dataGridView.Refresh();
        }


        public List<MaterialOrderGridRow> CreateTestData()
        {
            var result = new List<MaterialOrderGridRow>();

            var random = new Random(1);

            for (int m = 1; m <= 10; m++)
            {
                var material = new MaterialOrderGridRow
                {
                    MaterialId = 1000 + m,
                    MaterialName = "Material " + m,
                    UnitName = "кг",
                    TotalRequested = 0,
                    TotalReceived = 0
                };

                // 2–3 требования на материал
                int requirementCount = random.Next(2, 4);

                for (int r = 1; r <= requirementCount; r++)
                {
                    int requirementId = m * 10 + r;

                    // 1–3 заказа в требовании
                    int orderCount = random.Next(1, 4);

                    for (int o = 1; o <= orderCount; o++)
                    {
                        int orderId = requirementId * 10 + o;

                        double requested = random.Next(5, 30);
                        double received = random.Next(0, (int)requested + 1);

                        material.Orders[orderId] = new OrderMaterialInfo
                        {
                            OrderId = orderId,
                            OrderNumber = orderId,
                            RequirementId = requirementId,
                            RequirementNumber = requirementId,
                            RequirementDate = DateTime.Today.AddDays(-r * 3),

                            RequestedQuantity = requested,
                            ReceivedQuantity = received
                        };

                        material.TotalRequested += requested;
                        material.TotalReceived += received;
                    }
                }

                result.Add(material);
            }

            return result;
        }

    }
}
