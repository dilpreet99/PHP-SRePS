
namespace PHP_SRePS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnEmployeeEdit = new System.Windows.Forms.Button();
            this.lblBusinessPassword = new System.Windows.Forms.Label();
            this.btnBusinessPasswordEdit = new System.Windows.Forms.Button();
            this.txbBusinessPassword = new System.Windows.Forms.TextBox();
            this.txbHoursTotal = new System.Windows.Forms.TextBox();
            this.txbHoursThisWeek = new System.Windows.Forms.TextBox();
            this.lblHoursTotal = new System.Windows.Forms.Label();
            this.lblHoursThisWeek = new System.Windows.Forms.Label();
            this.btnViewEmployeeSale = new System.Windows.Forms.Button();
            this.lblEmployeeSales = new System.Windows.Forms.Label();
            this.lsbEmployeeSales = new System.Windows.Forms.ListBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txbStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lsbEmployees = new System.Windows.Forms.ListBox();
            this.btnBusinessNameEdit = new System.Windows.Forms.Button();
            this.txbBusinessName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Sales Reporting and Prediction System";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(556, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 14);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "V_1.0.1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 391);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClock);
            this.tabPage1.Controls.Add(this.btnEmployeeEdit);
            this.tabPage1.Controls.Add(this.lblBusinessPassword);
            this.tabPage1.Controls.Add(this.btnBusinessPasswordEdit);
            this.tabPage1.Controls.Add(this.txbBusinessPassword);
            this.tabPage1.Controls.Add(this.txbHoursTotal);
            this.tabPage1.Controls.Add(this.txbHoursThisWeek);
            this.tabPage1.Controls.Add(this.lblHoursTotal);
            this.tabPage1.Controls.Add(this.lblHoursThisWeek);
            this.tabPage1.Controls.Add(this.btnViewEmployeeSale);
            this.tabPage1.Controls.Add(this.lblEmployeeSales);
            this.tabPage1.Controls.Add(this.lsbEmployeeSales);
            this.tabPage1.Controls.Add(this.txbLastName);
            this.tabPage1.Controls.Add(this.lblLastName);
            this.tabPage1.Controls.Add(this.txbFirstName);
            this.tabPage1.Controls.Add(this.lblFirstName);
            this.tabPage1.Controls.Add(this.txbStaffID);
            this.tabPage1.Controls.Add(this.lblStaffID);
            this.tabPage1.Controls.Add(this.lblBusinessName);
            this.tabPage1.Controls.Add(this.btnRemoveEmployee);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.lblEmployees);
            this.tabPage1.Controls.Add(this.lsbEmployees);
            this.tabPage1.Controls.Add(this.btnBusinessNameEdit);
            this.tabPage1.Controls.Add(this.txbBusinessName);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Business";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClock
            // 
            this.btnClock.Enabled = false;
            this.btnClock.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClock.Location = new System.Drawing.Point(230, 279);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(150, 33);
            this.btnClock.TabIndex = 25;
            this.btnClock.Text = "CLOCK IN";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnEmployeeEdit
            // 
            this.btnEmployeeEdit.Location = new System.Drawing.Point(230, 327);
            this.btnEmployeeEdit.Name = "btnEmployeeEdit";
            this.btnEmployeeEdit.Size = new System.Drawing.Size(150, 23);
            this.btnEmployeeEdit.TabIndex = 24;
            this.btnEmployeeEdit.Text = "Edit Employee";
            this.btnEmployeeEdit.UseVisualStyleBackColor = true;
            this.btnEmployeeEdit.Click += new System.EventHandler(this.btnEmployeeEdit_Click);
            // 
            // lblBusinessPassword
            // 
            this.lblBusinessPassword.AutoSize = true;
            this.lblBusinessPassword.Location = new System.Drawing.Point(352, 11);
            this.lblBusinessPassword.Name = "lblBusinessPassword";
            this.lblBusinessPassword.Size = new System.Drawing.Size(99, 15);
            this.lblBusinessPassword.TabIndex = 23;
            this.lblBusinessPassword.Text = "Admin password:";
            // 
            // btnBusinessPasswordEdit
            // 
            this.btnBusinessPasswordEdit.Location = new System.Drawing.Point(505, 29);
            this.btnBusinessPasswordEdit.Name = "btnBusinessPasswordEdit";
            this.btnBusinessPasswordEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBusinessPasswordEdit.TabIndex = 22;
            this.btnBusinessPasswordEdit.Text = "Edit";
            this.btnBusinessPasswordEdit.UseVisualStyleBackColor = true;
            this.btnBusinessPasswordEdit.Click += new System.EventHandler(this.btnBusinessPasswordEdit_Click);
            // 
            // txbBusinessPassword
            // 
            this.txbBusinessPassword.Location = new System.Drawing.Point(352, 29);
            this.txbBusinessPassword.Name = "txbBusinessPassword";
            this.txbBusinessPassword.ReadOnly = true;
            this.txbBusinessPassword.Size = new System.Drawing.Size(147, 23);
            this.txbBusinessPassword.TabIndex = 21;
            this.txbBusinessPassword.UseSystemPasswordChar = true;
            // 
            // txbHoursTotal
            // 
            this.txbHoursTotal.Location = new System.Drawing.Point(230, 241);
            this.txbHoursTotal.Name = "txbHoursTotal";
            this.txbHoursTotal.ReadOnly = true;
            this.txbHoursTotal.Size = new System.Drawing.Size(150, 23);
            this.txbHoursTotal.TabIndex = 20;
            // 
            // txbHoursThisWeek
            // 
            this.txbHoursThisWeek.Location = new System.Drawing.Point(230, 197);
            this.txbHoursThisWeek.Name = "txbHoursThisWeek";
            this.txbHoursThisWeek.ReadOnly = true;
            this.txbHoursThisWeek.Size = new System.Drawing.Size(150, 23);
            this.txbHoursThisWeek.TabIndex = 19;
            // 
            // lblHoursTotal
            // 
            this.lblHoursTotal.AutoSize = true;
            this.lblHoursTotal.Location = new System.Drawing.Point(230, 223);
            this.lblHoursTotal.Name = "lblHoursTotal";
            this.lblHoursTotal.Size = new System.Drawing.Size(69, 15);
            this.lblHoursTotal.TabIndex = 18;
            this.lblHoursTotal.Text = "Hours total:";
            // 
            // lblHoursThisWeek
            // 
            this.lblHoursThisWeek.AutoSize = true;
            this.lblHoursThisWeek.Location = new System.Drawing.Point(230, 180);
            this.lblHoursThisWeek.Name = "lblHoursThisWeek";
            this.lblHoursThisWeek.Size = new System.Drawing.Size(94, 15);
            this.lblHoursThisWeek.TabIndex = 17;
            this.lblHoursThisWeek.Text = "Hours this week:";
            // 
            // btnViewEmployeeSale
            // 
            this.btnViewEmployeeSale.Location = new System.Drawing.Point(394, 327);
            this.btnViewEmployeeSale.Name = "btnViewEmployeeSale";
            this.btnViewEmployeeSale.Size = new System.Drawing.Size(186, 23);
            this.btnViewEmployeeSale.TabIndex = 16;
            this.btnViewEmployeeSale.Text = "View";
            this.btnViewEmployeeSale.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeSales
            // 
            this.lblEmployeeSales.AutoSize = true;
            this.lblEmployeeSales.Location = new System.Drawing.Point(394, 180);
            this.lblEmployeeSales.Name = "lblEmployeeSales";
            this.lblEmployeeSales.Size = new System.Drawing.Size(36, 15);
            this.lblEmployeeSales.TabIndex = 15;
            this.lblEmployeeSales.Text = "Sales:";
            // 
            // lsbEmployeeSales
            // 
            this.lsbEmployeeSales.FormattingEnabled = true;
            this.lsbEmployeeSales.ItemHeight = 15;
            this.lsbEmployeeSales.Location = new System.Drawing.Point(394, 197);
            this.lsbEmployeeSales.Name = "lsbEmployeeSales";
            this.lsbEmployeeSales.Size = new System.Drawing.Size(186, 124);
            this.lsbEmployeeSales.TabIndex = 14;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(394, 154);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.ReadOnly = true;
            this.txbLastName.Size = new System.Drawing.Size(186, 23);
            this.txbLastName.TabIndex = 13;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(394, 136);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 15);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last name:";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(230, 154);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.ReadOnly = true;
            this.txbFirstName.Size = new System.Drawing.Size(150, 23);
            this.txbFirstName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(230, 136);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 15);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First name:";
            // 
            // txbStaffID
            // 
            this.txbStaffID.Location = new System.Drawing.Point(230, 110);
            this.txbStaffID.Name = "txbStaffID";
            this.txbStaffID.ReadOnly = true;
            this.txbStaffID.Size = new System.Drawing.Size(100, 23);
            this.txbStaffID.TabIndex = 9;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(230, 92);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(48, 15);
            this.lblStaffID.TabIndex = 8;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(12, 11);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(88, 15);
            this.lblBusinessName.TabIndex = 7;
            this.lblBusinessName.Text = "Business name:";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(12, 327);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveEmployee.TabIndex = 6;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(76, 327);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(107, 23);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add New";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(12, 74);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(67, 15);
            this.lblEmployees.TabIndex = 4;
            this.lblEmployees.Text = "Employees:";
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.FormattingEnabled = true;
            this.lsbEmployees.ItemHeight = 15;
            this.lsbEmployees.Location = new System.Drawing.Point(12, 92);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.Size = new System.Drawing.Size(171, 229);
            this.lsbEmployees.TabIndex = 3;
            this.lsbEmployees.SelectedIndexChanged += new System.EventHandler(this.lsbEmployees_SelectedIndexChanged);
            // 
            // btnBusinessNameEdit
            // 
            this.btnBusinessNameEdit.Location = new System.Drawing.Point(271, 29);
            this.btnBusinessNameEdit.Name = "btnBusinessNameEdit";
            this.btnBusinessNameEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBusinessNameEdit.TabIndex = 2;
            this.btnBusinessNameEdit.Text = "Edit";
            this.btnBusinessNameEdit.UseVisualStyleBackColor = true;
            this.btnBusinessNameEdit.Click += new System.EventHandler(this.btnBusinessNameEdit_Click);
            // 
            // txbBusinessName
            // 
            this.txbBusinessName.Location = new System.Drawing.Point(12, 29);
            this.txbBusinessName.Name = "txbBusinessName";
            this.txbBusinessName.ReadOnly = true;
            this.txbBusinessName.Size = new System.Drawing.Size(253, 23);
            this.txbBusinessName.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "SRaPS V_1.0.1 (Startup)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ListBox lsbEmployees;
        private System.Windows.Forms.Button btnBusinessNameEdit;
        private System.Windows.Forms.TextBox txbBusinessName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox txbHoursTotal;
        private System.Windows.Forms.TextBox txbHoursThisWeek;
        private System.Windows.Forms.Label lblHoursTotal;
        private System.Windows.Forms.Label lblHoursThisWeek;
        private System.Windows.Forms.Button btnViewEmployeeSale;
        private System.Windows.Forms.Label lblEmployeeSales;
        private System.Windows.Forms.ListBox lsbEmployeeSales;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txbStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblBusinessPassword;
        private System.Windows.Forms.Button btnBusinessPasswordEdit;
        private System.Windows.Forms.TextBox txbBusinessPassword;
        private System.Windows.Forms.Button btnEmployeeEdit;
        private System.Windows.Forms.Button btnClock;
    }
}

