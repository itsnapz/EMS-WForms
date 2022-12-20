namespace EMS_RS.Forms
{
    partial class RespondItemAddForm
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
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._cmbPatients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cmbCars = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(318, 182);
            this._btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(82, 22);
            this._btnSave.TabIndex = 0;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(425, 182);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(82, 22);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _cmbPatients
            // 
            this._cmbPatients.FormattingEnabled = true;
            this._cmbPatients.Location = new System.Drawing.Point(12, 29);
            this._cmbPatients.Name = "_cmbPatients";
            this._cmbPatients.Size = new System.Drawing.Size(119, 23);
            this._cmbPatients.TabIndex = 2;
            this._cmbPatients.SelectionChangeCommitted += new System.EventHandler(this._cmbPatients_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(170, 29);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(100, 23);
            this._txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // _cmbCars
            // 
            this._cmbCars.FormattingEnabled = true;
            this._cmbCars.Location = new System.Drawing.Point(318, 29);
            this._cmbCars.Name = "_cmbCars";
            this._cmbCars.Size = new System.Drawing.Size(121, 23);
            this._cmbCars.TabIndex = 6;
            this._cmbCars.SelectionChangeCommitted += new System.EventHandler(this._cmbCars_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Car";
            // 
            // RespondItemAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cmbCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbPatients);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RespondItemAddForm";
            this.Text = "RespondItemAddForm";
            this.Load += new System.EventHandler(this.RespondItemAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _btnSave;
        private Button _btnCancel;
        private ComboBox _cmbPatients;
        private Label label1;
        private TextBox _txtPrice;
        private Label label2;
        private ComboBox _cmbCars;
        private Label label3;
    }
}