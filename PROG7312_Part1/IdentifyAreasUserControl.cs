using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    public partial class IdentifyAreasUserControl : UserControl
    {
        /// <summary>
        ///  Variables:
        ///  seconds is for the timer.
        ///  isTimerRunning checks if the timer is still counting
        ///  selectedBottomShelfPanel is the selected book.
        ///  random is to generate random integers and characters.
        /// </summary>
        private int seconds = 0;
        private bool isTimerRunning = false;
        private Panel selectedDescriptionPanel;
        private Random random = new Random();

        private List<string> descriptions = new List<string>();

        Dictionary<string, string> callNumberDescriptions = new Dictionary<string, string>
        {
            { "000", "Generalities" },
            { "100", "Philosophy" },
            { "200", "Religion" },
            { "300", "Social Sciences" },
            { "400", "Language" },
            { "500", "Natural Sciences and Mathematics" },
            { "600", "Technology" },
            { "700", "Arts and Recreation" },
            { "800", "Literature" },
            { "900", "History and Geography" }
        };



        public IdentifyAreasUserControl()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // Display the user's score
            DialogResult myResult = MessageBox.Show("Are you sure you would like to return to the Main Menu?\n" +
                "Leaving will result in loss of progress.\nClick Yes to Confirm or No to Cancel."
                            , "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (myResult == DialogResult.Yes)
            {
                this.ParentForm.Close();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Opens the help form in a dialog format.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            
            using (IDAreasHelpForm helpForm = new IDAreasHelpForm())
            {
                helpForm.ShowDialog();
            }
            
        }

        private void btnResults_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
