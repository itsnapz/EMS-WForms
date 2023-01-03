namespace EMS_RS.Forms
{
    partial class RespondItemEditForm
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
            this._cmbPatients = new System.Windows.Forms.ComboBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._cmbCars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmbPatients
            // 
            this._cmbPatients.FormattingEnabled = true;
            this._cmbPatients.Location = new System.Drawing.Point(29, 29);
            this._cmbPatients.Name = "_cmbPatients";
            this._cmbPatients.Size = new System.Drawing.Size(121, 23);
            this._cmbPatients.TabIndex = 0;
            this._cmbPatients.SelectionChangeCommitted += new System.EventHandler(this._cmbPatients_SelectionChangeCommitted);
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(199, 29);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(100, 23);
            this._txtPrice.TabIndex = 1;
            // 
            // _cmbCars
            // 
            this._cmbCars.FormattingEnabled = true;
            this._cmbCars.Location = new System.Drawing.Point(358, 29);
            this._cmbCars.Name = "_cmbCars";
            this._cmbCars.Size = new System.Drawing.Size(121, 23);
            this._cmbCars.TabIndex = 2;
            this._cmbCars.SelectionChangeCommitted += new System.EventHandler(this._cmbCars_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Car";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(346, 131);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 6;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(444, 131);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 7;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // RespondItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 166);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbCars);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._cmbPatients);
            this.Name = "RespondItemEditForm";
            this.Text = "RespondItemEditForm";
            this.Load += new System.EventHandler(this.RespondItemEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox _cmbPatients;
        private TextBox _txtPrice;
        private ComboBox _cmbCars;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button _btnSave;
        private Button _btnCancel;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}