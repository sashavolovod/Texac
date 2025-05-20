using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.Trebovaniya
{
    public partial class MaterialAvailabilityForm : Form
    {
        private List<MaterialDTO> materials;
        private ImageList imageList;
        private Color warningColor = Color.DarkRed;
        private string ids;

        // private Dictionary<int, double> avalibleMaterialsMap;
        public MaterialAvailabilityForm(string ids)
        {
            this.ids = ids;
            InitializeComponent();
            InitializeListView();
            LoadData();
            
        }

        private async void LoadData()
        {
            Cursor = Cursors.WaitCursor;
            materials = await GetMaterialListAsync();
            PopulateListView();
            Cursor = Cursors.Default;
        }

        public async Task<List<MaterialDTO>> GetMaterialListAsync()
        {
            return await Task.Run(() => GetMaterialList());
        }

        private void InitializeListView()
        {
            lvMaterials.Dock = DockStyle.Fill;
            lvMaterials.View = View.Details;
            lvMaterials.FullRowSelect = true;
            lvMaterials.GridLines = true;
            lvMaterials.OwnerDraw = true;

            // Добавляем колонки
            lvMaterials.Columns.Add("ID", 100);
            lvMaterials.Columns.Add("Название материала", 400);
            lvMaterials.Columns.Add("Количество", 150);
            lvMaterials.Columns.Add("В наличии", 150);

            // Создаём ImageList для иконок сворачивания/разворачивания
            imageList = new ImageList();
            imageList.ImageSize = new Size(16, 16);
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            // Создаем иконки
            Bitmap collapsedIcon = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(collapsedIcon))
            {
                g.Clear(Color.Transparent);
                g.DrawRectangle(Pens.Black, 4, 4, 8, 8);
                g.DrawLine(Pens.Black, 6, 8, 10, 8);
                g.DrawLine(Pens.Black, 8, 6, 8, 10);
            }

            Bitmap expandedIcon = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(expandedIcon))
            {
                g.Clear(Color.Transparent);
                g.DrawRectangle(Pens.Black, 4, 4, 8, 8);
                g.DrawLine(Pens.Black, 6, 8, 10, 8);
            }

            imageList.Images.Add("collapsed", collapsedIcon);
            imageList.Images.Add("expanded", expandedIcon);

            lvMaterials.SmallImageList = imageList;

            // Добавляем обработчики событий
            lvMaterials.MouseClick += ListView1_MouseClick;
            lvMaterials.DrawColumnHeader += ListView1_DrawColumnHeader;
            lvMaterials.DrawSubItem += ListView1_DrawSubItem;

            this.Controls.Add(lvMaterials);
        }

        private void PopulateListView()
        {
            lvMaterials.Items.Clear();

            foreach (var material in materials)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    material.materialId.ToString(),
                    material.materialTitle,
                    material.quantity.ToString(),
                    material.quantityAvalible.ToString()
                });

                item.ImageKey = "collapsed";
                item.Tag = material;

                lvMaterials.Items.Add(item);
            }
        }

        private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            MaterialDTO material = e.Item.Tag as MaterialDTO;
            if (material != null)
            {
                // Выделяем цветом если материал не хватает
                Color textColor;
                Color backColor;

                if (material.quantityAvalible - material.quantity < 0)
                {
                    textColor = warningColor;
                    backColor = Color.MistyRose;
                }
                else
                {
                    textColor = e.Item.ForeColor;
                    backColor = e.Item.BackColor;
                }


                // Создаем новый прямоугольник для текста с учетом отступа для иконки
                Rectangle bounds = e.Bounds;

                // Отрисовываем фон
                using (var brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }

                // Отрисовываем иконку для первой колонки
                if (e.ColumnIndex == 0 && !string.IsNullOrEmpty(e.Item.ImageKey))
                {
                    int imageWidth = lvMaterials.SmallImageList.ImageSize.Width;
                    int imageHeight = lvMaterials.SmallImageList.ImageSize.Height;
                    int imageY = e.Bounds.Top + (e.Bounds.Height - imageHeight) / 2;

                    lvMaterials.SmallImageList.Draw(e.Graphics, e.Bounds.Left, imageY,
                        lvMaterials.SmallImageList.Images.IndexOfKey(e.Item.ImageKey));

                    bounds.X += imageWidth;
                    bounds.Width -= imageWidth;
                }

                // Отрисовываем текст
                TextFormatFlags flags;
                if (e.ColumnIndex == 1)
                {
                    flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                }
                else
                {
                    flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                }
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, bounds, textColor, flags);
            }
            else if (e.Item.Tag is OrderDTO)
            {
                // Отрисовываем фон
                using (var brush = new SolidBrush(e.Item.BackColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }

                // Отрисовываем текст заказа
                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, e.Bounds, e.Item.ForeColor, flags);
            }
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvMaterials.GetItemAt(e.X, e.Y);
            if (item != null && e.X < 20) // Проверяем клик по иконке
            {
                MaterialDTO material = item.Tag as MaterialDTO;
                if (material != null)
                {
                    if (item.ImageKey == "collapsed")
                    {
                        // Разворачиваем заказы
                        item.ImageKey = "expanded";
                        foreach (var order in material.orders)
                        {
                            ListViewItem orderItem = new ListViewItem(new string[]
                            {
                            $"    ",
                            $"  Требование №{order.docNumber}",
                            order.quantity.ToString()
                            });
                            orderItem.Tag = order;
                            int index = item.Index + 1;
                            lvMaterials.Items.Insert(index, orderItem);
                        }
                    }
                    else
                    {
                        // Сворачиваем заказы
                        item.ImageKey = "collapsed";
                        int index = item.Index + 1;
                        while (index < lvMaterials.Items.Count &&
                               lvMaterials.Items[index].Text.StartsWith("    "))
                        {
                            lvMaterials.Items.RemoveAt(index);
                        }
                    }
                }
            }
        }
        public Dictionary<int, double> GetMaterialAvailable()
        {
            var materials = new Dictionary<int, double>();
            try
            {
                using (var connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
                {
                    
                }
            }
            catch (OleDbException ex)
            {
                throw new InvalidOperationException("Ошибка при получении данных о материалах", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Непредвиденная ошибка при получении данных об остатках", ex);
            }

            return materials;
        }

        public List<MaterialDTO> GetMaterialList()
        {
            var avalibleMaterialsMap = new Dictionary<int, double>();
            List<MaterialDTO> materialsList = new List<MaterialDTO>();
            var materialsDict = new Dictionary<int, MaterialDTO>();

            try
            {
                using (var connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
                {
                    connection.Open();
                    string query = @"SELECT НомСкладКарт AS id, NKOLTEK AS qty FROM ОстаткиМатериаловНаСкладах WHERE CCODESCLAD <> '750'";

                    using (var command = new OleDbCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["id"] != DBNull.Value && reader["qty"] != DBNull.Value)
                            {
                                var materialId = Convert.ToInt32(reader["id"]);
                                var quantity = Convert.ToDouble(reader["qty"]);

                                if (avalibleMaterialsMap.ContainsKey(materialId))
                                {
                                    avalibleMaterialsMap[materialId] += quantity;
                                }
                                else
                                {
                                    avalibleMaterialsMap.Add(materialId, quantity);
                                }
                            }
                        }
                    }
                    
                    query = $@"
SELECT 
    tblTrebovanieDetails.ASUPCODE AS materialId,
    tblTrebovanieDetails.tblTrebovanielId AS orderId, 
    tblTrebovanieDetails.Kol1 AS quantity, 
    tblTrebovanieDetails.Material AS materialTitle, 
    tblTrebovanie.DocNumber as docNumber
FROM tblTrebovanie 
INNER JOIN tblTrebovanieDetails ON tblTrebovanie.TrebovanieId = tblTrebovanieDetails.tblTrebovanielId 
WHERE tblTrebovanielId In {ids};
";


                    using (var command = new OleDbCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var materialId = (DBNull.Value == reader["materialId"] ? 0 : Convert.ToInt32(reader["materialId"]));
                            var orderId = Convert.ToInt32(reader["orderId"]);
                            var docNumber = Convert.ToInt32(reader["docNumber"]);
                            var quantity =  (DBNull.Value == reader["quantity"] ? 0 :  Convert.ToDouble(reader["quantity"]));
                            var materialTitle = reader["materialTitle"]?.ToString() ?? "";

                            // Если материал еще не добавлен в словарь, создаем новую запись
                            if (!materialsDict.ContainsKey(materialId))
                            {
                                materialsDict[materialId] = new MaterialDTO
                                {
                                    materialId = materialId,
                                    materialTitle = materialTitle,
                                    quantity = 0,
                                    quantityAvalible = avalibleMaterialsMap.ContainsKey(materialId) ? avalibleMaterialsMap[materialId] : 0,
                                    orders = new List<OrderDTO>()
                                };
                            }

                            // Добавляем заказ к материалу
                            materialsDict[materialId].orders.Add(new OrderDTO
                            {
                                orderId = orderId,
                                docNumber = docNumber,
                                quantity = quantity
                            });

                            // Обновляем общее количество материала
                            materialsDict[materialId].quantity += quantity;
                        }
                    }
                }

                materialsList = new List<MaterialDTO>(materialsDict.Values);
            }
            catch (OleDbException ex)
            {
                throw new InvalidOperationException("Ошибка при получении данных о материалах", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Непредвиденная ошибка при получении данных об остатках", ex);
            }

            return materialsList;
        }
    }
}
