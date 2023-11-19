namespace PROG7312_Part1
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblBestAttempt = new System.Windows.Forms.Label();
            this.lblCorrectBooks = new System.Windows.Forms.Label();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.lblBestAttemptHeading = new System.Windows.Forms.Label();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToOrderColumns = true;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvResults, "dgvResults");
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 24;
            // 
            // lblBestAttempt
            // 
            resources.ApplyResources(this.lblBestAttempt, "lblBestAttempt");
            this.lblBestAttempt.Name = "lblBestAttempt";
            // 
            // lblCorrectBooks
            // 
            resources.ApplyResources(this.lblCorrectBooks, "lblCorrectBooks");
            this.lblCorrectBooks.Name = "lblCorrectBooks";
            // 
            // lblTimeTaken
            // 
            resources.ApplyResources(this.lblTimeTaken, "lblTimeTaken");
            this.lblTimeTaken.Name = "lblTimeTaken";
            // 
            // lblBestAttemptHeading
            // 
            this.lblBestAttemptHeading.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblBestAttemptHeading, "lblBestAttemptHeading");
            this.lblBestAttemptHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBestAttemptHeading.Name = "lblBestAttemptHeading";
            // 
            // lblAttempt
            // 
            resources.ApplyResources(this.lblAttempt, "lblAttempt");
            this.lblAttempt.Name = "lblAttempt";
            // 
            // lblBooks
            // 
            resources.ApplyResources(this.lblBooks, "lblBooks");
            this.lblBooks.Name = "lblBooks";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // lblResultsTitle
            // 
            this.lblResultsTitle.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblResultsTitle, "lblResultsTitle");
            this.lblResultsTitle.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblResultsTitle.Name = "lblResultsTitle";
            // 
            // lblGame
            // 
            resources.ApplyResources(this.lblGame, "lblGame");
            this.lblGame.Name = "lblGame";
            // 
            // lblGameName
            // 
            resources.ApplyResources(this.lblGameName, "lblGameName");
            this.lblGameName.Name = "lblGameName";
            // 
            // ResultsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PROG7312_Part1.Properties.Resources.ProgStats;
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblResultsTitle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblAttempt);
            this.Controls.Add(this.lblBestAttemptHeading);
            this.Controls.Add(this.lblTimeTaken);
            this.Controls.Add(this.lblCorrectBooks);
            this.Controls.Add(this.lblBestAttempt);
            this.Controls.Add(this.dgvResults);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblBestAttempt;
        private System.Windows.Forms.Label lblCorrectBooks;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Label lblBestAttemptHeading;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblResultsTitle;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblGameName;
    }
}