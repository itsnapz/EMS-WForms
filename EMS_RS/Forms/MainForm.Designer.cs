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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._pnlResponds = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._btnAddRespond = new System.Windows.Forms.Button();
            this._btnResponds = new System.Windows.Forms.Button();
            this._btnDoctors = new System.Windows.Forms.Button();
            this._btnSettings = new System.Windows.Forms.Button();
            this._btnPatients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblRank
            // 
            this._lblRank.AutoSize = true;
            this._lblRank.BackColor = System.Drawing.Color.Crimson;
            this._lblRank.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblRank.ForeColor = System.Drawing.Color.White;
            this._lblRank.Location = new System.Drawing.Point(67, 52);
            this._lblRank.Name = "_lblRank";
            this._lblRank.Size = new System.Drawing.Size(57, 28);
            this._lblRank.TabIndex = 0;
            this._lblRank.Text = "Rank";
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.BackColor = System.Drawing.Color.Crimson;
            this._lblName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblName.ForeColor = System.Drawing.Color.White;
            this._lblName.Location = new System.Drawing.Point(24, 9);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(69, 28);
            this._lblName.TabIndex = 1;
            this._lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 535);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // _pnlResponds
            // 
            this._pnlResponds.Location = new System.Drawing.Point(200, 43);
            this._pnlResponds.Name = "_pnlResponds";
            this._pnlResponds.Size = new System.Drawing.Size(882, 483);
            this._pnlResponds.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(450, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(597, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(741, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(870, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(983, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Car";
            // 
            // _btnAddRespond
            // 
            this._btnAddRespond.Location = new System.Drawing.Point(53, 485);
            this._btnAddRespond.Name = "_btnAddRespond";
            this._btnAddRespond.Size = new System.Drawing.Size(94, 29);
            this._btnAddRespond.TabIndex = 12;
            this._btnAddRespond.Text = "Add";
            this._btnAddRespond.UseVisualStyleBackColor = true;
            this._btnAddRespond.Click += new System.EventHandler(this._btnAddRespond_Click);
            // 
            // _btnResponds
            // 
            this._btnResponds.BackColor = System.Drawing.Color.Crimson;
            this._btnResponds.FlatAppearance.BorderSize = 0;
            this._btnResponds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnResponds.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnResponds.ForeColor = System.Drawing.Color.White;
            this._btnResponds.Image = global::EMS_RS.Properties.Resources.respond;
            this._btnResponds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnResponds.Location = new System.Drawing.Point(-5, 110);
            this._btnResponds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnResponds.Name = "_btnResponds";
            this._btnResponds.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this._btnResponds.Size = new System.Drawing.Size(203, 53);
            this._btnResponds.TabIndex = 13;
            this._btnResponds.Text = "Responds";
            this._btnResponds.UseVisualStyleBackColor = false;
            this._btnResponds.Click += new System.EventHandler(this._btnResponds_Click);
            // 
            // _btnDoctors
            // 
            this._btnDoctors.BackColor = System.Drawing.Color.Crimson;
            this._btnDoctors.FlatAppearance.BorderSize = 0;
            this._btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDoctors.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnDoctors.ForeColor = System.Drawing.Color.White;
            this._btnDoctors.Image = global::EMS_RS.Properties.Resources.doctor;
            this._btnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDoctors.Location = new System.Drawing.Point(-5, 232);
            this._btnDoctors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnDoctors.Name = "_btnDoctors";
            this._btnDoctors.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this._btnDoctors.Size = new System.Drawing.Size(203, 53);
            this._btnDoctors.TabIndex = 14;
            this._btnDoctors.Text = "Doctors";
            this._btnDoctors.UseVisualStyleBackColor = false;
            this._btnDoctors.Click += new System.EventHandler(this._btnDoctors_Click);
            // 
            // _btnSettings
            // 
            this._btnSettings.BackColor = System.Drawing.Color.Crimson;
            this._btnSettings.FlatAppearance.BorderSize = 0;
            this._btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSettings.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnSettings.ForeColor = System.Drawing.Color.White;
            this._btnSettings.Image = global::EMS_RS.Properties.Resources.settings;
            this._btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSettings.Location = new System.Drawing.Point(-5, 293);
            this._btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnSettings.Name = "_btnSettings";
            this._btnSettings.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this._btnSettings.Size = new System.Drawing.Size(203, 53);
            this._btnSettings.TabIndex = 15;
            this._btnSettings.Text = "Settings";
            this._btnSettings.UseVisualStyleBackColor = false;
            this._btnSettings.Click += new System.EventHandler(this._btnSettings_Click);
            // 
            // _btnPatients
            // 
            this._btnPatients.BackColor = System.Drawing.Color.Crimson;
            this._btnPatients.FlatAppearance.BorderSize = 0;
            this._btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPatients.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnPatients.ForeColor = System.Drawing.Color.White;
            this._btnPatients.Image = global::EMS_RS.Properties.Resources.patient;
            this._btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPatients.Location = new System.Drawing.Point(-5, 171);
            this._btnPatients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnPatients.Name = "_btnPatients";
            this._btnPatients.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this._btnPatients.Size = new System.Drawing.Size(203, 53);
            this._btnPatients.TabIndex = 16;
            this._btnPatients.Text = "Patients";
            this._btnPatients.UseVisualStyleBackColor = false;
            this._btnPatients.Click += new System.EventHandler(this._btnPatients_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 525);
            this.Controls.Add(this._btnPatients);
            this.Controls.Add(this._btnSettings);
            this.Controls.Add(this._btnDoctors);
            this.Controls.Add(this._btnResponds);
            this.Controls.Add(this._btnAddRespond);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pnlResponds);
            this.Controls.Add(this._lblRank);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this.pictureBox1);
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
        private PictureBox pictureBox1;
        private Panel _pnlResponds;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button _btnAddRespond;
        private Button _btnResponds;
        private Button _btnDoctors;
        private Button _btnSettings;
        private Button _btnPatients;
    }
}