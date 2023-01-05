namespace EMS_RS.Forms
{
    partial class SettingsForm
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
            this._txtOldPassword = new System.Windows.Forms.TextBox();
            this._txtNewPassword = new System.Windows.Forms.TextBox();
            this._txtNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtOldPassword
            // 
            this._txtOldPassword.Location = new System.Drawing.Point(190, 34);
            this._txtOldPassword.Name = "_txtOldPassword";
            this._txtOldPassword.PlaceholderText = "Old password";
            this._txtOldPassword.Size = new System.Drawing.Size(100, 23);
            this._txtOldPassword.TabIndex = 0;
            // 
            // _txtNewPassword
            // 
            this._txtNewPassword.Location = new System.Drawing.Point(190, 81);
            this._txtNewPassword.Name = "_txtNewPassword";
            this._txtNewPassword.PlaceholderText = "New password";
            this._txtNewPassword.Size = new System.Drawing.Size(100, 23);
            this._txtNewPassword.TabIndex = 1;
            // 
            // _txtNewPasswordConfirm
            // 
            this._txtNewPasswordConfirm.Location = new System.Drawing.Point(190, 130);
            this._txtNewPasswordConfirm.Name = "_txtNewPasswordConfirm";
            this._txtNewPasswordConfirm.PlaceholderText = "Re-enter new";
            this._txtNewPasswordConfirm.Size = new System.Drawing.Size(100, 23);
            this._txtNewPasswordConfirm.TabIndex = 2;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(201, 174);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 244);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtNewPasswordConfirm);
            this.Controls.Add(this._txtNewPassword);
            this.Controls.Add(this._txtOldPassword);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txtOldPassword;
        private TextBox _txtNewPassword;
        private TextBox _txtNewPasswordConfirm;
        private Button _btnSave;
    }
}