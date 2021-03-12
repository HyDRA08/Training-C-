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
using System.Globalization;

namespace ADONETWindowsForm
{
    
    public partial class FormEmployee : Form
    {
        
        public FormEmployee()
        {

            InitializeComponent();
            FillComboBoxEmpName();
            FillComboBoxHRName();
            FillComboBoxSlots();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        public void FillComboBoxEmpName()
        {
            using (var context = new Trainee1334Entities())
            {
                var query = from emp in context.Employees
                                where emp.DeptID != 1
                                select emp;
                comboBox1.DataSource = query.ToList();
                comboBox1.DisplayMember = "EmpName";

            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void FillComboBoxHRName()
        {
            using (var context = new Trainee1334Entities())
            {
                var query = from emp in context.Employees
                            where emp.DeptID == 1
                            select emp;
                comboBox2.DataSource = query.ToList();
                comboBox2.DisplayMember = "EmpName";

            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void FillComboBoxSlots()
        {
            using (var context = new Trainee1334Entities())
            {
                var query = from slt in context.Slots
                            select slt;
                comboBox3.DataSource = query.ToList();
                comboBox3.DisplayMember = "SlotTime";

            }
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Trainee1334Entities())
                {
                    string check_Date1 = dateTimePicker1.Text;
                    DateTime oDate = Convert.ToDateTime(check_Date1);
                    int DateExist1 = context.Holidays.Where(c=>c.HolidayDate == oDate).ToList().Count();
                    if (DateExist1 > 0)
                    {
                        string message = "HoliDay! Cannot Book Appointment";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        var empname = comboBox1.Text;
                        var Employeecheck1 = context.Employees.Where(c => c.EmpName == empname).FirstOrDefault();
                        var empid = Employeecheck1.EmpID;

                        var hrname = comboBox2.Text;
                        var hrcheck1 = context.Employees.Where(c => c.EmpName == hrname).FirstOrDefault();
                        var hrid = hrcheck1.EmpID;

                        var slotdatecheck1 = comboBox3.Text;
                        var Exist1 = context.Appointments.Where(c => c.AppointmentDate == check_Date1 && c.HRID == hrid && c.Slot == slotdatecheck1).ToList();

                        if (Exist1.Any())
                        {
                            string message = "Appointment Already Exists ";
                            MessageBox.Show(message);
                        }
                        else
                        {
                            var Exist2 = context.Appointments.Where(c => c.AppointmentDate == check_Date1 && c.EmpID == empid && c.Slot == slotdatecheck1).ToList();
                            if (Exist2.Any())
                            {
                                string message = "Appointment Already Exists ";
                                MessageBox.Show(message);
                            }
                            else
                            {
                                var Exist3 = context.Appointments.Where(c => c.AppointmentDate == check_Date1 && c.EmpID == hrid && c.Slot == slotdatecheck1).ToList();
                                if (Exist3.Any())
                                {
                                    string message = "Appointment Already Exists ";
                                    MessageBox.Show(message);
                                }
                                else
                                {
                                    DayOfWeek selectedDay = DateTime.Parse(this.dateTimePicker1.Text).Date.DayOfWeek;
                                    if (dateTimePicker1.Value < DateTime.Today)
                                    {
                                        string message = "Past Date!";
                                        MessageBox.Show(message);
                                        FormEmployee check = new FormEmployee();
                                        check.Show();
                                        Hide();
                                    }
                                    else if (selectedDay == DayOfWeek.Saturday || selectedDay == DayOfWeek.Sunday || selectedDay == DayOfWeek.Wednesday)
                                    {

                                        MessageBox.Show("Bookings cannot be done on Wednesday and Weekends !");
                                        FormEmployee back = new FormEmployee();
                                        back.Show();
                                        Hide();
                                    }
                                    else
                                    {
                                        Appointment App = new Appointment();
                                        App.AppointmentDate = check_Date1;
                                        App.EmpID = empid;
                                        App.HRID = hrid;
                                        App.Slot = slotdatecheck1;
                                        try
                                        {
                                            context.Appointments.Add(App);
                                            context.SaveChanges();
                                            string message = "Appointment Created!";
                                            MessageBox.Show(message);
                                        }

                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }


                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                string message = "Enter all Columns!";
                MessageBox.Show(message );
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormView check = new FormView();
            check.Show();
            Hide();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
  
        }
    }
}