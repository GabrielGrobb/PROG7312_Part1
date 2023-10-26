namespace PROG7312_Part1
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
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
            this.lblCallingNumbers = new System.Windows.Forms.Label();
            this.callingShelf1 = new System.Windows.Forms.Panel();
            this.callingShelf2 = new System.Windows.Forms.Panel();
            this.callingShelf3 = new System.Windows.Forms.Panel();
            this.callingShelf5 = new System.Windows.Forms.Panel();
            this.callingShelf6 = new System.Windows.Forms.Panel();
            this.callingShelf4 = new System.Windows.Forms.Panel();
            this.callingShelf7 = new System.Windows.Forms.Panel();
            this.lblCallingNumberHeading = new System.Windows.Forms.Label();
            this.lblDescriptionHeading = new System.Windows.Forms.Label();
            this.btnResume = new PROG7312_Part1.CustomButton();
            this.btnPause = new PROG7312_Part1.CustomButton();
            this.btnStart = new PROG7312_Part1.CustomButton();
            this.btnReset = new PROG7312_Part1.CustomButton();
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
            this.btnResults.Location = new System.Drawing.Point(15, 254);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(138, 38);
            this.btnResults.TabIndex = 36;
            this.btnResults.Text = "View Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(209, 13);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(257, 40);
            this.lblTimer.TabIndex = 33;
            this.lblTimer.Text = "label1";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Plum;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblDescription.Location = new System.Drawing.Point(474, 389);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(419, 38);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Descriptions";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // identifyAreas_timer
            // 
            this.identifyAreas_timer.Interval = 1000;
            this.identifyAreas_timer.Tick += new System.EventHandler(this.identifyAreas_timer_Tick);
            // 
            // leftShelf1
            // 
            this.leftShelf1.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf1.Location = new System.Drawing.Point(406, 118);
            this.leftShelf1.Name = "leftShelf1";
            this.leftShelf1.Size = new System.Drawing.Size(60, 40);
            this.leftShelf1.TabIndex = 45;
            // 
            // leftShelf2
            // 
            this.leftShelf2.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf2.Location = new System.Drawing.Point(406, 182);
            this.leftShelf2.Name = "leftShelf2";
            this.leftShelf2.Size = new System.Drawing.Size(60, 40);
            this.leftShelf2.TabIndex = 46;
            // 
            // leftShelf3
            // 
            this.leftShelf3.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf3.Location = new System.Drawing.Point(406, 254);
            this.leftShelf3.Name = "leftShelf3";
            this.leftShelf3.Size = new System.Drawing.Size(60, 40);
            this.leftShelf3.TabIndex = 47;
            // 
            // leftShelf4
            // 
            this.leftShelf4.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf4.Location = new System.Drawing.Point(406, 323);
            this.leftShelf4.Name = "leftShelf4";
            this.leftShelf4.Size = new System.Drawing.Size(60, 40);
            this.leftShelf4.TabIndex = 48;
            // 
            // rightShelf1
            // 
            this.rightShelf1.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf1.Location = new System.Drawing.Point(480, 118);
            this.rightShelf1.Name = "rightShelf1";
            this.rightShelf1.Size = new System.Drawing.Size(200, 40);
            this.rightShelf1.TabIndex = 49;
            // 
            // rightShelf2
            // 
            this.rightShelf2.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf2.Location = new System.Drawing.Point(480, 182);
            this.rightShelf2.Name = "rightShelf2";
            this.rightShelf2.Size = new System.Drawing.Size(200, 40);
            this.rightShelf2.TabIndex = 50;
            // 
            // rightShelf3
            // 
            this.rightShelf3.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf3.Location = new System.Drawing.Point(480, 254);
            this.rightShelf3.Name = "rightShelf3";
            this.rightShelf3.Size = new System.Drawing.Size(200, 40);
            this.rightShelf3.TabIndex = 51;
            // 
            // rightShelf4
            // 
            this.rightShelf4.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf4.Location = new System.Drawing.Point(480, 323);
            this.rightShelf4.Name = "rightShelf4";
            this.rightShelf4.Size = new System.Drawing.Size(200, 40);
            this.rightShelf4.TabIndex = 52;
            // 
            // descriptionShelf1
            // 
            this.descriptionShelf1.AllowDrop = true;
            this.descriptionShelf1.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf1.Location = new System.Drawing.Point(474, 450);
            this.descriptionShelf1.Name = "descriptionShelf1";
            this.descriptionShelf1.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf1.TabIndex = 53;
            // 
            // descriptionShelf2
            // 
            this.descriptionShelf2.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf2.Location = new System.Drawing.Point(693, 450);
            this.descriptionShelf2.Name = "descriptionShelf2";
            this.descriptionShelf2.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf2.TabIndex = 54;
            // 
            // descriptionShelf3
            // 
            this.descriptionShelf3.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf3.Location = new System.Drawing.Point(474, 505);
            this.descriptionShelf3.Name = "descriptionShelf3";
            this.descriptionShelf3.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf3.TabIndex = 55;
            // 
            // descriptionShelf4
            // 
            this.descriptionShelf4.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf4.Location = new System.Drawing.Point(693, 505);
            this.descriptionShelf4.Name = "descriptionShelf4";
            this.descriptionShelf4.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf4.TabIndex = 56;
            // 
            // descriptionShelf5
            // 
            this.descriptionShelf5.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf5.Location = new System.Drawing.Point(474, 560);
            this.descriptionShelf5.Name = "descriptionShelf5";
            this.descriptionShelf5.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf5.TabIndex = 57;
            // 
            // descriptionShelf6
            // 
            this.descriptionShelf6.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf6.Location = new System.Drawing.Point(695, 560);
            this.descriptionShelf6.Name = "descriptionShelf6";
            this.descriptionShelf6.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf6.TabIndex = 58;
            // 
            // descriptionShelf7
            // 
            this.descriptionShelf7.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf7.Location = new System.Drawing.Point(474, 616);
            this.descriptionShelf7.Name = "descriptionShelf7";
            this.descriptionShelf7.Size = new System.Drawing.Size(200, 40);
            this.descriptionShelf7.TabIndex = 59;
            // 
            // lblCallingNumbers
            // 
            this.lblCallingNumbers.BackColor = System.Drawing.Color.LightCoral;
            this.lblCallingNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCallingNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallingNumbers.ForeColor = System.Drawing.Color.Yellow;
            this.lblCallingNumbers.Location = new System.Drawing.Point(172, 389);
            this.lblCallingNumbers.Name = "lblCallingNumbers";
            this.lblCallingNumbers.Size = new System.Drawing.Size(294, 38);
            this.lblCallingNumbers.TabIndex = 60;
            this.lblCallingNumbers.Text = "Calling Numbers";
            this.lblCallingNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // callingShelf1
            // 
            this.callingShelf1.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf1.Location = new System.Drawing.Point(406, 450);
            this.callingShelf1.Name = "callingShelf1";
            this.callingShelf1.Size = new System.Drawing.Size(60, 40);
            this.callingShelf1.TabIndex = 46;
            // 
            // callingShelf2
            // 
            this.callingShelf2.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf2.Location = new System.Drawing.Point(329, 450);
            this.callingShelf2.Name = "callingShelf2";
            this.callingShelf2.Size = new System.Drawing.Size(60, 40);
            this.callingShelf2.TabIndex = 47;
            // 
            // callingShelf3
            // 
            this.callingShelf3.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf3.Location = new System.Drawing.Point(250, 450);
            this.callingShelf3.Name = "callingShelf3";
            this.callingShelf3.Size = new System.Drawing.Size(60, 40);
            this.callingShelf3.TabIndex = 47;
            // 
            // callingShelf5
            // 
            this.callingShelf5.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf5.Location = new System.Drawing.Point(406, 505);
            this.callingShelf5.Name = "callingShelf5";
            this.callingShelf5.Size = new System.Drawing.Size(60, 40);
            this.callingShelf5.TabIndex = 47;
            // 
            // callingShelf6
            // 
            this.callingShelf6.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf6.Location = new System.Drawing.Point(329, 505);
            this.callingShelf6.Name = "callingShelf6";
            this.callingShelf6.Size = new System.Drawing.Size(60, 40);
            this.callingShelf6.TabIndex = 47;
            // 
            // callingShelf4
            // 
            this.callingShelf4.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf4.Location = new System.Drawing.Point(172, 450);
            this.callingShelf4.Name = "callingShelf4";
            this.callingShelf4.Size = new System.Drawing.Size(60, 40);
            this.callingShelf4.TabIndex = 47;
            // 
            // callingShelf7
            // 
            this.callingShelf7.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf7.Location = new System.Drawing.Point(250, 505);
            this.callingShelf7.Name = "callingShelf7";
            this.callingShelf7.Size = new System.Drawing.Size(60, 40);
            this.callingShelf7.TabIndex = 47;
            // 
            // lblCallingNumberHeading
            // 
            this.lblCallingNumberHeading.BackColor = System.Drawing.Color.LightCoral;
            this.lblCallingNumberHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallingNumberHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblCallingNumberHeading.Location = new System.Drawing.Point(292, 76);
            this.lblCallingNumberHeading.Name = "lblCallingNumberHeading";
            this.lblCallingNumberHeading.Size = new System.Drawing.Size(174, 38);
            this.lblCallingNumberHeading.TabIndex = 61;
            this.lblCallingNumberHeading.Text = "Calling Numbers";
            this.lblCallingNumberHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescriptionHeading
            // 
            this.lblDescriptionHeading.BackColor = System.Drawing.Color.Plum;
            this.lblDescriptionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionHeading.ForeColor = System.Drawing.Color.Blue;
            this.lblDescriptionHeading.Location = new System.Drawing.Point(480, 76);
            this.lblDescriptionHeading.Name = "lblDescriptionHeading";
            this.lblDescriptionHeading.Size = new System.Drawing.Size(200, 38);
            this.lblDescriptionHeading.TabIndex = 62;
            this.lblDescriptionHeading.Text = "Descriptions";
            this.lblDescriptionHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResume.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResume.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResume.BorderRadius = 40;
            this.btnResume.BorderSize = 0;
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(15, 135);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(138, 40);
            this.btnResume.TabIndex = 66;
            this.btnResume.Text = "Resume?";
            this.btnResume.TextColor = System.Drawing.Color.White;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.IndianRed;
            this.btnPause.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnPause.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPause.BorderRadius = 40;
            this.btnPause.BorderSize = 1;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(15, 72);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(138, 40);
            this.btnPause.TabIndex = 64;
            this.btnPause.Text = "Pause";
            this.btnPause.TextColor = System.Drawing.Color.White;
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
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(15, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 40);
            this.btnStart.TabIndex = 63;
            this.btnStart.Text = "Start";
            this.btnStart.TextColor = System.Drawing.Color.Black;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Cyan;
            this.btnReset.BackgroundColor = System.Drawing.Color.Cyan;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 40;
            this.btnReset.BorderSize = 0;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(15, 195);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 40);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Reset Round";
            this.btnReset.TextColor = System.Drawing.Color.Black;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // IdentifyAreasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.part2background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDescriptionHeading);
            this.Controls.Add(this.lblCallingNumberHeading);
            this.Controls.Add(this.callingShelf7);
            this.Controls.Add(this.callingShelf4);
            this.Controls.Add(this.callingShelf6);
            this.Controls.Add(this.callingShelf5);
            this.Controls.Add(this.callingShelf3);
            this.Controls.Add(this.callingShelf2);
            this.Controls.Add(this.callingShelf1);
            this.Controls.Add(this.lblCallingNumbers);
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
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblTimer);
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
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblDescription;
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
        private System.Windows.Forms.Label lblCallingNumbers;
        private System.Windows.Forms.Panel callingShelf1;
        private System.Windows.Forms.Panel callingShelf2;
        private System.Windows.Forms.Panel callingShelf3;
        private System.Windows.Forms.Panel callingShelf5;
        private System.Windows.Forms.Panel callingShelf6;
        private System.Windows.Forms.Panel callingShelf4;
        private System.Windows.Forms.Panel callingShelf7;
        private System.Windows.Forms.Label lblCallingNumberHeading;
        private System.Windows.Forms.Label lblDescriptionHeading;
        private CustomButton btnStart;
        private CustomButton btnPause;
        private CustomButton btnResume;
        private CustomButton btnReset;
    }
}
