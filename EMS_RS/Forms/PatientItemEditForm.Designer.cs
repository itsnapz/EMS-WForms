namespace EMS_RS.Forms
{
    partial class PatientItemEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._pckDate = new System.Windows.Forms.DateTimePicker();
            this._cmbSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtZip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(12, 29);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(146, 23);
            this._txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // _txtSurname
            // 
            this._txtSurname.Location = new System.Drawing.Point(183, 29);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(146, 23);
            this._txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // _pckDate
            // 
            this._pckDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._pckDate.Location = new System.Drawing.Point(373, 29);
            this._pckDate.Name = "_pckDate";
            this._pckDate.Size = new System.Drawing.Size(101, 23);
            this._pckDate.TabIndex = 4;
            // 
            // _cmbSex
            // 
            this._cmbSex.FormattingEnabled = true;
            this._cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._cmbSex.Location = new System.Drawing.Point(12, 86);
            this._cmbSex.Name = "_cmbSex";
            this._cmbSex.Size = new System.Drawing.Size(83, 23);
            this._cmbSex.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sex";
            // 
            // _txtStreet
            // 
            this._txtStreet.Location = new System.Drawing.Point(139, 86);
            this._txtStreet.Name = "_txtStreet";
            this._txtStreet.Size = new System.Drawing.Size(128, 23);
            this._txtStreet.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Street";
            // 
            // _txtCity
            // 
            this._txtCity.Location = new System.Drawing.Point(318, 86);
            this._txtCity.Name = "_txtCity";
            this._txtCity.Size = new System.Drawing.Size(100, 23);
            this._txtCity.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "City";
            // 
            // _txtCountry
            // 
            this._txtCountry.Location = new System.Drawing.Point(12, 145);
            this._txtCountry.Name = "_txtCountry";
            this._txtCountry.Size = new System.Drawing.Size(100, 23);
            this._txtCountry.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Country";
            // 
            // _txtZip
            // 
            this._txtZip.Location = new System.Drawing.Point(183, 145);
            this._txtZip.Name = "_txtZip";
            this._txtZip.Size = new System.Drawing.Size(100, 23);
            this._txtZip.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "ZIP";
            // 
            // _txtPhoneNumber
            // 
            this._txtPhoneNumber.Location = new System.Drawing.Point(329, 145);
            this._txtPhoneNumber.Name = "_txtPhoneNumber";
            this._txtPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this._txtPhoneNumber.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Phone";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(329, 198);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 33;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(427, 198);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 34;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // PatientItemEditForm
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(514, 233);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._txtPhoneNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtZip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cmbSex);
            this.Controls.Add(this._pckDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtName);
            this.Name = "PatientItemEditForm";
            this.Text = "PatientItemEditForm";
            this.Load += new System.EventHandler(this.PatientItemEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txtName;
        private Label label1;
        private TextBox _txtSurname;
        private Label label2;
        private DateTimePicker _pckDate;
        private ComboBox _cmbSex;
        private Label label3;
        private TextBox _txtStreet;
        private Label label4;
        private TextBox _txtCity;
        private Label label5;
        private TextBox _txtCountry;
        private Label label6;
        private TextBox _txtZip;
        private Label label7;
        private TextBox _txtPhoneNumber;
        private Label label8;
        private Button _btnSave;
        private Button _btnCancel;
    }
}