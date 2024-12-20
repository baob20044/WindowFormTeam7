using api.DTOs.Employee;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.AdminForms.Pages
{
    public partial class AdminEmployeePage : UserControl
    {
        //private readonly Employeec categoryController;
        List<EmployeeDto> employees;
        public AdminEmployeePage()
        {
            InitializeComponent();
        }
    }
}
