namespace PROG7312_Part1
{
    partial class HelpForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pBoxHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(359, 575);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 59);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(560, 575);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 59);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(403, 20);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(268, 75);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "Help / Tutorial";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxHelp
            // 
            this.pBoxHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxHelp.ErrorImage = null;
            this.pBoxHelp.InitialImage = null;
            this.pBoxHelp.Location = new System.Drawing.Point(123, 109);
            this.pBoxHelp.Name = "pBoxHelp";
            this.pBoxHelp.Size = new System.Drawing.Size(829, 448);
            this.pBoxHelp.TabIndex = 2;
            this.pBoxHelp.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 671);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.pBoxHelp);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pBoxHelp;
        private System.Windows.Forms.Label lblHelp;
    }
}