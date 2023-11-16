namespace PROG7312_Part1
{
    partial class IdentifyAreasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyAreasForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.identifyAreasUserControl1 = new PROG7312_Part1.IdentifyAreasUserControl();
            this.SuspendLayout();
            // 
            // identifyAreasUserControl1
            // 
            this.identifyAreasUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("identifyAreasUserControl1.BackgroundImage")));
            this.identifyAreasUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.identifyAreasUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.identifyAreasUserControl1.Location = new System.Drawing.Point(0, 0);
            this.identifyAreasUserControl1.MaximumSize = new System.Drawing.Size(1000, 686);
            this.identifyAreasUserControl1.MinimumSize = new System.Drawing.Size(1000, 686);
            this.identifyAreasUserControl1.Name = "identifyAreasUserControl1";
            this.identifyAreasUserControl1.Size = new System.Drawing.Size(1000, 686);
            this.identifyAreasUserControl1.TabIndex = 0;
            // 
            // IdentifyAreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 685);
            this.Controls.Add(this.identifyAreasUserControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1017, 724);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1017, 724);
            this.Name = "IdentifyAreasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdentifyAreasForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private IdentifyAreasUserControl identifyAreasUserControl1;
    }
}