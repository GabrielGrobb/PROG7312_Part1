﻿namespace PROG7312_Part1
{
    partial class IdentifyAreasUserControl
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.identifyAreas_timer = new System.Windows.Forms.Timer(this.components);
            this.leftShelf1 = new System.Windows.Forms.Panel();
            this.leftShelf2 = new System.Windows.Forms.Panel();
            this.leftShelf3 = new System.Windows.Forms.Panel();
            this.leftShelf4 = new System.Windows.Forms.Panel();
            this.rightShelf1 = new System.Windows.Forms.Panel();
            this.rightShelf2 = new System.Windows.Forms.Panel();
            this.rightShelf3 = new System.Windows.Forms.Panel();
            this.rightShelf4 = new System.Windows.Forms.Panel();
            this.descriptionShelf1 = new System.Windows.Forms.Panel();
            this.descriptionShelf2 = new System.Windows.Forms.Panel();
            this.descriptionShelf3 = new System.Windows.Forms.Panel();
            this.descriptionShelf4 = new System.Windows.Forms.Panel();
            this.descriptionShelf5 = new System.Windows.Forms.Panel();
            this.descriptionShelf6 = new System.Windows.Forms.Panel();
            this.descriptionShelf7 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(830, 73);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(138, 38);
            this.btnHelp.TabIndex = 38;
            this.btnHelp.Text = "Help?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Location = new System.Drawing.Point(830, 14);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(138, 38);
            this.btnMainMenu.TabIndex = 37;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnResults
            // 
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.Location = new System.Drawing.Point(15, 260);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(138, 38);
            this.btnResults.TabIndex = 36;
            this.btnResults.Text = "View Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Location = new System.Drawing.Point(15, 200);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(138, 38);
            this.btnRestart.TabIndex = 35;
            this.btnRestart.Text = "Restart?";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(15, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 38);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblTimer.Location = new System.Drawing.Point(209, 14);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(257, 38);
            this.lblTimer.TabIndex = 33;
            this.lblTimer.Text = "label1";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(15, 137);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 38);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset Columns";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(15, 73);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(138, 38);
            this.btnPause.TabIndex = 43;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(258, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 38);
            this.label1.TabIndex = 44;
            this.label1.Text = "Descriptions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // identifyAreas_timer
            // 
            this.identifyAreas_timer.Interval = 1000;
            this.identifyAreas_timer.Tick += new System.EventHandler(this.identifyAreas_timer_Tick);
            // 
            // leftShelf1
            // 
            this.leftShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf1.Location = new System.Drawing.Point(299, 73);
            this.leftShelf1.Name = "leftShelf1";
            this.leftShelf1.Size = new System.Drawing.Size(60, 40);
            this.leftShelf1.TabIndex = 45;
            // 
            // leftShelf2
            // 
            this.leftShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf2.Location = new System.Drawing.Point(299, 137);
            this.leftShelf2.Name = "leftShelf2";
            this.leftShelf2.Size = new System.Drawing.Size(60, 40);
            this.leftShelf2.TabIndex = 46;
            // 
            // leftShelf3
            // 
            this.leftShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf3.Location = new System.Drawing.Point(299, 210);
            this.leftShelf3.Name = "leftShelf3";
            this.leftShelf3.Size = new System.Drawing.Size(60, 40);
            this.leftShelf3.TabIndex = 47;
            // 
            // leftShelf4
            // 
            this.leftShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf4.Location = new System.Drawing.Point(299, 279);
            this.leftShelf4.Name = "leftShelf4";
            this.leftShelf4.Size = new System.Drawing.Size(60, 40);
            this.leftShelf4.TabIndex = 48;
            // 
            // rightShelf1
            // 
            this.rightShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf1.Location = new System.Drawing.Point(479, 73);
            this.rightShelf1.Name = "rightShelf1";
            this.rightShelf1.Size = new System.Drawing.Size(200, 40);
            this.rightShelf1.TabIndex = 49;
            // 
            // rightShelf2
            // 
            this.rightShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf2.Location = new System.Drawing.Point(479, 137);
            this.rightShelf2.Name = "rightShelf2";
            this.rightShelf2.Size = new System.Drawing.Size(200, 40);
            this.rightShelf2.TabIndex = 50;
            // 
            // rightShelf3
            // 
            this.rightShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf3.Location = new System.Drawing.Point(479, 210);
            this.rightShelf3.Name = "rightShelf3";
            this.rightShelf3.Size = new System.Drawing.Size(200, 40);
            this.rightShelf3.TabIndex = 51;
            // 
            // rightShelf4
            // 
            this.rightShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf4.Location = new System.Drawing.Point(479, 279);
            this.rightShelf4.Name = "rightShelf4";
            this.rightShelf4.Size = new System.Drawing.Size(200, 40);
            this.rightShelf4.TabIndex = 52;
            // 
            // descriptionShelf1
            // 
            this.descriptionShelf1.AllowDrop = true;
            this.descriptionShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf1.Location = new System.Drawing.Point(289, 447);
            this.descriptionShelf1.Name = "descriptionShelf1";
            this.descriptionShelf1.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf1.TabIndex = 53;
            // 
            // descriptionShelf2
            // 
            this.descriptionShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf2.Location = new System.Drawing.Point(508, 447);
            this.descriptionShelf2.Name = "descriptionShelf2";
            this.descriptionShelf2.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf2.TabIndex = 54;
            // 
            // descriptionShelf3
            // 
            this.descriptionShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf3.Location = new System.Drawing.Point(289, 512);
            this.descriptionShelf3.Name = "descriptionShelf3";
            this.descriptionShelf3.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf3.TabIndex = 55;
            // 
            // descriptionShelf4
            // 
            this.descriptionShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf4.Location = new System.Drawing.Point(508, 512);
            this.descriptionShelf4.Name = "descriptionShelf4";
            this.descriptionShelf4.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf4.TabIndex = 56;
            // 
            // descriptionShelf5
            // 
            this.descriptionShelf5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf5.Location = new System.Drawing.Point(289, 567);
            this.descriptionShelf5.Name = "descriptionShelf5";
            this.descriptionShelf5.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf5.TabIndex = 57;
            // 
            // descriptionShelf6
            // 
            this.descriptionShelf6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf6.Location = new System.Drawing.Point(508, 567);
            this.descriptionShelf6.Name = "descriptionShelf6";
            this.descriptionShelf6.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf6.TabIndex = 58;
            // 
            // descriptionShelf7
            // 
            this.descriptionShelf7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf7.Location = new System.Drawing.Point(396, 622);
            this.descriptionShelf7.Name = "descriptionShelf7";
            this.descriptionShelf7.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf7.TabIndex = 59;
            // 
            // IdentifyAreasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.part2background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.descriptionShelf7);
            this.Controls.Add(this.descriptionShelf6);
            this.Controls.Add(this.descriptionShelf5);
            this.Controls.Add(this.descriptionShelf4);
            this.Controls.Add(this.descriptionShelf3);
            this.Controls.Add(this.descriptionShelf2);
            this.Controls.Add(this.descriptionShelf1);
            this.Controls.Add(this.rightShelf4);
            this.Controls.Add(this.rightShelf3);
            this.Controls.Add(this.rightShelf2);
            this.Controls.Add(this.rightShelf1);
            this.Controls.Add(this.leftShelf4);
            this.Controls.Add(this.leftShelf3);
            this.Controls.Add(this.leftShelf2);
            this.Controls.Add(this.leftShelf1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnReset);
            this.DoubleBuffered = true;
            this.Name = "IdentifyAreasUserControl";
            this.Size = new System.Drawing.Size(1000, 686);
            this.Load += new System.EventHandler(this.IdentifyAreasUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer identifyAreas_timer;
        private System.Windows.Forms.Panel leftShelf1;
        private System.Windows.Forms.Panel leftShelf2;
        private System.Windows.Forms.Panel leftShelf3;
        private System.Windows.Forms.Panel leftShelf4;
        private System.Windows.Forms.Panel rightShelf1;
        private System.Windows.Forms.Panel rightShelf2;
        private System.Windows.Forms.Panel rightShelf3;
        private System.Windows.Forms.Panel rightShelf4;
        private System.Windows.Forms.Panel descriptionShelf1;
        private System.Windows.Forms.Panel descriptionShelf2;
        private System.Windows.Forms.Panel descriptionShelf3;
        private System.Windows.Forms.Panel descriptionShelf4;
        private System.Windows.Forms.Panel descriptionShelf5;
        private System.Windows.Forms.Panel descriptionShelf6;
        private System.Windows.Forms.Panel descriptionShelf7;
    }
}
