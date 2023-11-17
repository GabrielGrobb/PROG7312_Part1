namespace PROG7312_Part1
{
    partial class CallingNumbersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.rdoOption3 = new System.Windows.Forms.RadioButton();
            this.rdoOption4 = new System.Windows.Forms.RadioButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.captionPanel1 = new System.Windows.Forms.Panel();
            this.captionPanel2 = new System.Windows.Forms.Panel();
            this.captionPanel3 = new System.Windows.Forms.Panel();
            this.captionPanel4 = new System.Windows.Forms.Panel();
            this.callingNumbersTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCaption = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnResume = new PROG7312_Part1.CustomButton();
            this.btnPause = new PROG7312_Part1.CustomButton();
            this.btnStart = new PROG7312_Part1.CustomButton();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(260, 195);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(132, 34);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption1.Location = new System.Drawing.Point(307, 242);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(14, 13);
            this.rdoOption1.TabIndex = 3;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.UseVisualStyleBackColor = false;
            this.rdoOption1.Click += new System.EventHandler(this.rdoOption1_Click);
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption2.Location = new System.Drawing.Point(471, 242);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(14, 13);
            this.rdoOption2.TabIndex = 4;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.UseVisualStyleBackColor = false;
            this.rdoOption2.Click += new System.EventHandler(this.rdoOption2_Click);
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption3.Location = new System.Drawing.Point(624, 242);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(14, 13);
            this.rdoOption3.TabIndex = 5;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.UseVisualStyleBackColor = false;
            this.rdoOption3.Click += new System.EventHandler(this.rdoOption3_Click);
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption4.Location = new System.Drawing.Point(764, 242);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(14, 13);
            this.rdoOption4.TabIndex = 6;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.UseVisualStyleBackColor = false;
            this.rdoOption4.Click += new System.EventHandler(this.rdoOption4_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTimer.Location = new System.Drawing.Point(420, 21);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(277, 40);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captionPanel1
            // 
            this.captionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel1.Location = new System.Drawing.Point(274, 273);
            this.captionPanel1.Name = "captionPanel1";
            this.captionPanel1.Size = new System.Drawing.Size(80, 150);
            this.captionPanel1.TabIndex = 8;
            // 
            // captionPanel2
            // 
            this.captionPanel2.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel2.Location = new System.Drawing.Point(433, 273);
            this.captionPanel2.Name = "captionPanel2";
            this.captionPanel2.Size = new System.Drawing.Size(80, 150);
            this.captionPanel2.TabIndex = 9;
            // 
            // captionPanel3
            // 
            this.captionPanel3.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel3.Location = new System.Drawing.Point(591, 273);
            this.captionPanel3.Name = "captionPanel3";
            this.captionPanel3.Size = new System.Drawing.Size(80, 150);
            this.captionPanel3.TabIndex = 10;
            // 
            // captionPanel4
            // 
            this.captionPanel4.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel4.Location = new System.Drawing.Point(731, 273);
            this.captionPanel4.Name = "captionPanel4";
            this.captionPanel4.Size = new System.Drawing.Size(80, 150);
            this.captionPanel4.TabIndex = 11;
            // 
            // callingNumbersTimer
            // 
            this.callingNumbersTimer.Interval = 1000;
            this.callingNumbersTimer.Tick += new System.EventHandler(this.callingNumbersTimer_Tick);
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.Window;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaption.Location = new System.Drawing.Point(418, 189);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(277, 40);
            this.lblCaption.TabIndex = 14;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResume.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResume.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResume.BorderRadius = 40;
            this.btnResume.BorderSize = 0;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.Black;
            this.btnResume.Location = new System.Drawing.Point(242, 113);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(150, 40);
            this.btnResume.TabIndex = 13;
            this.btnResume.Text = "RESUME?";
            this.btnResume.TextColor = System.Drawing.Color.Black;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.IndianRed;
            this.btnPause.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnPause.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPause.BorderRadius = 40;
            this.btnPause.BorderSize = 0;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(242, 67);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(150, 40);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "PAUSE";
            this.btnPause.TextColor = System.Drawing.Color.Black;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStart.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btnStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStart.BorderRadius = 40;
            this.btnStart.BorderSize = 0;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(242, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.TextColor = System.Drawing.Color.Black;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CallingNumbersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.CallingNumbers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.captionPanel4);
            this.Controls.Add(this.captionPanel3);
            this.Controls.Add(this.captionPanel2);
            this.Controls.Add(this.captionPanel1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.rdoOption4);
            this.Controls.Add(this.rdoOption3);
            this.Controls.Add(this.rdoOption2);
            this.Controls.Add(this.rdoOption1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDescription);
            this.DoubleBuffered = true;
            this.Name = "CallingNumbersUserControl";
            this.Size = new System.Drawing.Size(1071, 617);
            this.Load += new System.EventHandler(this.CallingNumbersUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private CustomButton btnStart;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.RadioButton rdoOption3;
        private System.Windows.Forms.RadioButton rdoOption4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel captionPanel1;
        private System.Windows.Forms.Panel captionPanel2;
        private System.Windows.Forms.Panel captionPanel3;
        private System.Windows.Forms.Panel captionPanel4;
        private System.Windows.Forms.Timer callingNumbersTimer;
        private CustomButton btnPause;
        private CustomButton btnResume;
        private System.Windows.Forms.Label lblCaption;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
