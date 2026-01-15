using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Common;

namespace Texac.Request
{
    public partial class RequestForm : Form
    {

        List<ComboBoxEntity> masterList;
        List<ComboBoxEntity> employeeList;
        RequestEntity request;

        public RequestForm()
        {
            InitializeComponent();
            LoadDataAsync();
        }

        public RequestForm(int id)
        {
            InitializeComponent();
            LoadDataAsync();
            GetRequestData(id);
        }

        private async void LoadDataAsync()
        {

            masterList = await DbHelper.GetMasterListAsync();
            employeeList = await DbHelper.GetProcessEngineerListAsync();

            cbMaster.DataSource = masterList;
            cbMaster.DisplayMember = "title";
            cbMaster.ValueMember = "id";
            cbMaster.SelectedIndex = -1;

            cbEmployee.DataSource = employeeList;
            cbEmployee.DisplayMember = "title";
            cbEmployee.ValueMember = "id";
            cbEmployee.SelectedIndex = -1;

        }

        private void tbOrderId_KeyDown(object sender, KeyEventArgs e)
        {
            int orderId;
            if (e.KeyCode == Keys.Enter)
            {
                // Получаем значение из TextBox
                string input = tbOrderId.Text.Trim();

                // Проверка на пустое поле
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Поле 'Номер заказа' не может быть пустым.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrderId.Focus(); // Возвращаем фокус на поле
                    e.Handled = true; // Предотвращаем дальнейшую обработку Enter
                    return;
                }

                // Проверка, что введено целое число
                if (!int.TryParse(input, out orderId))
                {
                    MessageBox.Show("Введите корректное целое число для номера заказа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrderId.Focus();
                    e.Handled = true;
                    return;
                }

                // Проверка, что число положительное
                if (orderId <= 0)
                {
                    MessageBox.Show("Номер заказа должен быть положительным числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrderId.Focus();
                    e.Handled = true;
                    return;
                }

                // Если проверка прошла успешно, можно, например, переместить фокус на следующее поле


                GetRequestData(orderId);
                tbDescription.Focus(); // Или другое поле формы
                e.Handled = true;
                e.SuppressKeyPress = true; // Предотвращаем звуковой сигнал при нажатии Enter

            }
        }

        private async void GetRequestData(int id)
        {
            request = await DbHelper.GetRequestEntityAsync(id);
            tbOrderId.Text = id.ToString();
            tbCustomer.Text = request.Customer;
            tbDescription.Text = request.Description;
            tbQty.Text = request.Qty.ToString();
            dtpRequestDate.Value = request.RequestDate;
            cbEmployee.SelectedValue = request.EmployeeId;
            cbMaster.SelectedValue = request.MasterId;
            tbScopeOfWork.Text = request.ScopeOfWork;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportParameter[] parameters = new ReportParameter[8];
            parameters[0] = new ReportParameter("parCustomer", tbCustomer.Text);
            parameters[1] = new ReportParameter("parOrderNumber", request.OrderNumber);
            parameters[2] = new ReportParameter("parDescription", tbDescription.Text);
            parameters[3] = new ReportParameter("parQty", tbQty.Text);
            parameters[4] = new ReportParameter("parDate", dtpRequestDate.Value.ToShortDateString());
            parameters[5] = new ReportParameter("parEmployee", cbEmployee.Text);
            parameters[6] = new ReportParameter("parMaster", cbMaster.Text);
            parameters[7] = new ReportParameter("parScopeOfWork", tbScopeOfWork.Text);
            
            var report = new RequestReportForm(parameters);
            report.StartPosition = FormStartPosition.CenterScreen;
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }
    }
}
