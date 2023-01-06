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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtOldPassword
            // 
            this._txtOldPassword.Location = new System.Drawing.Point(190, 63);
            this._txtOldPassword.Name = "_txtOldPassword";
            this._txtOldPassword.PlaceholderText = "Old password";
            this._txtOldPassword.Size = new System.Drawing.Size(100, 23);
            this._txtOldPassword.TabIndex = 0;
            // 
            // _txtNewPassword
            // 
            this._txtNewPassword.Location = new System.Drawing.Point(190, 110);
            this._txtNewPassword.Name = "_txtNewPassword";
            this._txtNewPassword.PlaceholderText = "New password";
            this._txtNewPassword.Size = new System.Drawing.Size(100, 23);
            this._txtNewPassword.TabIndex = 1;
            // 
            // _txtNewPasswordConfirm
            // 
            this._txtNewPasswordConfirm.Location = new System.Drawing.Point(190, 159);
            this._txtNewPasswordConfirm.Name = "_txtNewPasswordConfirm";
            this._txtNewPasswordConfirm.PlaceholderText = "Re-enter new";
            this._txtNewPasswordConfirm.Size = new System.Drawing.Size(100, 23);
            this._txtNewPasswordConfirm.TabIndex = 2;
            // 
            // _btnSave
            // 
            this._btnSave.BackColor = System.Drawing.Color.White;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Location = new System.Drawing.Point(201, 203);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 3;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password change";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(491, 244);
            this.Controls.Add(this.label1);
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
        private Label label1;
    }
}