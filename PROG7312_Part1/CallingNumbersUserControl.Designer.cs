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
            this.txtDescription = new System.Windows.Forms.TextBox();
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
            this.btnStart = new PROG7312_Part1.CustomButton();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(371, 86);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(132, 34);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(509, 86);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(343, 34);
            this.txtDescription.TabIndex = 1;
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.Location = new System.Drawing.Point(297, 164);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(14, 13);
            this.rdoOption1.TabIndex = 3;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.UseVisualStyleBackColor = true;
            this.rdoOption1.Click += new System.EventHandler(this.rdoOption1_Click);
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.Location = new System.Drawing.Point(461, 164);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(14, 13);
            this.rdoOption2.TabIndex = 4;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.UseVisualStyleBackColor = true;
            this.rdoOption2.Click += new System.EventHandler(this.rdoOption2_Click);
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.Location = new System.Drawing.Point(614, 164);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(14, 13);
            this.rdoOption3.TabIndex = 5;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.UseVisualStyleBackColor = true;
            this.rdoOption3.Click += new System.EventHandler(this.rdoOption3_Click);
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.Location = new System.Drawing.Point(754, 164);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(14, 13);
            this.rdoOption4.TabIndex = 6;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.UseVisualStyleBackColor = true;
            this.rdoOption4.Click += new System.EventHandler(this.rdoOption4_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTimer.Location = new System.Drawing.Point(509, 24);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(277, 34);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captionPanel1
            // 
            this.captionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel1.Location = new System.Drawing.Point(264, 195);
            this.captionPanel1.Name = "captionPanel1";
            this.captionPanel1.Size = new System.Drawing.Size(80, 150);
            this.captionPanel1.TabIndex = 8;
            // 
            // captionPanel2
            // 
            this.captionPanel2.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel2.Location = new System.Drawing.Point(423, 195);
            this.captionPanel2.Name = "captionPanel2";
            this.captionPanel2.Size = new System.Drawing.Size(80, 150);
            this.captionPanel2.TabIndex = 9;
            // 
            // captionPanel3
            // 
            this.captionPanel3.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel3.Location = new System.Drawing.Point(581, 195);
            this.captionPanel3.Name = "captionPanel3";
            this.captionPanel3.Size = new System.Drawing.Size(80, 150);
            this.captionPanel3.TabIndex = 10;
            // 
            // captionPanel4
            // 
            this.captionPanel4.BackColor = System.Drawing.Color.Transparent;
            this.captionPanel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.captionPanel4.Location = new System.Drawing.Point(721, 195);
            this.captionPanel4.Name = "captionPanel4";
            this.captionPanel4.Size = new System.Drawing.Size(80, 150);
            this.captionPanel4.TabIndex = 11;
            // 
            // callingNumbersTimer
            // 
            this.callingNumbersTimer.Interval = 1000;
            this.callingNumbersTimer.Tick += new System.EventHandler(this.callingNumbersTimer_Tick);
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
            this.btnStart.Location = new System.Drawing.Point(353, 18);
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
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Name = "CallingNumbersUserControl";
            this.Size = new System.Drawing.Size(1071, 617);
            this.Load += new System.EventHandler(this.CallingNumbersUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
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
    }
}
