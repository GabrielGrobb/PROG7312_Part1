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
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(1107, 90);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(184, 47);
            this.btnHelp.TabIndex = 38;
            this.btnHelp.Text = "Help?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Location = new System.Drawing.Point(1107, 17);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(184, 47);
            this.btnMainMenu.TabIndex = 37;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnResults
            // 
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.Location = new System.Drawing.Point(20, 320);
            this.btnResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(184, 47);
            this.btnResults.TabIndex = 36;
            this.btnResults.Text = "View Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Location = new System.Drawing.Point(20, 246);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(184, 47);
            this.btnRestart.TabIndex = 35;
            this.btnRestart.Text = "Restart?";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(20, 17);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(184, 47);
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
            this.lblTimer.Location = new System.Drawing.Point(279, 17);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(343, 47);
            this.lblTimer.TabIndex = 33;
            this.lblTimer.Text = "label1";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(20, 169);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 47);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset Columns";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(20, 90);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(184, 47);
            this.btnPause.TabIndex = 43;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblDescription.Location = new System.Drawing.Point(632, 479);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(559, 47);
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
            this.leftShelf1.Location = new System.Drawing.Point(542, 145);
            this.leftShelf1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftShelf1.Name = "leftShelf1";
            this.leftShelf1.Size = new System.Drawing.Size(80, 49);
            this.leftShelf1.TabIndex = 45;
            // 
            // leftShelf2
            // 
            this.leftShelf2.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf2.Location = new System.Drawing.Point(542, 224);
            this.leftShelf2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftShelf2.Name = "leftShelf2";
            this.leftShelf2.Size = new System.Drawing.Size(80, 49);
            this.leftShelf2.TabIndex = 46;
            // 
            // leftShelf3
            // 
            this.leftShelf3.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf3.Location = new System.Drawing.Point(542, 313);
            this.leftShelf3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftShelf3.Name = "leftShelf3";
            this.leftShelf3.Size = new System.Drawing.Size(80, 49);
            this.leftShelf3.TabIndex = 47;
            // 
            // leftShelf4
            // 
            this.leftShelf4.BackColor = System.Drawing.Color.Transparent;
            this.leftShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftShelf4.Location = new System.Drawing.Point(542, 398);
            this.leftShelf4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftShelf4.Name = "leftShelf4";
            this.leftShelf4.Size = new System.Drawing.Size(80, 49);
            this.leftShelf4.TabIndex = 48;
            // 
            // rightShelf1
            // 
            this.rightShelf1.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf1.Location = new System.Drawing.Point(640, 145);
            this.rightShelf1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightShelf1.Name = "rightShelf1";
            this.rightShelf1.Size = new System.Drawing.Size(267, 49);
            this.rightShelf1.TabIndex = 49;
            // 
            // rightShelf2
            // 
            this.rightShelf2.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf2.Location = new System.Drawing.Point(640, 224);
            this.rightShelf2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightShelf2.Name = "rightShelf2";
            this.rightShelf2.Size = new System.Drawing.Size(267, 49);
            this.rightShelf2.TabIndex = 50;
            // 
            // rightShelf3
            // 
            this.rightShelf3.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf3.Location = new System.Drawing.Point(640, 313);
            this.rightShelf3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightShelf3.Name = "rightShelf3";
            this.rightShelf3.Size = new System.Drawing.Size(267, 49);
            this.rightShelf3.TabIndex = 51;
            // 
            // rightShelf4
            // 
            this.rightShelf4.BackColor = System.Drawing.Color.Transparent;
            this.rightShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightShelf4.Location = new System.Drawing.Point(640, 398);
            this.rightShelf4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightShelf4.Name = "rightShelf4";
            this.rightShelf4.Size = new System.Drawing.Size(267, 49);
            this.rightShelf4.TabIndex = 52;
            // 
            // descriptionShelf1
            // 
            this.descriptionShelf1.AllowDrop = true;
            this.descriptionShelf1.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf1.Location = new System.Drawing.Point(632, 554);
            this.descriptionShelf1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf1.Name = "descriptionShelf1";
            this.descriptionShelf1.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf1.TabIndex = 53;
            // 
            // descriptionShelf2
            // 
            this.descriptionShelf2.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf2.Location = new System.Drawing.Point(924, 554);
            this.descriptionShelf2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf2.Name = "descriptionShelf2";
            this.descriptionShelf2.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf2.TabIndex = 54;
            // 
            // descriptionShelf3
            // 
            this.descriptionShelf3.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf3.Location = new System.Drawing.Point(632, 622);
            this.descriptionShelf3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf3.Name = "descriptionShelf3";
            this.descriptionShelf3.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf3.TabIndex = 55;
            // 
            // descriptionShelf4
            // 
            this.descriptionShelf4.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf4.Location = new System.Drawing.Point(924, 622);
            this.descriptionShelf4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf4.Name = "descriptionShelf4";
            this.descriptionShelf4.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf4.TabIndex = 56;
            // 
            // descriptionShelf5
            // 
            this.descriptionShelf5.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf5.Location = new System.Drawing.Point(632, 689);
            this.descriptionShelf5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf5.Name = "descriptionShelf5";
            this.descriptionShelf5.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf5.TabIndex = 57;
            // 
            // descriptionShelf6
            // 
            this.descriptionShelf6.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf6.Location = new System.Drawing.Point(927, 689);
            this.descriptionShelf6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf6.Name = "descriptionShelf6";
            this.descriptionShelf6.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf6.TabIndex = 58;
            // 
            // descriptionShelf7
            // 
            this.descriptionShelf7.BackColor = System.Drawing.Color.Transparent;
            this.descriptionShelf7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptionShelf7.Location = new System.Drawing.Point(632, 758);
            this.descriptionShelf7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionShelf7.Name = "descriptionShelf7";
            this.descriptionShelf7.Size = new System.Drawing.Size(267, 49);
            this.descriptionShelf7.TabIndex = 59;
            // 
            // lblCallingNumbers
            // 
            this.lblCallingNumbers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCallingNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallingNumbers.ForeColor = System.Drawing.Color.Blue;
            this.lblCallingNumbers.Location = new System.Drawing.Point(229, 479);
            this.lblCallingNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallingNumbers.Name = "lblCallingNumbers";
            this.lblCallingNumbers.Size = new System.Drawing.Size(392, 47);
            this.lblCallingNumbers.TabIndex = 60;
            this.lblCallingNumbers.Text = "Calling Numbers";
            this.lblCallingNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // callingShelf1
            // 
            this.callingShelf1.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf1.Location = new System.Drawing.Point(541, 554);
            this.callingShelf1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf1.Name = "callingShelf1";
            this.callingShelf1.Size = new System.Drawing.Size(80, 49);
            this.callingShelf1.TabIndex = 46;
            // 
            // callingShelf2
            // 
            this.callingShelf2.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf2.Location = new System.Drawing.Point(439, 554);
            this.callingShelf2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf2.Name = "callingShelf2";
            this.callingShelf2.Size = new System.Drawing.Size(80, 49);
            this.callingShelf2.TabIndex = 47;
            // 
            // callingShelf3
            // 
            this.callingShelf3.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf3.Location = new System.Drawing.Point(333, 554);
            this.callingShelf3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf3.Name = "callingShelf3";
            this.callingShelf3.Size = new System.Drawing.Size(80, 49);
            this.callingShelf3.TabIndex = 47;
            // 
            // callingShelf5
            // 
            this.callingShelf5.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf5.Location = new System.Drawing.Point(541, 622);
            this.callingShelf5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf5.Name = "callingShelf5";
            this.callingShelf5.Size = new System.Drawing.Size(80, 49);
            this.callingShelf5.TabIndex = 47;
            // 
            // callingShelf6
            // 
            this.callingShelf6.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf6.Location = new System.Drawing.Point(439, 622);
            this.callingShelf6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf6.Name = "callingShelf6";
            this.callingShelf6.Size = new System.Drawing.Size(80, 49);
            this.callingShelf6.TabIndex = 47;
            // 
            // callingShelf4
            // 
            this.callingShelf4.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf4.Location = new System.Drawing.Point(229, 554);
            this.callingShelf4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf4.Name = "callingShelf4";
            this.callingShelf4.Size = new System.Drawing.Size(80, 49);
            this.callingShelf4.TabIndex = 47;
            // 
            // callingShelf7
            // 
            this.callingShelf7.BackColor = System.Drawing.Color.Transparent;
            this.callingShelf7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callingShelf7.Location = new System.Drawing.Point(333, 622);
            this.callingShelf7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callingShelf7.Name = "callingShelf7";
            this.callingShelf7.Size = new System.Drawing.Size(80, 49);
            this.callingShelf7.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(390, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 47);
            this.label1.TabIndex = 61;
            this.label1.Text = "Calling Numbers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(635, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 47);
            this.label2.TabIndex = 62;
            this.label2.Text = "Descriptions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdentifyAreasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.part2background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnReset);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IdentifyAreasUserControl";
            this.Size = new System.Drawing.Size(1333, 844);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
