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
            this.callingNumbersUserControl1 = new PROG7312_Part1.CallingNumbersUserControl();
            this.SuspendLayout();
            // 
            // callingNumbersUserControl1
            // 
            this.callingNumbersUserControl1.Location = new System.Drawing.Point(0, 0);
            this.callingNumbersUserControl1.Name = "callingNumbersUserControl1";
            this.callingNumbersUserControl1.Size = new System.Drawing.Size(1071, 617);
            this.callingNumbersUserControl1.TabIndex = 0;
            // 
            // CallNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 616);
            this.Controls.Add(this.callingNumbersUserControl1);
            this.Name = "CallNumbersForm";
            this.Text = "CallNumbersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CallingNumbersUserControl callingNumbersUserControl1;
    }
}