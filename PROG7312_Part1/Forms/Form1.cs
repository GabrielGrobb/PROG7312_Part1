using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// The audio is played when the application is launched.
        /// The buttons are disabled.
        /// After the audio has stoped, the buttons will be enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            FormIntroAudio();

            DisableButtons();

            MXP.PlayStateChange += MXP_PlayStateChange;
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// ICT (2022) the windows media player is used to play the intro
        /// of the application.
        /// </summary>

        private void FormIntroAudio()
        {
            // Set the audio file URL and configuration
            MXP.URL = @"audio\\Jigsaw.mp3";
            MXP.settings.playCount = 1;
            MXP.Visible = false;
            MXP.settings.volume = 20;
            MXP.Ctlcontrols.play();
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        ///  Disabling the buttons.
        /// </summary>
        private void DisableButtons()
        {
            btnReplacingBooks.Enabled = false;
            btnIdentifyAreas.Enabled = false;
            btnCallNumbers.Enabled = false;
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Starting the progress time for the progress bar when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplacingBooks_Click(object sender, EventArgs e)
        {
            progressTimer.Start();
            BookForm myBookForm = new BookForm();
            myBookForm.Show();

            this.Hide();
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// When the audio stops the buttons will become active.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MXP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                btnReplacingBooks.Enabled = true;
                btnIdentifyAreas.Enabled = true;
                btnCallNumbers.Enabled = true;
            }
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        ///  The progress bar percentage updates while the timer ticks (RashiCode, 2020). 
        ///  Adding graphics to the progress bar while it loads.
        ///  When the maximum value is reached; the timer will stop.
        ///  The BookForm is intialized and displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            pgDataLoad.Increment(2);
            int per = (int)(((double)(pgDataLoad.Value - pgDataLoad.Minimum) /
            (double)(pgDataLoad.Maximum - pgDataLoad.Minimum)) * 100);
            using (Graphics graphics = pgDataLoad.CreateGraphics())
            {
                graphics.DrawString(per.ToString() + "% Loaded", SystemFonts.DefaultFont, Brushes.Black,
                new PointF(pgDataLoad.Width / 2 - (graphics.MeasureString(per.ToString() + "%",
                SystemFonts.DefaultFont).Width / 2.0F),
                pgDataLoad.Height / 2 - (graphics.MeasureString(per.ToString() + "%",
                SystemFonts.DefaultFont).Height / 2.0F)));
            }

            if (pgDataLoad.Value >= pgDataLoad.Maximum)
            {
                progressTimer.Stop();
            }

        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// This button, the exit button closes the application entirely.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Navigate to Identifying areas game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIdentifyAreas_Click(object sender, EventArgs e)
        {
            progressTimer.Start();
            this.ParentForm.Close();
            IdentifyAreasForm myIdentifyAreasForm = new IdentifyAreasForm();
            myIdentifyAreasForm.Show();

            this.Hide();
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Navigate to calling numbers game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallNumbers_Click(object sender, EventArgs e)
        {
            progressTimer.Start();
            
            CallNumbersForm myCallingNumbersForm = new CallNumbersForm();
            myCallingNumbersForm.Show();

            //this.Close();
            this.Hide();
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// An event for when the form is closing.
        /// This will terminate the application.
        /// All threads will be removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        //------------------------------------------------------------------------------------------//
    }
}
//------------------------------------------EndOfFile-----------------------------------------------//


#region /// REFERENCES - CODE ATTRIBUTION:
/* 
 * 
Aurthor:  RashiCode
Webisite: YouTube, 2020/03/27. How to use progress bar in c# win form app c# Tube. [Online]
Accessed on: 2023/09/26
URL:https://rashicode.com/progress-bar-in-csharp-winforms-application/

Aurthor:  Moo ICT
Webisite: YouTube, 2022/05/23. C# Tutorial - Play Multiple Audio files together in windows form and visual studio. [Online]
Accessed on: 2023/09/26
URL:https://www.youtube.com/watch?v=Ch7yY3ti_aI&t=297s

 */
#endregion