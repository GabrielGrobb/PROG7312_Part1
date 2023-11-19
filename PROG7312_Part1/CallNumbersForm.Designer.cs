namespace PROG7312_Part1
{
    partial class CallNumbersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallNumbersForm));
            this.callingNumbersUserControl1 = new PROG7312_Part1.CallingNumbersUserControl();
            this.SuspendLayout();
            // 
            // callingNumbersUserControl1
            // 
            this.callingNumbersUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("callingNumbersUserControl1.BackgroundImage")));
            this.callingNumbersUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.callingNumbersUserControl1.Location = new System.Drawing.Point(0, 0);
            this.callingNumbersUserControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.callingNumbersUserControl1.Name = "callingNumbersUserControl1";
            this.callingNumbersUserControl1.Size = new System.Drawing.Size(1428, 759);
            this.callingNumbersUserControl1.TabIndex = 0;
            // 
            // CallNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 758);
            this.Controls.Add(this.callingNumbersUserControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CallNumbersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallNumbersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CallNumbersForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CallingNumbersUserControl callingNumbersUserControl1;
    }
}