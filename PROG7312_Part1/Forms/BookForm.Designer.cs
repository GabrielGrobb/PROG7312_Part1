namespace PROG7312_Part1
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.bookUserControl1 = new PROG7312_Part1.BookUserControl();
            this.SuspendLayout();
            // 
            // bookUserControl1
            // 
            this.bookUserControl1.BackColor = System.Drawing.Color.White;
            this.bookUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookUserControl1.BackgroundImage")));
            this.bookUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookUserControl1.Location = new System.Drawing.Point(0, -1);
            this.bookUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.bookUserControl1.MaximumSize = new System.Drawing.Size(1389, 738);
            this.bookUserControl1.MinimumSize = new System.Drawing.Size(1389, 738);
            this.bookUserControl1.Name = "bookUserControl1";
            this.bookUserControl1.Size = new System.Drawing.Size(1389, 738);
            this.bookUserControl1.TabIndex = 0;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1389, 726);
            this.Controls.Add(this.bookUserControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1407, 773);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1407, 773);
            this.Name = "BookForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.ResumeLayout(false);

        }

        #endregion

        private BookUserControl bookUserControl1;
    }
}