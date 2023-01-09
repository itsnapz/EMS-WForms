namespace EMS_RS.Forms
{
    partial class DoctorItemAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtSurname = new System.Windows.Forms.TextBox();
            this._cmbSex = new System.Windows.Forms.ComboBox();
            this._cmbRank = new System.Windows.Forms.ComboBox();
            this._txtPhoneNumber = new System.Windows.Forms.TextBox();
            this._cmbHospital = new System.Windows.Forms.ComboBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._txtCallSign = new System.Windows.Forms.TextBox();
            this._pckDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(332, 36);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 23);
            this._txtName.TabIndex = 0;
            // 
            // _txtSurname
            // 
            this._txtSurname.Location = new System.Drawing.Point(332, 86);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(100, 23);
            this._txtSurname.TabIndex = 1;
            // 
            // _cmbSex
            // 
            this._cmbSex.FormattingEnabled = true;
            this._cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._cmbSex.Location = new System.Drawing.Point(332, 143);
            this._cmbSex.Name = "_cmbSex";
            this._cmbSex.Size = new System.Drawing.Size(100, 23);
            this._cmbSex.TabIndex = 2;
            // 
            // _cmbRank
            // 
            this._cmbRank.FormattingEnabled = true;
            this._cmbRank.Items.AddRange(new object[] {
            "Train",
            "Doctor",
            "AC",
            "Prof",
            "Prim",
            "Head",
            "Dean"});
            this._cmbRank.Location = new System.Drawing.Point(332, 196);
            this._cmbRank.Name = "_cmbRank";
            this._cmbRank.Size = new System.Drawing.Size(100, 23);
            this._cmbRank.TabIndex = 3;
            // 
            // _txtPhoneNumber
            // 
            this._txtPhoneNumber.Location = new System.Drawing.Point(332, 248);
            this._txtPhoneNumber.Name = "_txtPhoneNumber";
            this._txtPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this._txtPhoneNumber.TabIndex = 4;
            // 
            // _cmbHospital
            // 
            this._cmbHospital.FormattingEnabled = true;
            this._cmbHospital.Location = new System.Drawing.Point(332, 303);
            this._cmbHospital.Name = "_cmbHospital";
            this._cmbHospital.Size = new System.Drawing.Size(100, 23);
            this._cmbHospital.TabIndex = 5;
            this._cmbHospital.SelectionChangeCommitted += new System.EventHandler(this._cmbHospital_SelectionChangeCommitted);
            // 
            // _txtPassword
            // 
            this._txtPassword.Location = new System.Drawing.Point(332, 356);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '●';
            this._txtPassword.Size = new System.Drawing.Size(100, 23);
            this._txtPassword.TabIndex = 6;
            // 
            // _txtCallSign
            // 
            this._txtCallSign.Location = new System.Drawing.Point(332, 410);
            this._txtCallSign.Name = "_txtCallSign";
            this._txtCallSign.Size = new System.Drawing.Size(100, 23);
            this._txtCallSign.TabIndex = 7;
            // 
            // _pckDate
            // 
            this._pckDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._pckDate.Location = new System.Drawing.Point(332, 466);
            this._pckDate.Name = "_pckDate";
            this._pckDate.Size = new System.Drawing.Size(100, 23);
            this._pckDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(276, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(258, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hospital";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(252, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(257, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Call sign";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(258, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Birthday";
            // 
            // _btnSave
            // 
            this._btnSave.BackColor = System.Drawing.Color.White;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Location = new System.Drawing.Point(558, 522);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 18;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.Color.White;
            this._btnCancel.FlatAppearance.BorderSize = 0;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Location = new System.Drawing.Point(675, 522);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 19;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // DoctorItemAddForm
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(772, 557);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pckDate);
            this.Controls.Add(this._txtCallSign);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._cmbHospital);
            this.Controls.Add(this._txtPhoneNumber);
            this.Controls.Add(this._cmbRank);
            this.Controls.Add(this._cmbSex);
            this.Controls.Add(this._txtSurname);
            this.Controls.Add(this._txtName);
            this.Name = "DoctorItemAddForm";
            this.Text = "DoctorItemAddForm";
            this.Load += new System.EventHandler(this.DoctorItemAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txtName;
        private TextBox _txtSurname;
        private ComboBox _cmbSex;
        private ComboBox _cmbRank;
        private TextBox _txtPhoneNumber;
        private ComboBox _cmbHospital;
        private TextBox _txtPassword;
        private TextBox _txtCallSign;
        private DateTimePicker _pckDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button _btnSave;
        private Button _btnCancel;
    }
}