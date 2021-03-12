using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONETWindowsForm
{
    public partial class FormHR : Form
    {
        public FormHR()
        {
            InitializeComponent();
            FillComboBoxHRName();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillComboBoxHRName()
        {
            using (var context = new Trainee1334Entities())
            {
                var query = from emp in context.Employees
                            where emp.DeptID == 1
                            select emp;
                comboBox1.DataSource = query.ToList();
                comboBox1.DisplayMember = "EmpName";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Trainee1334Entities())
            {
                var hrname = comboBox1.Text;
                var hrcheck1 = context.Employees.Where(c => c.EmpName == hrname).FirstOrDefault();
                var hrid = hrcheck1.EmpID;
                var q = context.Appointments.Where(c=>c.HRID==hrid).Select(c => new { c.AppointmentDate, c.Slot }).ToList();
                dataGridView1.DataSource = q;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormView check = new FormView();
            check.Show();
            Hide();
        }

        
    }
}
