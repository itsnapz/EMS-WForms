namespace EMS_RS.Forms
{
    partial class MainForm
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
            this._lblRank = new System.Windows.Forms.Label();
            this._lblName = new System.Windows.Forms.Label();
            this._lblSurname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblRank
            // 
            this._lblRank.AutoSize = true;
            this._lblRank.BackColor = System.Drawing.Color.Crimson;
            this._lblRank.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblRank.ForeColor = System.Drawing.Color.White;
            this._lblRank.Location = new System.Drawing.Point(55, 40);
            this._lblRank.Name = "_lblRank";
            this._lblRank.Size = new System.Drawing.Size(45, 21);
            this._lblRank.TabIndex = 0;
            this._lblRank.Text = "Rank";
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.BackColor = System.Drawing.Color.Crimson;
            this._lblName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblName.ForeColor = System.Drawing.Color.White;
            this._lblName.Location = new System.Drawing.Point(12, 9);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(56, 21);
            this._lblName.TabIndex = 1;
            this._lblName.Text = "Name";
            // 
            // _lblSurname
            // 
            this._lblSurname.AutoSize = true;
            this._lblSurname.BackColor = System.Drawing.Color.Crimson;
            this._lblSurname.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSurname.ForeColor = System.Drawing.Color.White;
            this._lblSurname.Location = new System.Drawing.Point(83, 9);
            this._lblSurname.Name = "_lblSurname";
            this._lblSurname.Size = new System.Drawing.Size(79, 21);
            this._lblSurname.TabIndex = 2;
            this._lblSurname.Text = "Surname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 341);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this._lblSurname);
            this.Controls.Add(this._lblRank);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblRank;
        private Label _lblName;
        private Label _lblSurname;
        private PictureBox pictureBox1;
    }
}