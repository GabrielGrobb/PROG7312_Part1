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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallingNumbersUserControl));
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
            this.btnResults = new PROG7312_Part1.CustomButton();
            this.btnHelp = new PROG7312_Part1.CustomButton();
            this.btnMainMenu = new PROG7312_Part1.CustomButton();
            this.btnPlayAgain = new PROG7312_Part1.CustomButton();
            this.btnResume = new PROG7312_Part1.CustomButton();
            this.btnPause = new PROG7312_Part1.CustomButton();
            this.btnStart = new PROG7312_Part1.CustomButton();
            this.btnExit = new PROG7312_Part1.CustomButton();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblDescription.Location = new System.Drawing.Point(413, 262);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(587, 57);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoOption1
            // 
            this.rdoOption1.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption1.Location = new System.Drawing.Point(244, 406);
            this.rdoOption1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(20, 23);
            this.rdoOption1.TabIndex = 3;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoOption1.UseVisualStyleBackColor = false;
            this.rdoOption1.Click += new System.EventHandler(this.rdoOption1_Click);
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption2.Location = new System.Drawing.Point(556, 406);
            this.rdoOption2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(17, 16);
            this.rdoOption2.TabIndex = 4;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.UseVisualStyleBackColor = false;
            this.rdoOption2.Click += new System.EventHandler(this.rdoOption2_Click);
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption3.Location = new System.Drawing.Point(860, 406);
            this.rdoOption3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(17, 16);
            this.rdoOption3.TabIndex = 5;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.UseVisualStyleBackColor = false;
            this.rdoOption3.Click += new System.EventHandler(this.rdoOption3_Click);
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption4.Location = new System.Drawing.Point(1155, 406);
            this.rdoOption4.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(17, 16);
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
            this.lblTimer.Location = new System.Drawing.Point(607, 32);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(369, 49);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captionPanel1
            // 
            this.captionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel1.Location = new System.Drawing.Point(125, 437);
            this.captionPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.captionPanel1.Name = "captionPanel1";
            this.captionPanel1.Size = new System.Drawing.Size(277, 85);
            this.captionPanel1.TabIndex = 8;
            // 
            // captionPanel2
            // 
            this.captionPanel2.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel2.Location = new System.Drawing.Point(423, 437);
            this.captionPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.captionPanel2.Name = "captionPanel2";
            this.captionPanel2.Size = new System.Drawing.Size(277, 85);
            this.captionPanel2.TabIndex = 9;
            // 
            // captionPanel3
            // 
            this.captionPanel3.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel3.Location = new System.Drawing.Point(732, 437);
            this.captionPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.captionPanel3.Name = "captionPanel3";
            this.captionPanel3.Size = new System.Drawing.Size(277, 85);
            this.captionPanel3.TabIndex = 10;
            // 
            // captionPanel4
            // 
            this.captionPanel4.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel4.Location = new System.Drawing.Point(1032, 437);
            this.captionPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.captionPanel4.Name = "captionPanel4";
            this.captionPanel4.Size = new System.Drawing.Size(255, 85);
            this.captionPanel4.TabIndex = 11;
            // 
            // callingNumbersTimer
            // 
            this.callingNumbersTimer.Interval = 1000;
            this.callingNumbersTimer.Tick += new System.EventHandler(this.callingNumbersTimer_Tick);
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaption.Location = new System.Drawing.Point(125, 336);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(1161, 49);
            this.lblCaption.TabIndex = 14;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Cyan;
            this.btnResults.BackgroundColor = System.Drawing.Color.Cyan;
            this.btnResults.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResults.BorderRadius = 40;
            this.btnResults.BorderSize = 0;
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.Black;
            this.btnResults.Location = new System.Drawing.Point(1189, 28);
            this.btnResults.Margin = new System.Windows.Forms.Padding(4);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(223, 58);
            this.btnResults.TabIndex = 18;
            this.btnResults.Text = "RESULTS";
            this.btnResults.TextColor = System.Drawing.Color.Black;
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::PROG7312_Part1.Properties.Resources.btnHelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderColor = System.Drawing.Color.Transparent;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.BorderSize = 0;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.Location = new System.Drawing.Point(151, 15);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(113, 97);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.TextColor = System.Drawing.Color.Transparent;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.BackgroundImage = global::PROG7312_Part1.Properties.Resources.btnHome;
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainMenu.BorderColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.BorderRadius = 0;
            this.btnMainMenu.BorderSize = 0;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 15);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(113, 97);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.TextColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Gold;
            this.btnPlayAgain.BackgroundColor = System.Drawing.Color.Gold;
            this.btnPlayAgain.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlayAgain.BorderRadius = 40;
            this.btnPlayAgain.BorderSize = 0;
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.Location = new System.Drawing.Point(607, 581);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(223, 58);
            this.btnPlayAgain.TabIndex = 15;
            this.btnPlayAgain.Text = "PLAY AGAIN?";
            this.btnPlayAgain.TextColor = System.Drawing.Color.Black;
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Transparent;
            this.btnResume.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnResume.BackgroundImage = global::PROG7312_Part1.Properties.Resources.btnResume;
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResume.BorderColor = System.Drawing.Color.Transparent;
            this.btnResume.BorderRadius = 0;
            this.btnResume.BorderSize = 0;
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.Black;
            this.btnResume.Location = new System.Drawing.Point(607, 135);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(120, 110);
            this.btnResume.TabIndex = 13;
            this.btnResume.TextColor = System.Drawing.Color.Black;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.BorderColor = System.Drawing.Color.Transparent;
            this.btnPause.BorderRadius = 0;
            this.btnPause.BorderSize = 0;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnPause.Location = new System.Drawing.Point(485, 142);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(113, 97);
            this.btnPause.TabIndex = 12;
            this.btnPause.TextColor = System.Drawing.Color.Transparent;
            this.btnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 0;
            this.btnStart.BorderSize = 0;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(485, 15);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 97);
            this.btnStart.TabIndex = 2;
            this.btnStart.TextColor = System.Drawing.Color.Transparent;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::PROG7312_Part1.Properties.Resources.btnExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 0;
            this.btnExit.BorderSize = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(12, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 97);
            this.btnExit.TabIndex = 19;
            this.btnExit.TextColor = System.Drawing.Color.Transparent;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CallingNumbersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.CallingNumbers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnPlayAgain);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CallingNumbersUserControl";
            this.Size = new System.Drawing.Size(1428, 759);
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
        private CustomButton btnPlayAgain;
        private CustomButton btnMainMenu;
        private CustomButton btnHelp;
        private CustomButton btnResults;
        private CustomButton btnExit;
    }
}
