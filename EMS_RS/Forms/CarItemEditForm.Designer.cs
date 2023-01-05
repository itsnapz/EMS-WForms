namespace EMS_RS.Forms
{
    partial class CarItemEditForm
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
            this._txtCarName = new System.Windows.Forms.TextBox();
            this._txtCarPlate = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtCarName
            // 
            this._txtCarName.Location = new System.Drawing.Point(47, 67);
            this._txtCarName.Name = "_txtCarName";
            this._txtCarName.Size = new System.Drawing.Size(100, 23);
            this._txtCarName.TabIndex = 0;
            // 
            // _txtCarPlate
            // 
            this._txtCarPlate.Location = new System.Drawing.Point(179, 67);
            this._txtCarPlate.Name = "_txtCarPlate";
            this._txtCarPlate.Size = new System.Drawing.Size(100, 23);
            this._txtCarPlate.TabIndex = 1;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(158, 156);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(244, 156);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // CarItemEditForm
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(331, 191);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtCarPlate);
            this.Controls.Add(this._txtCarName);
            this.Name = "CarItemEditForm";
            this.Text = "CarItemEditForm";
            this.Load += new System.EventHandler(this.CarItemEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txtCarName;
        private TextBox _txtCarPlate;
        private Button _btnSave;
        private Button _btnCancel;
    }
}