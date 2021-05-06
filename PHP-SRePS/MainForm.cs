using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS
{
    public partial class MainForm : Form
    {
        public Business business = new Business("Default Business", "admin");
        BindingSource staffBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            staffBindingSource.DataSource = business.Staff;
            txbBusinessName.Text = business.Name;
            txbBusinessPassword.Text = business.Password;

            lsbEmployees.DisplayMember = "ListString";
            //lsbEmployees.ValueMember = 
            lsbEmployees.DataSource = staffBindingSource;

        }

        private void btnBusinessNameEdit_Click(object sender, EventArgs e)
        {
            if(txbBusinessName.ReadOnly)
            {
                txbBusinessName.ReadOnly = false;
                btnBusinessNameEdit.Text = "Save";
            } else
            {
                txbBusinessName.ReadOnly = true;
                btnBusinessNameEdit.Text = "Edit";
                if(txbBusinessName.Text != "")
                {
                    business.Name = txbBusinessName.Text;
                } else
                {
                    txbBusinessName.Text = business.Name;
                }
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (lsbEmployees.Items.Count > 0)
            {
                business.Staff.Remove(business.Staff[lsbEmployees.SelectedIndex]);
                staffBindingSource.ResetBindings(false);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            business.AddStaff("New", "Salesperson");
            staffBindingSource.ResetBindings(false);

            FillEmployeeDetails(business.Staff[lsbEmployees.SelectedIndex]);
        }

        private void btnBusinessPasswordEdit_Click(object sender, EventArgs e)
        {
            if (txbBusinessPassword.ReadOnly)
            {
                txbBusinessPassword.ReadOnly = false;
                btnBusinessPasswordEdit.Text = "Save";
            }
            else
            {
                txbBusinessPassword.ReadOnly = true;
                btnBusinessPasswordEdit.Text = "Edit";
                if (txbBusinessPassword.Text != "")
                {
                    Authorise("Administrator", business.Password, btnBusinessPasswordEdit);
                }
                else
                {
                    txbBusinessPassword.Text = business.Password;
                }
            }
        }

        private void lsbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbEmployees.SelectedIndex < 0)
            {
                //Empty the employee details if there are no employees
                EmptyEmployeeDetails();
            }
            else
            {
                //Fill in the employee details for the selected employee
                Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
                FillEmployeeDetails(target);
            }
        }

        private void btnEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (btnEmployeeEdit.Text == "Edit Employee")
            {
                txbFirstName.ReadOnly = false;
                txbLastName.ReadOnly = false;
                btnEmployeeEdit.Text = "Save";
            }
            else
            {
                txbFirstName.ReadOnly = true;
                txbLastName.ReadOnly = true;
                btnEmployeeEdit.Text = "Edit Employee";
                if (txbFirstName.Text != "" && txbLastName.Text != "")
                {
                    //Update the business staff object if both textboxes are not empty
                    Authorise("Administrator", business.Password, btnEmployeeEdit);
                } else
                {
                    //If one of the textboxes is empty disregard changes and revert textbox text
                    FillEmployeeDetails(business.Staff[lsbEmployees.SelectedIndex]);
                }
            }
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            if (lsbEmployees.Items.Count > 0)
            {
                Salesperson target = business.Staff[lsbEmployees.SelectedIndex];

                if (target.DayStart == DateTime.MinValue)
                {
                    btnClock.Text = "CLOCK OUT";
                    target.DayStart = DateTime.Now;
                }
                else
                {
                    btnClock.Text = "CLOCK IN";
                    target.DayEnd = DateTime.Now;
                    target.AddDayHours();
                    FillEmployeeDetails(target);
                }
            }
        }

        public void FillEmployeeDetails(Salesperson target)
        {
            txbStaffID.Text = target.StaffID.ToString();
            txbFirstName.Text = target.FirstName;
            txbLastName.Text = target.LastName;
            txbHoursThisWeek.Text = target.HoursThisWeek.TotalHours.ToString("N2");
            txbHoursTotal.Text = target.HoursTotal.TotalHours.ToString("N2");

            //Reset the clock state if the employee is clocked in/out
            if (target.DayStart == DateTime.MinValue)
            {
                btnClock.Text = "CLOCK IN";
            }
            else
            {
                btnClock.Text = "CLOCK OUT";
            }
            btnClock.Enabled = true;
        }

        public void EmptyEmployeeDetails()
        {
            txbStaffID.Text = "";
            txbFirstName.Text = "";
            txbLastName.Text = "";
            btnClock.Enabled = false;
        }

        public void Authorise(string username, string password, object sender)
        {
            //Create a login form which will ask the user for a password
            LoginForm login = new LoginForm(this, username, password, sender);
            login.Show();
            this.Enabled = false;
        }

        public void PostAuthorise(object sender)
        {
            //Do different things depending on who requested the authorisation
            ///Saving change in business password
            if (sender == btnBusinessPasswordEdit)
                business.ChangePassword(txbBusinessPassword.Text);
            ///Saving change in employee data
            if (sender == btnEmployeeEdit)
            {
                business.UpdateStaff(lsbEmployees.SelectedIndex, txbFirstName.Text, txbLastName.Text);
                staffBindingSource.ResetBindings(false);
            }
        }
    }
}
