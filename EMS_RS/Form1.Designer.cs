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
            this._lblEmsRS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblEmsRS
            // 
            this._lblEmsRS.AutoSize = true;
            this._lblEmsRS.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblEmsRS.ForeColor = System.Drawing.Color.Crimson;
            this._lblEmsRS.Location = new System.Drawing.Point(295, 9);
            this._lblEmsRS.Name = "_lblEmsRS";
            this._lblEmsRS.Size = new System.Drawing.Size(485, 54);
            this._lblEmsRS.TabIndex = 0;
            this._lblEmsRS.Text = "EMS Responding Service";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this._lblEmsRS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblEmsRS;
    }
}