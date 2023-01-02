namespace EMS_RS.Controls
{
    partial class DoctorItemControl
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
            this._lblDoctorId = new System.Windows.Forms.Label();
            this._lblDoctorBirthday = new System.Windows.Forms.Label();
            this._lblDoctorRank = new System.Windows.Forms.Label();
            this._lblDoctorCallSign = new System.Windows.Forms.Label();
            this._lblDoctorPhoneNumber = new System.Windows.Forms.Label();
            this._lblDoctorReputation = new System.Windows.Forms.Label();
            this._lblDoctorNameSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblDoctorId
            // 
            this._lblDoctorId.AutoSize = true;
            this._lblDoctorId.Location = new System.Drawing.Point(24, 16);
            this._lblDoctorId.Name = "_lblDoctorId";
            this._lblDoctorId.Size = new System.Drawing.Size(17, 15);
            this._lblDoctorId.TabIndex = 0;
            this._lblDoctorId.Text = "Id";
            // 
            // _lblDoctorBirthday
            // 
            this._lblDoctorBirthday.AutoSize = true;
            this._lblDoctorBirthday.Location = new System.Drawing.Point(213, 16);
            this._lblDoctorBirthday.Name = "_lblDoctorBirthday";
            this._lblDoctorBirthday.Size = new System.Drawing.Size(65, 15);
            this._lblDoctorBirthday.TabIndex = 2;
            this._lblDoctorBirthday.Text = "xx-xx-xxxx";
            // 
            // _lblDoctorRank
            // 
            this._lblDoctorRank.AutoSize = true;
            this._lblDoctorRank.Location = new System.Drawing.Point(337, 16);
            this._lblDoctorRank.Name = "_lblDoctorRank";
            this._lblDoctorRank.Size = new System.Drawing.Size(30, 15);
            this._lblDoctorRank.TabIndex = 3;
            this._lblDoctorRank.Text = "rank";
            // 
            // _lblDoctorCallSign
            // 
            this._lblDoctorCallSign.AutoSize = true;
            this._lblDoctorCallSign.Location = new System.Drawing.Point(440, 16);
            this._lblDoctorCallSign.Name = "_lblDoctorCallSign";
            this._lblDoctorCallSign.Size = new System.Drawing.Size(52, 15);
            this._lblDoctorCallSign.TabIndex = 4;
            this._lblDoctorCallSign.Text = "Call sign";
            // 
            // _lblDoctorPhoneNumber
            // 
            this._lblDoctorPhoneNumber.AutoSize = true;
            this._lblDoctorPhoneNumber.Location = new System.Drawing.Point(560, 16);
            this._lblDoctorPhoneNumber.Name = "_lblDoctorPhoneNumber";
            this._lblDoctorPhoneNumber.Size = new System.Drawing.Size(61, 15);
            this._lblDoctorPhoneNumber.TabIndex = 5;
            this._lblDoctorPhoneNumber.Text = "123456789";
            // 
            // _lblDoctorReputation
            // 
            this._lblDoctorReputation.AutoSize = true;
            this._lblDoctorReputation.Location = new System.Drawing.Point(685, 16);
            this._lblDoctorReputation.Name = "_lblDoctorReputation";
            this._lblDoctorReputation.Size = new System.Drawing.Size(25, 15);
            this._lblDoctorReputation.TabIndex = 6;
            this._lblDoctorReputation.Text = "120";
            // 
            // _lblDoctorNameSurname
            // 
            this._lblDoctorNameSurname.AutoSize = true;
            this._lblDoctorNameSurname.Location = new System.Drawing.Point(80, 16);
            this._lblDoctorNameSurname.Name = "_lblDoctorNameSurname";
            this._lblDoctorNameSurname.Size = new System.Drawing.Size(89, 15);
            this._lblDoctorNameSurname.TabIndex = 7;
            this._lblDoctorNameSurname.Text = "Name Surname";
            // 
            // DoctorItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblDoctorNameSurname);
            this.Controls.Add(this._lblDoctorReputation);
            this.Controls.Add(this._lblDoctorPhoneNumber);
            this.Controls.Add(this._lblDoctorCallSign);
            this.Controls.Add(this._lblDoctorRank);
            this.Controls.Add(this._lblDoctorBirthday);
            this.Controls.Add(this._lblDoctorId);
            this.Name = "DoctorItemControl";
            this.Size = new System.Drawing.Size(772, 48);
            this.Load += new System.EventHandler(this.DoctorItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblDoctorId;
        private Label _lblDoctorBirthday;
        private Label _lblDoctorRank;
        private Label _lblDoctorCallSign;
        private Label _lblDoctorPhoneNumber;
        private Label _lblDoctorReputation;
        private Label _lblDoctorNameSurname;
    }
}
