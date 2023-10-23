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
        //-------------------------------------------------------------------------------------------//
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

        //-------------------------------------------------------------------------------------------//

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

        //-------------------------------------------------------------------------------------------//

        private Dictionary<string, string> leftShelfGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, string> descriptionShelfGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, string> randomlyChosencallNumberDescriptions = new Dictionary<string, string>();

        private Dictionary<string, Point> originalRightShelfLocations = new Dictionary<string, Point>();
        private Dictionary<string, bool> rightShelfOccupancyStatus = new Dictionary<string, bool>();

        //-------------------------------------------------------------------------------------------//

        public IdentifyAreasUserControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------//

        private void IdentifyAreasUserControl_Load(object sender, EventArgs e)
        {
            GenerateRandomListings();

            btnReset.Enabled = false;
            btnRestart.Enabled = false;
            lblTimer.Text = "Timer: 0 seconds";
        }

        //-------------------------------------------------------------------------------------------//

        private void GenerateRandomListings()
        {
            RandomlySelectItems();
            CreateLabelsForLeftShelf();
            CreateLabelsForDescriptionShelf();

            StoreRightShlfProperties();

        }

        //-------------------------------------------------------------------------------------------//
        // Method to randomly select 7 key-value pairs
        private void RandomlySelectItems()
        {
            Random random = new Random();
            List<KeyValuePair<string, string>> items = callNumberDescriptions.ToList();

            // Shuffle the items to get a random order
            for (int i = 0; i < items.Count - 1; i++)
            {
                int j = random.Next(i, items.Count);
                var temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }

            // Select the first 7 items and add them to the randomlyChosencallNumberDescriptions dictionary
            for (int i = 0; i < 7; i++)
            {
                randomlyChosencallNumberDescriptions.Add(items[i].Key, items[i].Value);
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void CreateLabelsForLeftShelf()
        {
            List<string> callNumbers = randomlyChosencallNumberDescriptions.Keys.ToList();
            Random random = new Random();

            for (int i = 0; i <= 3; i++)
            {
                int randomIndex = random.Next(callNumbers.Count);
                string callNumber = callNumbers[randomIndex];
                callNumbers.RemoveAt(randomIndex);

                Panel leftShelf = Controls.Find($"leftShelf{i}", true).FirstOrDefault() as Panel;

                leftShelf.BackColor = Color.Silver;

                Label leftShelfLabel = new Label();
                leftShelfLabel.Text = callNumber;
                leftShelfLabel.TextAlign = ContentAlignment.MiddleCenter;
                leftShelfLabel.Size = new Size(60, 40);

                leftShelfLabel.Dock = DockStyle.Bottom;
                leftShelfLabel.BorderStyle = BorderStyle.FixedSingle;
                leftShelfLabel.BackColor = Color.Orange;
                leftShelfLabel.AutoSize = false;

                leftShelf.Controls.Add(leftShelfLabel);

                leftShelfGeneratedOrder.Add(leftShelf.Name, leftShelfLabel.Text);
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void CreateLabelsForDescriptionShelf()
        {
            List<string> descriptionTexts = randomlyChosencallNumberDescriptions.Values.ToList();
            Random random = new Random();

            for (int i = 0; i <= 6; i++)
            {
                int randomIndex = random.Next(descriptionTexts.Count);
                string descriptionText = descriptionTexts[randomIndex];
                descriptionTexts.RemoveAt(randomIndex);

                Panel descriptionShelf = Controls.Find($"descriptionShelf{i}", true).FirstOrDefault() as Panel;

                descriptionShelf.BackColor = Color.Silver;

                Label descriptionShelfLabel = new Label();
                descriptionShelfLabel.Text = descriptionText;
                descriptionShelfLabel.TextAlign = ContentAlignment.MiddleCenter;
                descriptionShelfLabel.Size = new Size(60, 40);

                descriptionShelfLabel.Dock = DockStyle.Bottom;
                descriptionShelfLabel.BorderStyle = BorderStyle.FixedSingle;
                descriptionShelfLabel.BackColor = Color.Orange;
                descriptionShelfLabel.AutoSize = false;

                descriptionShelf.Controls.Add(descriptionShelfLabel);

                descriptionShelfGeneratedOrder.Add(descriptionShelf.Name, descriptionShelfLabel.Text);
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// This method iterates through all the top shelves with the
        /// names starting with topShelf followed by a integer.
        /// The properties are added to the corresponding 
        /// dictionaries.
        /// </summary>
        private void StoreRightShlfProperties()
        {
            for (int i = 0; i <= 3; i++)
            {
                Panel rightShelfPanel = Controls.Find($"rightShelf{i}", true).FirstOrDefault() as Panel;

                if (rightShelfPanel != null)
                {
                    originalRightShelfLocations[$"rightShelf{i}"] = rightShelfPanel.Location;

                    rightShelfOccupancyStatus[$"rightShelf{i}"] = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

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

        //-------------------------------------------------------------------------------------------//

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

        //-------------------------------------------------------------------------------------------//

        private void btnResults_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------//

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------//

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// As the timer ticks, the label holding the time
        /// will be updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void identifyAreas_timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = $"Timer: {seconds} seconds";
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Getting the time it took for the user
        /// to complete the game.
        /// </summary>
        /// <returns></returns>
        private TimeSpan GetTimeTaken()
        {
            return TimeSpan.FromSeconds(seconds);
        }

        //-------------------------------------------------------------------------------------------//
    }
}
