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
            this._lblPatientId.Location = new System.Drawing.Point(22, 20);
            this._lblPatientId.Name = "_lblPatientId";
            this._lblPatientId.Size = new System.Drawing.Size(22, 20);
            this._lblPatientId.TabIndex = 0;
            this._lblPatientId.Text = "Id";
            // 
            // _lblPatientNameSurname
            // 
            this._lblPatientNameSurname.AutoSize = true;
            this._lblPatientNameSurname.Location = new System.Drawing.Point(73, 20);
            this._lblPatientNameSurname.Name = "_lblPatientNameSurname";
            this._lblPatientNameSurname.Size = new System.Drawing.Size(111, 20);
            this._lblPatientNameSurname.TabIndex = 1;
            this._lblPatientNameSurname.Text = "Name Surname";
            // 
            // _lblPatientBirthday
            // 
            this._lblPatientBirthday.AutoSize = true;
            this._lblPatientBirthday.Location = new System.Drawing.Point(222, 20);
            this._lblPatientBirthday.Name = "_lblPatientBirthday";
            this._lblPatientBirthday.Size = new System.Drawing.Size(93, 20);
            this._lblPatientBirthday.TabIndex = 2;
            this._lblPatientBirthday.Text = "XX-XX-XXXX";
            // 
            // _lblPatientStreet
            // 
            this._lblPatientStreet.AutoSize = true;
            this._lblPatientStreet.Location = new System.Drawing.Point(356, 20);
            this._lblPatientStreet.Name = "_lblPatientStreet";
            this._lblPatientStreet.Size = new System.Drawing.Size(104, 20);
            this._lblPatientStreet.TabIndex = 3;
            this._lblPatientStreet.Text = "StreetName54";
            // 
            // _lblPatientCity
            // 
            this._lblPatientCity.AutoSize = true;
            this._lblPatientCity.Location = new System.Drawing.Point(512, 20);
            this._lblPatientCity.Name = "_lblPatientCity";
            this._lblPatientCity.Size = new System.Drawing.Size(74, 20);
            this._lblPatientCity.TabIndex = 4;
            this._lblPatientCity.Text = "CityName";
            // 
            // _lblPatientPhoneNumber
            // 
            this._lblPatientPhoneNumber.AutoSize = true;
            this._lblPatientPhoneNumber.Location = new System.Drawing.Point(728, 20);
            this._lblPatientPhoneNumber.Name = "_lblPatientPhoneNumber";
            this._lblPatientPhoneNumber.Size = new System.Drawing.Size(81, 20);
            this._lblPatientPhoneNumber.TabIndex = 5;
            this._lblPatientPhoneNumber.Text = "123456789";
            // 
            // _lblPatientZIP
            // 
            this._lblPatientZIP.AutoSize = true;
            this._lblPatientZIP.Location = new System.Drawing.Point(642, 20);
            this._lblPatientZIP.Name = "_lblPatientZIP";
            this._lblPatientZIP.Size = new System.Drawing.Size(30, 20);
            this._lblPatientZIP.TabIndex = 6;
            this._lblPatientZIP.Text = "ZIP";
            // 
            // PatientItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblPatientZIP);
            this.Controls.Add(this._lblPatientPhoneNumber);
            this.Controls.Add(this._lblPatientCity);
            this.Controls.Add(this._lblPatientStreet);
            this.Controls.Add(this._lblPatientBirthday);
            this.Controls.Add(this._lblPatientNameSurname);
            this.Controls.Add(this._lblPatientId);
            this.Name = "PatientItemControl";
            this.Size = new System.Drawing.Size(882, 64);
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
