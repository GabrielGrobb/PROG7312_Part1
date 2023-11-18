﻿namespace PROG7312_Part1
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
            this.btnMainMenu = new PROG7312_Part1.CustomButton();
            this.btnPlayAgain = new PROG7312_Part1.CustomButton();
            this.btnResume = new PROG7312_Part1.CustomButton();
            this.btnPause = new PROG7312_Part1.CustomButton();
            this.btnStart = new PROG7312_Part1.CustomButton();
            this.customButton1 = new PROG7312_Part1.CustomButton();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblDescription.Location = new System.Drawing.Point(310, 197);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(440, 57);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoOption1
            // 
            this.rdoOption1.BackColor = System.Drawing.Color.Transparent;
            this.rdoOption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption1.Location = new System.Drawing.Point(183, 330);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(15, 19);
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
            this.rdoOption2.Location = new System.Drawing.Point(417, 330);
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
            this.rdoOption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption3.Location = new System.Drawing.Point(645, 330);
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
            this.rdoOption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOption4.Location = new System.Drawing.Point(866, 330);
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
            this.lblTimer.Location = new System.Drawing.Point(455, 26);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(277, 40);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captionPanel1
            // 
            this.captionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel1.Location = new System.Drawing.Point(94, 355);
            this.captionPanel1.Name = "captionPanel1";
            this.captionPanel1.Size = new System.Drawing.Size(208, 69);
            this.captionPanel1.TabIndex = 8;
            // 
            // captionPanel2
            // 
            this.captionPanel2.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel2.Location = new System.Drawing.Point(317, 355);
            this.captionPanel2.Name = "captionPanel2";
            this.captionPanel2.Size = new System.Drawing.Size(208, 69);
            this.captionPanel2.TabIndex = 9;
            // 
            // captionPanel3
            // 
            this.captionPanel3.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel3.Location = new System.Drawing.Point(549, 355);
            this.captionPanel3.Name = "captionPanel3";
            this.captionPanel3.Size = new System.Drawing.Size(208, 69);
            this.captionPanel3.TabIndex = 10;
            // 
            // captionPanel4
            // 
            this.captionPanel4.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.captionPanel4.Location = new System.Drawing.Point(774, 355);
            this.captionPanel4.Name = "captionPanel4";
            this.captionPanel4.Size = new System.Drawing.Size(191, 69);
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
            this.lblCaption.Location = new System.Drawing.Point(94, 265);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(871, 40);
            this.lblCaption.TabIndex = 14;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnMainMenu.Location = new System.Drawing.Point(9, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(85, 79);
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
            this.btnPlayAgain.Location = new System.Drawing.Point(455, 472);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(167, 47);
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
            this.btnResume.Location = new System.Drawing.Point(455, 110);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(90, 89);
            this.btnResume.TabIndex = 13;
            this.btnResume.TextColor = System.Drawing.Color.Black;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnPause.Location = new System.Drawing.Point(364, 115);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(85, 79);
            this.btnPause.TabIndex = 12;
            this.btnPause.TextColor = System.Drawing.Color.Transparent;
            this.btnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnStart.Location = new System.Drawing.Point(364, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 79);
            this.btnStart.TabIndex = 2;
            this.btnStart.TextColor = System.Drawing.Color.Transparent;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundImage = global::PROG7312_Part1.Properties.Resources.btnHelp;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Location = new System.Drawing.Point(113, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(85, 79);
            this.customButton1.TabIndex = 17;
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // CallingNumbersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.CallingNumbers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.customButton1);
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
        private CustomButton btnPlayAgain;
        private CustomButton btnMainMenu;
        private CustomButton customButton1;
    }
}
