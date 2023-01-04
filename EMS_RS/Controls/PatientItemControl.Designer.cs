namespace EMS_RS.Controls
{
    partial class PatientItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblPatientId = new System.Windows.Forms.Label();
            this._lblPatientNameSurname = new System.Windows.Forms.Label();
            this._lblPatientBirthday = new System.Windows.Forms.Label();
            this._lblPatientStreet = new System.Windows.Forms.Label();
            this._lblPatientCity = new System.Windows.Forms.Label();
            this._lblPatientPhoneNumber = new System.Windows.Forms.Label();
            this._lblPatientZIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblPatientId
            // 
            this._lblPatientId.AutoSize = true;
            this._lblPatientId.Location = new System.Drawing.Point(24, 15);
            this._lblPatientId.Name = "_lblPatientId";
            this._lblPatientId.Size = new System.Drawing.Size(17, 15);
            this._lblPatientId.TabIndex = 0;
            this._lblPatientId.Text = "Id";
            // 
            // _lblPatientNameSurname
            // 
            this._lblPatientNameSurname.AutoSize = true;
            this._lblPatientNameSurname.Location = new System.Drawing.Point(80, 16);
            this._lblPatientNameSurname.Name = "_lblPatientNameSurname";
            this._lblPatientNameSurname.Size = new System.Drawing.Size(89, 15);
            this._lblPatientNameSurname.TabIndex = 1;
            this._lblPatientNameSurname.Text = "Name Surname";
            // 
            // _lblPatientBirthday
            // 
            this._lblPatientBirthday.AutoSize = true;
            this._lblPatientBirthday.Location = new System.Drawing.Point(213, 16);
            this._lblPatientBirthday.Name = "_lblPatientBirthday";
            this._lblPatientBirthday.Size = new System.Drawing.Size(65, 15);
            this._lblPatientBirthday.TabIndex = 2;
            this._lblPatientBirthday.Text = "xx-xx-xxxx";
            // 
            // _lblPatientStreet
            // 
            this._lblPatientStreet.AutoSize = true;
            this._lblPatientStreet.Location = new System.Drawing.Point(320, 16);
            this._lblPatientStreet.Name = "_lblPatientStreet";
            this._lblPatientStreet.Size = new System.Drawing.Size(81, 15);
            this._lblPatientStreet.TabIndex = 3;
            this._lblPatientStreet.Text = "StreetName54";
            // 
            // _lblPatientCity
            // 
            this._lblPatientCity.AutoSize = true;
            this._lblPatientCity.Location = new System.Drawing.Point(461, 16);
            this._lblPatientCity.Name = "_lblPatientCity";
            this._lblPatientCity.Size = new System.Drawing.Size(60, 15);
            this._lblPatientCity.TabIndex = 4;
            this._lblPatientCity.Text = "CityName";
            // 
            // _lblPatientPhoneNumber
            // 
            this._lblPatientPhoneNumber.AutoSize = true;
            this._lblPatientPhoneNumber.Location = new System.Drawing.Point(671, 16);
            this._lblPatientPhoneNumber.Name = "_lblPatientPhoneNumber";
            this._lblPatientPhoneNumber.Size = new System.Drawing.Size(61, 15);
            this._lblPatientPhoneNumber.TabIndex = 5;
            this._lblPatientPhoneNumber.Text = "123456789";
            // 
            // _lblPatientZIP
            // 
            this._lblPatientZIP.AutoSize = true;
            this._lblPatientZIP.Location = new System.Drawing.Point(589, 16);
            this._lblPatientZIP.Name = "_lblPatientZIP";
            this._lblPatientZIP.Size = new System.Drawing.Size(24, 15);
            this._lblPatientZIP.TabIndex = 6;
            this._lblPatientZIP.Text = "ZIP";
            // 
            // PatientItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblPatientZIP);
            this.Controls.Add(this._lblPatientPhoneNumber);
            this.Controls.Add(this._lblPatientCity);
            this.Controls.Add(this._lblPatientStreet);
            this.Controls.Add(this._lblPatientBirthday);
            this.Controls.Add(this._lblPatientNameSurname);
            this.Controls.Add(this._lblPatientId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientItemControl";
            this.Size = new System.Drawing.Size(772, 48);
            this.Load += new System.EventHandler(this.PatientItemControl_Load);
            this.Click += new System.EventHandler(this.PatientItemControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblPatientId;
        private Label _lblPatientNameSurname;
        private Label _lblPatientBirthday;
        private Label _lblPatientStreet;
        private Label _lblPatientCity;
        private Label _lblPatientPhoneNumber;
        private Label _lblPatientZIP;
    }
}
