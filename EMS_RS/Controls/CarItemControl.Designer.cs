namespace EMS_RS.Controls
{
    partial class CarItemControl
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
            this._lblCarId = new System.Windows.Forms.Label();
            this._lblCarName = new System.Windows.Forms.Label();
            this._lblCarPlate = new System.Windows.Forms.Label();
            this._btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblCarId
            // 
            this._lblCarId.AutoSize = true;
            this._lblCarId.Location = new System.Drawing.Point(24, 16);
            this._lblCarId.Name = "_lblCarId";
            this._lblCarId.Size = new System.Drawing.Size(17, 15);
            this._lblCarId.TabIndex = 0;
            this._lblCarId.Text = "Id";
            // 
            // _lblCarName
            // 
            this._lblCarName.AutoSize = true;
            this._lblCarName.Location = new System.Drawing.Point(80, 16);
            this._lblCarName.Name = "_lblCarName";
            this._lblCarName.Size = new System.Drawing.Size(39, 15);
            this._lblCarName.TabIndex = 1;
            this._lblCarName.Text = "Name";
            // 
            // _lblCarPlate
            // 
            this._lblCarPlate.AutoSize = true;
            this._lblCarPlate.Location = new System.Drawing.Point(178, 16);
            this._lblCarPlate.Name = "_lblCarPlate";
            this._lblCarPlate.Size = new System.Drawing.Size(33, 15);
            this._lblCarPlate.TabIndex = 2;
            this._lblCarPlate.Text = "Plate";
            // 
            // _btnDelete
            // 
            this._btnDelete.BackColor = System.Drawing.Color.Crimson;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnDelete.ForeColor = System.Drawing.Color.Black;
            this._btnDelete.Location = new System.Drawing.Point(743, 12);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(26, 23);
            this._btnDelete.TabIndex = 10;
            this._btnDelete.Text = "X";
            this._btnDelete.UseVisualStyleBackColor = false;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // CarItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._lblCarPlate);
            this.Controls.Add(this._lblCarName);
            this.Controls.Add(this._lblCarId);
            this.Name = "CarItemControl";
            this.Size = new System.Drawing.Size(772, 48);
            this.Load += new System.EventHandler(this.CarItemControl_Load);
            this.Click += new System.EventHandler(this.CarItemControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblCarId;
        private Label _lblCarName;
        private Label _lblCarPlate;
        private Button _btnDelete;
    }
}
