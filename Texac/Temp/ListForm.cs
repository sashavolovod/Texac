using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.Temp
{
    public partial class ListForm : Form
    {
        SortableBindingList<EmployeeEntity> empList = new SortableBindingList<EmployeeEntity>();
        public ListForm()
        {
            empList.Add(new EmployeeEntity() { EmpId = 1, EmpName = "Иванов И.И.", Birthday = DateTime.Today });
            empList.Add(new EmployeeEntity() { EmpId = 2, EmpName = "Антонов А.А.", Birthday = DateTime.Today.AddYears(-15) });
            empList.Add(new EmployeeEntity() { EmpId = 3, EmpName = "Горохов В.С.", Birthday = DateTime.Today.AddYears(-20) });
            InitializeComponent();
            bsEmployee.DataSource = empList;
        }
    }
}
