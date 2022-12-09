namespace EMS_RS
{
    partial class Form1
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
            this._cmbDoctors = new System.Windows.Forms.ComboBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _cmbDoctors
            // 
            this._cmbDoctors.FormattingEnabled = true;
            this._cmbDoctors.Location = new System.Drawing.Point(262, 65);
            this._cmbDoctors.Name = "_cmbDoctors";
            this._cmbDoctors.Size = new System.Drawing.Size(121, 23);
            this._cmbDoctors.TabIndex = 0;
            // 
            // _txtPassword
            // 
            this._txtPassword.Location = new System.Drawing.Point(272, 112);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '●';
            this._txtPassword.Size = new System.Drawing.Size(100, 23);
            this._txtPassword.TabIndex = 1;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(283, 162);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(75, 23);
            this._btnLogin.TabIndex = 2;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._cmbDoctors);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox _cmbDoctors;
        private TextBox _txtPassword;
        private Button _btnLogin;
    }
}