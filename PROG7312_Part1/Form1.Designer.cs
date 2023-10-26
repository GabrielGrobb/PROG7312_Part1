namespace PROG7312_Part1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyAreas = new System.Windows.Forms.Button();
            this.btnCallNumbers = new System.Windows.Forms.Button();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pgDataLoad = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMainMenu.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMainMenu.Location = new System.Drawing.Point(501, 47);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(397, 238);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplacingBooks.Location = new System.Drawing.Point(439, 396);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(128, 48);
            this.btnReplacingBooks.TabIndex = 1;
            this.btnReplacingBooks.Text = "Replace Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = true;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // btnIdentifyAreas
            // 
            this.btnIdentifyAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentifyAreas.Location = new System.Drawing.Point(649, 396);
            this.btnIdentifyAreas.Name = "btnIdentifyAreas";
            this.btnIdentifyAreas.Size = new System.Drawing.Size(128, 48);
            this.btnIdentifyAreas.TabIndex = 2;
            this.btnIdentifyAreas.Text = "Identify Areas";
            this.btnIdentifyAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyAreas.Click += new System.EventHandler(this.btnIdentifyAreas_Click);
            // 
            // btnCallNumbers
            // 
            this.btnCallNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCallNumbers.Location = new System.Drawing.Point(853, 396);
            this.btnCallNumbers.Name = "btnCallNumbers";
            this.btnCallNumbers.Size = new System.Drawing.Size(139, 48);
            this.btnCallNumbers.TabIndex = 3;
            this.btnCallNumbers.Text = "Finding Call Numbers";
            this.btnCallNumbers.UseVisualStyleBackColor = true;
            this.btnCallNumbers.Click += new System.EventHandler(this.btnCallNumbers_Click);
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(556, 37);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(269, 57);
            this.MXP.TabIndex = 4;
            // 
            // pgDataLoad
            // 
            this.pgDataLoad.BackColor = System.Drawing.Color.Firebrick;
            this.pgDataLoad.ForeColor = System.Drawing.Color.Firebrick;
            this.pgDataLoad.Location = new System.Drawing.Point(439, 511);
            this.pgDataLoad.Minimum = 1;
            this.pgDataLoad.Name = "pgDataLoad";
            this.pgDataLoad.Size = new System.Drawing.Size(553, 23);
            this.pgDataLoad.TabIndex = 5;
            this.pgDataLoad.Value = 1;
            this.pgDataLoad.Visible = false;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(911, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.Prog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgDataLoad);
            this.Controls.Add(this.MXP);
            this.Controls.Add(this.btnCallNumbers);
            this.Controls.Add(this.btnIdentifyAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Controls.Add(this.lblMainMenu);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1078, 631);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1078, 631);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyAreas;
        private System.Windows.Forms.Button btnCallNumbers;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
        private System.Windows.Forms.ProgressBar pgDataLoad;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

