namespace PROG7312_Part1
{
    partial class IDAreasHelpForm
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.pBoxHelp = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(305, 24);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(201, 61);
            this.lblHelp.TabIndex = 7;
            this.lblHelp.Text = "Help / Tutorial";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxHelp
            // 
            this.pBoxHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxHelp.ErrorImage = null;
            this.pBoxHelp.InitialImage = null;
            this.pBoxHelp.Location = new System.Drawing.Point(95, 97);
            this.pBoxHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxHelp.Name = "pBoxHelp";
            this.pBoxHelp.Size = new System.Drawing.Size(622, 364);
            this.pBoxHelp.TabIndex = 6;
            this.pBoxHelp.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(423, 475);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 48);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(272, 475);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 48);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // IDAreasHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 545);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.pBoxHelp);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.MaximumSize = new System.Drawing.Size(843, 584);
            this.MinimumSize = new System.Drawing.Size(843, 584);
            this.Name = "IDAreasHelpForm";
            this.Text = "IDAreasHelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.PictureBox pBoxHelp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}