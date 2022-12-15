namespace EMS_RS.Controls
{
    partial class RespondItemControl
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
            this._lblRespondId = new System.Windows.Forms.Label();
            this._lblNameSurname = new System.Windows.Forms.Label();
            this._lblDate = new System.Windows.Forms.Label();
            this._lblPrice = new System.Windows.Forms.Label();
            this._lblCarName = new System.Windows.Forms.Label();
            this._lblPatientBirth = new System.Windows.Forms.Label();
            this._lblPatientPhoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblRespondId
            // 
            this._lblRespondId.AutoSize = true;
            this._lblRespondId.Location = new System.Drawing.Point(28, 22);
            this._lblRespondId.Name = "_lblRespondId";
            this._lblRespondId.Size = new System.Drawing.Size(22, 20);
            this._lblRespondId.TabIndex = 0;
            this._lblRespondId.Text = "Id";
            // 
            // _lblNameSurname
            // 
            this._lblNameSurname.AutoSize = true;
            this._lblNameSurname.Location = new System.Drawing.Point(92, 22);
            this._lblNameSurname.Name = "_lblNameSurname";
            this._lblNameSurname.Size = new System.Drawing.Size(111, 20);
            this._lblNameSurname.TabIndex = 1;
            this._lblNameSurname.Text = "Name Surname";
            // 
            // _lblDate
            // 
            this._lblDate.AutoSize = true;
            this._lblDate.Location = new System.Drawing.Point(527, 22);
            this._lblDate.Name = "_lblDate";
            this._lblDate.Size = new System.Drawing.Size(93, 20);
            this._lblDate.TabIndex = 2;
            this._lblDate.Text = "XX-XX-XXXX";
            // 
            // _lblPrice
            // 
            this._lblPrice.AutoSize = true;
            this._lblPrice.Location = new System.Drawing.Point(673, 22);
            this._lblPrice.Name = "_lblPrice";
            this._lblPrice.Size = new System.Drawing.Size(53, 20);
            this._lblPrice.TabIndex = 3;
            this._lblPrice.Text = "8000 $";
            // 
            // _lblCarName
            // 
            this._lblCarName.AutoSize = true;
            this._lblCarName.Location = new System.Drawing.Point(767, 22);
            this._lblCarName.Name = "_lblCarName";
            this._lblCarName.Size = new System.Drawing.Size(77, 20);
            this._lblCarName.TabIndex = 4;
            this._lblCarName.Text = "Trackhawk";
            // 
            // _lblPatientBirth
            // 
            this._lblPatientBirth.AutoSize = true;
            this._lblPatientBirth.Location = new System.Drawing.Point(243, 22);
            this._lblPatientBirth.Name = "_lblPatientBirth";
            this._lblPatientBirth.Size = new System.Drawing.Size(93, 20);
            this._lblPatientBirth.TabIndex = 5;
            this._lblPatientBirth.Text = "XX-XX-XXXX";
            // 
            // _lblPatientPhoneNumber
            // 
            this._lblPatientPhoneNumber.AutoSize = true;
            this._lblPatientPhoneNumber.Location = new System.Drawing.Point(385, 22);
            this._lblPatientPhoneNumber.Name = "_lblPatientPhoneNumber";
            this._lblPatientPhoneNumber.Size = new System.Drawing.Size(81, 20);
            this._lblPatientPhoneNumber.TabIndex = 6;
            this._lblPatientPhoneNumber.Text = "123456789";
            // 
            // RespondItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblPatientPhoneNumber);
            this.Controls.Add(this._lblPatientBirth);
            this.Controls.Add(this._lblCarName);
            this.Controls.Add(this._lblPrice);
            this.Controls.Add(this._lblDate);
            this.Controls.Add(this._lblNameSurname);
            this.Controls.Add(this._lblRespondId);
            this.Name = "RespondItemControl";
            this.Size = new System.Drawing.Size(882, 64);
            this.Load += new System.EventHandler(this.RespondItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblRespondId;
        private Label _lblNameSurname;
        private Label _lblDate;
        private Label _lblPrice;
        private Label _lblCarName;
        private Label _lblPatientBirth;
        private Label _lblPatientPhoneNumber;
    }
}
