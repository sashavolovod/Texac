using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace Texac.LocksmithOperations
{
    public partial class LocksmithOperationControl : UserControl
    {
        private List<LocksmithOperationView> data = new List<LocksmithOperationView>();
        private string reportType = "by-category";

        public LocksmithOperationControl()
        {
            InitializeComponent();
            dtEnd.Value = DateTime.Today;

        }

        public async Task<List<LocksmithOperationView>> GetDataAsync(DateTime startDate, DateTime endDate)
        {

            string baseApiUrl = Texac.Properties.Settings.Default.api_path;
            string url = $"{baseApiUrl}/locksmith-operations/{reportType}?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<LocksmithOperationView>>(jsonResponse);
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                data = await GetDataAsync(dtStart.Value, dtEnd.Value);
                double timeNorm = 0.0;
                foreach (var item in data)
                {
                    if (string.IsNullOrEmpty(item.CategoryName))
                    {
                        item.CategoryName = "Другое";
                    }
                    if (string.IsNullOrEmpty(item.LocksmithName))
                    {
                        item.LocksmithName = "Не указан";
                    }
                    if (item.CategoryName == "Пресс-формы на GEFEST 6.0 / 6.1")
                    {
                        timeNorm = item.TimeNorm ?? 0;
                    }
                }

                foreach (var item in data)
                {
                    if (item.CategoryName == "Пресс-формы (алюминий)")
                    {
                        item.TimeNorm += timeNorm;
                        break;
                    }
                }

                bs.DataSource = new SortableBindingList<LocksmithOperationView>(data);

                if (rbCategory.Checked)
                {
                    GenerateBarChart1();
                }
                else if (rbLocksmith.Checked)
                {
                    GenerateBarChart2();
                }
                else if (rbCustomer.Checked)
                {
                    GenerateBarChart3();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategory.Checked)
            {
                reportType = "by-category";
                locksmithNameDataGridViewTextBoxColumn.Visible = false;
                customerTitleDataGridViewTextBoxColumn.Visible = false;
            }
            else if (rbLocksmith.Checked)
            {
                reportType = "by-category-and-locksmith";
                locksmithNameDataGridViewTextBoxColumn.Visible = true;
                customerTitleDataGridViewTextBoxColumn.Visible = false;
            }
            else if (rbCustomer.Checked)
            {
                reportType = "by-category-and-customer";
                locksmithNameDataGridViewTextBoxColumn.Visible = false;
                customerTitleDataGridViewTextBoxColumn.Visible = true;
            }
        }

        // Метод для получения разных цветов для столбцов
        private static Color GetColorByIndex(int index)
        {
            Color[] colors = new Color[]
            {
            Color.SteelBlue,
            Color.IndianRed,
            Color.ForestGreen,
            Color.Orange,
            Color.Purple,
            Color.DarkTurquoise
            };

            return colors[index % colors.Length];
        }

        private void GenerateBarChart1()
        {
            if (tabPage1.Controls.Count > 0)
                tabPage1.Controls.Clear();

            var chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart.Dock = DockStyle.Fill;


            // Настройка области графика
            var chartArea = new ChartArea();
            chartArea.Name = "MainChartArea";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 9f);
            chartArea.AxisY.Title = "Время (часы)";
            chartArea.AxisY.TitleFont = new Font("Arial", 10f, FontStyle.Bold);
            chart.ChartAreas.Add(chartArea);

            // Создание серии данных
            var series = new Series();
            series.Name = "TimeNorm";
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "MainChartArea";

            // Настройка отображения значений
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "F1"; // Один знак после запятой
            series.Font = new Font("Arial", 9f);

            // Добавление данных к серии
            foreach (var item in data)
            {
                series.Points.AddXY(item.CategoryName, item.TimeNorm);
            }

            // Настройка цветов столбцов
            for (int i = 0; i < series.Points.Count; i++)
            {
                series.Points[i].Color = GetColorByIndex(i);
            }

            chart.Series.Add(series);

            // Добавление заголовка
            var title = new Title();
            title.Text = "Распределение времени по категориям";
            title.Font = new Font("Arial", 14f, FontStyle.Bold);
            chart.Titles.Add(title);

            this.tabPage1.Controls.Add(chart);
        }

        private static Color GetCategoryColor(string categoryName, int index)
        {
            Dictionary<string, Color> categoryColors = new Dictionary<string, Color>
        {
            { "Пресс-формы (алюминий)", Color.SteelBlue },
            { "Пресс-формы на GEFEST 6.0 / 6.1", Color.IndianRed },
            { "Пресс-формы (пластик)", Color.ForestGreen },
            { "Приспособления", Color.Orange },
            { "Штампы", Color.Purple },
            { "Другое", Color.Gray }
        };

            if (categoryColors.ContainsKey(categoryName))
                return categoryColors[categoryName];

            // Если категория не найдена, используем автоматически сгенерированный цвет
            Color[] autoColors = new Color[]
            {
            Color.Teal, Color.DarkOrange, Color.MediumPurple,
            Color.Crimson, Color.SeaGreen, Color.RoyalBlue
            };

            return autoColors[index % autoColors.Length];
        }

        private void GenerateBarChart2()
        {
            if (tabPage1.Controls.Count > 0)
                tabPage1.Controls.Clear();

            // Получаем список уникальных категорий и работников
            var categories = data.Select(x => x.CategoryName).Distinct().OrderBy(x => x).ToList();

            // Группируем данные по категориям и работникам, суммируя timeNorm
            var groupedData = data
                .GroupBy(d => new { d.CategoryName, d.LocksmithName })
                .Select(g => new {
                    Category = g.Key.CategoryName,
                    Worker = g.Key.LocksmithName,
                    TotalTime = g.Sum(x => x.TimeNorm ?? 0)
                })
                .Where(x => x.TotalTime > 0) // Отфильтровываем записи с нулевым временем
                .ToList();

            // Находим топ-25 работников по общему затраченному времени
            var top15Workers = groupedData
                .GroupBy(d => d.Worker)
                .Select(g => new {
                    Worker = g.Key,
                    TotalTime = g.Sum(x => x.TotalTime)
                })
                .OrderByDescending(x => x.TotalTime)
                .Take(32)
                .Select(x => x.Worker)
                .ToList();

            // Фильтруем данные только для топ-25 работников
            var filteredData = groupedData
                .Where(d => top15Workers.Contains(d.Worker))
                .ToList();

            // Создание графика
            var chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart.Dock = DockStyle.Fill;

            chart.BackColor = Color.White;
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.BorderlineWidth = 1;
            chart.BorderlineColor = Color.LightGray;

            // Настройка области графика
            var chartArea = new ChartArea();
            chartArea.Name = "MainChartArea";
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 9f);
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Title = "Работники";
            chartArea.AxisX.TitleFont = new Font("Arial", 10f, FontStyle.Bold);

            chartArea.AxisY.Title = "Время (часы)";
            chartArea.AxisY.TitleFont = new Font("Arial", 10f, FontStyle.Bold);
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartArea.BackColor = Color.White;
            chart.ChartAreas.Add(chartArea);

            // Добавление заголовка
            var title = new Title();
            title.Text = "Распределение времени по работникам и категориям";
            title.Font = new Font("Arial", 16f, FontStyle.Bold);
            title.Alignment = ContentAlignment.TopCenter;
            chart.Titles.Add(title);

            // Добавление легенды
            var legend = new Legend();
            legend.Name = "MainLegend";
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.BackColor = Color.White;
            legend.BorderColor = Color.LightGray;
            legend.BorderWidth = 1;
            legend.Font = new Font("Arial", 9f);
            chart.Legends.Add(legend);

            // Генерируем серии данных для каждой категории
            foreach (var category in categories)
            {
                var series = new Series();
                series.Name = category;
                series.ChartType = SeriesChartType.StackedColumn;
                series.ChartArea = "MainChartArea";
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "F1";
                series.Font = new Font("Arial", 8f);
                series.BorderWidth = 1;
                series.BorderColor = Color.FromArgb(64, 64, 64);

                // Установка цвета для серии данных
                series.Color = GetCategoryColor(category, categories.IndexOf(category));
                
                // Устанавливаем белый цвет для значений на столбцах
                series.LabelForeColor = Color.WhiteSmoke;

                chart.Series.Add(series);
            }

            // Заполняем данными
            foreach (var worker in top15Workers)
            {
                // Добавляем точки для каждой категории по этому работнику
                foreach (var category in categories)
                {
                    var workerCategoryData = filteredData
                        .FirstOrDefault(d => d.Worker == worker && d.Category == category);

                    double timeHours = 0;
                    if (workerCategoryData != null)
                    {
                        timeHours = workerCategoryData.TotalTime;
                    }

                    // Если время менее 0.1 часа, не добавляем точку для лучшей читаемости
                    if (timeHours >= 0.1)
                    {
                        var point = new DataPoint();
                        point.AxisLabel = worker;
                        point.YValues = new double[] { timeHours };
                        chart.Series[category].Points.Add(point);
                    }
                    else
                    {
                        // Добавляем пустую точку для сохранения порядка
                        var point = new DataPoint();
                        point.AxisLabel = worker;
                        point.YValues = new double[] { 0 };
                        point.IsEmpty = true;
                        chart.Series[category].Points.Add(point);
                    }
                }
            }

            // Устанавливаем кастомные метки оси X
            chart.ChartAreas["MainChartArea"].AxisX.Interval = 1;
            chart.ChartAreas["MainChartArea"].AxisX.CustomLabels.Clear();
            chart.ChartAreas["MainChartArea"].AxisX.LabelStyle.Angle = -90;

            // Добавляем метки для каждого работника
            for (int i = 0; i < top15Workers.Count; i++)
            {
                // Добавляем кастомную метку для каждого работника
                // (позиция 0.5 + i размещает метку по центру столбца)
                chart.ChartAreas["MainChartArea"].AxisX.CustomLabels.Add(
                    i + 0.5,
                    i + 1.5,
                    top15Workers[i],
                    0,
                    LabelMarkStyle.None);
            }


            this.tabPage1.Controls.Add(chart);
        }
        private void GenerateBarChart3()
        {
            if (tabPage1.Controls.Count > 0)
                tabPage1.Controls.Clear();

            // Получаем список уникальных категорий и заказчиков
            var categories = data.Select(x => x.CategoryName).Distinct().OrderBy(x => x).ToList();

            // Группируем данные по категориям и заказчикам, суммируя timeNorm
            var groupedData = data
                .GroupBy(d => new { d.CategoryName, d.CustomerTitle})
                .Select(g => new {
                    Category = g.Key.CategoryName,
                    Customer = g.Key.CustomerTitle,
                    TotalTime = g.Sum(x => x.TimeNorm ?? 0)
                })
                .Where(x => x.TotalTime > 0) // Отфильтровываем записи с нулевым временем
                .ToList();

            // Находим топ-15 заказчиков по общему затраченному времени
            var top15Customers = groupedData
                .GroupBy(d => d.Customer)
                .Select(g => new {
                    Customer = g.Key,
                    TotalTime = g.Sum(x => x.TotalTime)
                })
                .OrderByDescending(x => x.TotalTime)
                .Take(15)
                .Select(x => x.Customer)
                .ToList();

            // Фильтруем данные только для топ-15 заказчиков
            var filteredData = groupedData
                .Where(d => top15Customers.Contains(d.Customer))
                .ToList();

            // Создание графика
            var chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart.Dock = DockStyle.Fill;

            chart.BackColor = Color.White;
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.BorderlineWidth = 1;
            chart.BorderlineColor = Color.LightGray;

            // Настройка области графика
            var chartArea = new ChartArea();
            chartArea.Name = "MainChartArea";
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 9f);
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Title = "Заказчики";
            chartArea.AxisX.TitleFont = new Font("Arial", 10f, FontStyle.Bold);

            chartArea.AxisY.Title = "Время (часы)";
            chartArea.AxisY.TitleFont = new Font("Arial", 10f, FontStyle.Bold);
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartArea.BackColor = Color.White;
            chart.ChartAreas.Add(chartArea);

            // Добавление заголовка
            var title = new Title();
            title.Text = "Распределение времени по заказчикам и категориям";
            title.Font = new Font("Arial", 16f, FontStyle.Bold);
            title.Alignment = ContentAlignment.TopCenter;
            chart.Titles.Add(title);

            // Добавление легенды
            var legend = new Legend();
            legend.Name = "MainLegend";
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.BackColor = Color.White;
            legend.BorderColor = Color.LightGray;
            legend.BorderWidth = 1;
            legend.Font = new Font("Arial", 9f);
            chart.Legends.Add(legend);

            // Генерируем серии данных для каждой категории
            foreach (var category in categories)
            {
                var series = new Series();
                series.Name = category;
                series.ChartType = SeriesChartType.StackedColumn;
                series.ChartArea = "MainChartArea";
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "F1";
                series.Font = new Font("Arial", 8f);
                series.BorderWidth = 1;
                series.BorderColor = Color.FromArgb(64, 64, 64);

                // Установка цвета для серии данных
                series.Color = GetCategoryColor(category, categories.IndexOf(category));

                // Устанавливаем белый цвет для значений на столбцах
                series.LabelForeColor = Color.WhiteSmoke;

                chart.Series.Add(series);
            }

            // Заполняем данными
            foreach (var customer in top15Customers)
            {
                // Добавляем точки для каждой категории по этому заказчику
                foreach (var category in categories)
                {
                    var customerCategoryData = filteredData
                        .FirstOrDefault(d => d.Customer == customer && d.Category == category);

                    double timeHours = 0;
                    if (customerCategoryData != null)
                    {
                        timeHours = customerCategoryData.TotalTime;
                    }

                    // Если время менее 0.1 часа, не добавляем точку для лучшей читаемости
                    if (timeHours >= 0.1)
                    {
                        var point = new DataPoint();
                        point.AxisLabel = customer;
                        point.YValues = new double[] { timeHours };
                        chart.Series[category].Points.Add(point);
                    }
                    else
                    {
                        // Добавляем пустую точку для сохранения порядка
                        var point = new DataPoint();
                        point.AxisLabel = customer;
                        point.YValues = new double[] { 0 };
                        point.IsEmpty = true;
                        chart.Series[category].Points.Add(point);
                    }
                }
            }

            // Устанавливаем кастомные метки оси X
            chart.ChartAreas["MainChartArea"].AxisX.Interval = 1;
            chart.ChartAreas["MainChartArea"].AxisX.CustomLabels.Clear();
            chart.ChartAreas["MainChartArea"].AxisX.LabelStyle.Angle = -90;

            // Добавляем метки для каждого работника
            for (int i = 0; i < top15Customers.Count; i++)
            {
                // Добавляем кастомную метку для каждого работника
                // (позиция 0.5 + i размещает метку по центру столбца)
                chart.ChartAreas["MainChartArea"].AxisX.CustomLabels.Add(
                    i + 0.5,
                    i + 1.5,
                    top15Customers[i],
                    0,
                    LabelMarkStyle.None);
            }


            this.tabPage1.Controls.Add(chart);
        }
    }
}
