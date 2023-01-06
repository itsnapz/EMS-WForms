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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this._btnSave.BackColor = System.Drawing.Color.White;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Location = new System.Drawing.Point(158, 156);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.Color.White;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Location = new System.Drawing.Point(244, 156);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plate";
            // 
            // CarItemEditForm
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(331, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label label2;
    }
}