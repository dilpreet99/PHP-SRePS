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
    public partial class Form1 : Form
    {
        public Business business = new Business("Default Business", "admin");
        BindingSource staffBindingSource = new BindingSource();

        public Form1()
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
            Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
            business.Staff.Remove(target);
            staffBindingSource.ResetBindings(false);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            business.AddStaff("New", "Salesperson");
            staffBindingSource.ResetBindings(false);

            //Update employee details
            Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
            txbStaffID.Text = target.StaffID.ToString();
            txbFirstName.Text = target.FirstName;
            txbLastName.Text = target.LastName;
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
                    business.ChangePassword(txbBusinessPassword.Text);
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
                txbStaffID.Text = "";
                txbFirstName.Text = "";
                txbLastName.Text = "";
            }
            else
            {
                //Fill in the employee details for the selected employee
                Salesperson target = business.Staff[lsbEmployees.SelectedIndex];
                txbStaffID.Text = target.StaffID.ToString();
                txbFirstName.Text = target.FirstName;
                txbLastName.Text = target.LastName;
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
                business.UpdateStaff(lsbEmployees.SelectedIndex, txbFirstName.Text, txbLastName.Text);
                staffBindingSource.ResetBindings(false);
            }
        }
    }
}
