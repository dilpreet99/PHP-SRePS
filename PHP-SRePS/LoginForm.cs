using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHP_SRePS
{
    public partial class LoginForm : Form
    {
        private MainForm _mainForm;
        private string _username;
        private string _password;
        private object _sender;

        public LoginForm(MainForm callingForm, string username, string password, object sender)
        {
            _mainForm = callingForm;
            _username = username;
            _password = password;
            _sender = sender;

            InitializeComponent();
            lblUsername.Text = username;
            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == _password)
            {
                //If the user has the requested password then authorise the function
                lblIncorrect.Visible = false;
                _mainForm.Enabled = true;
                _mainForm.PostAuthorise(_sender);
                this.Close();
            }
            else
            {
                lblIncorrect.Visible = true;
                txbPassword.Text = "";
            }
        }

        private void LoginForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _mainForm.Enabled = true;
            _mainForm.Refill();
        }
    }
}
