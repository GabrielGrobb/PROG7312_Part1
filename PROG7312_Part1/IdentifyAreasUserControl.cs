using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
        private List<string> books = new List<string>();

        /// <summary>
        /// A boolean array to check if the top shelf is occupied.
        /// </summary>
        private bool[] bottomShelfOccupancyStatus = new bool[7]; // Assuming you have 7 top shelf panels
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

        private Dictionary<string, KeyValuePair<string, string>> correctOrderStructure = new Dictionary<string, KeyValuePair<string, string>>();

        private Dictionary<string, string> leftShelfGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, string> descriptionShelfGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, string> randomlyChosencallNumberDescriptions = new Dictionary<string, string>();

        private Dictionary<string, Point> originalRightShelfLocations = new Dictionary<string, Point>();
        private Dictionary<Panel, Point> originalDescriptionShelfLocations = new Dictionary<Panel, Point>();

        private Dictionary<string, bool> rightShelfOccupancyStatus = new Dictionary<string, bool>();
        private Dictionary<string, string> descriptionShelfLabelToRightShelfMap = new Dictionary<string, string>();

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

            for (int i = 1; i < 5; i++)
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

            for (int i = 1; i <= 7; i++)
            {
                
                int randomIndex = random.Next(descriptionTexts.Count);
                string descriptionText = descriptionTexts[randomIndex];
                descriptionTexts.RemoveAt(randomIndex);

                Panel descriptionShelf = Controls.Find($"descriptionShelf{i}", true).FirstOrDefault() as Panel;

                originalDescriptionShelfLocations[descriptionShelf] = descriptionShelf.Location;

                descriptionShelf.BackColor = Color.Silver;

                Label descriptionShelfLabel = new Label();
                descriptionShelfLabel.Text = descriptionText;
                descriptionShelfLabel.TextAlign = ContentAlignment.MiddleCenter;
                descriptionShelfLabel.Size = new Size(60, 40);

                descriptionShelfLabel.Dock = DockStyle.Bottom;
                descriptionShelfLabel.BorderStyle = BorderStyle.FixedSingle;
                descriptionShelfLabel.BackColor = Color.Orange;
                descriptionShelfLabel.AutoSize = false;
                descriptionShelfLabel.Enabled = false;

                books.Add(descriptionShelfLabel.Text);

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
            for (int i = 1; i <= 4; i++)
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

        /// <summary>
        /// This event executes when the mouse button is clicked
        /// and not relased. It handles when either the left or 
        /// right button is clicked. 
        /// </summary>
        /// <param name="sender">Refers to the clicked on panel being dragged and brought to front.</param>
        /// <param name="e">Refers to the mouse button clicked</param>
        private void IdentifyAreasControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedDescriptionPanel = sender as Panel;
                ControlExtension.Draggable(sender as Panel, true);
                selectedDescriptionPanel.BringToFront();
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
            if (e.Button == MouseButtons.Right)
            {
                selectedDescriptionPanel = sender as Panel;
                ControlExtension.Draggable(sender as Panel, true);
                selectedDescriptionPanel.BringToFront();
                this.DoubleBuffered = true;
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// This event executes when the mouse button is released.
        /// It handles when either the left or right button is released.
        /// If a panel is not selected, nothing will occur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdentifyAreasControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedDescriptionPanel == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                DescriptionPanelLeftClick();
            }
            else if (e.Button == MouseButtons.Right)
            {
                DescriptionPanelRightClick();
            }

            // Check if all values in the rightShelfOccupancyStatus dictionary are true
            /*bool allRightShelfOccupied = rightShelfOccupancyStatus.All(kvp => kvp.Value);

            if (allRightShelfOccupied)
            {
                // Perform validation based on correctOrderStructure
                int score = 0;

                foreach (var entry in correctOrderStructure)
                {
                    string rightShelfPanelName = entry.Key;
                    string expectedCallNumber = entry.Value.Key;
                    string expectedDescription = entry.Value.Value;

                    // Find the right shelf panel
                    Panel rightShelfPanel = Controls.Find(rightShelfPanelName, true).FirstOrDefault() as Panel;

                    // Find the corresponding description panel in the right shelf panel
                    Panel descriptionPanelInRightShelf = rightShelfPanel.Controls.OfType<Panel>().FirstOrDefault();

                    if (descriptionPanelInRightShelf != null)
                    {
                        string actualDescription = descriptionPanelInRightShelf.Controls.OfType<Label>().FirstOrDefault()?.Text;

                        // Compare the actual description with the expected description
                        if (actualDescription == expectedDescription)
                        {
                            score++; // Increment the score for a correct placement
                        }
                    }
                }

                // Display the score in a message box
                MessageBox.Show($"Your Score: {score}/{correctOrderStructure.Count}");
            }*/

        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// This method is called when the left mouse button is clicked.
        /// When a book is clicked on, dependent on where; it will locate the
        /// closest top panel. The top panel with a book will become occupied.
        /// The book recieves a the top shelf panel location
        /// The book and the top shelf panel are mapped together.
        /// </summary>
        private void DescriptionPanelLeftClick()
        {
            Panel closestRightShelf = FindClosestRightShelf(selectedDescriptionPanel);

            if (closestRightShelf == null)
            {
                return;
            }

            string topShelfName = closestRightShelf.Name;

            if (IsTopShelfOccupied(topShelfName))
            {
                return;
            }

            if (selectedDescriptionPanel.Tag is Panel prevTopShelf)
            {
                string prevTopShelfName = prevTopShelf.Name;
                rightShelfOccupancyStatus[prevTopShelfName] = false;
            }

            int newX = closestRightShelf.Left + (closestRightShelf.Width - selectedDescriptionPanel.Width) / 2;
            int newY = closestRightShelf.Top + (closestRightShelf.Height - selectedDescriptionPanel.Height) / 2;
            selectedDescriptionPanel.Location = new Point(newX, newY);

            rightShelfOccupancyStatus[topShelfName] = true;

            selectedDescriptionPanel.Tag = closestRightShelf;

            descriptionShelfLabelToRightShelfMap[closestRightShelf.Name] = selectedDescriptionPanel.Name;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// This method is called when the right mouse button is clicked.
        /// When a book is clicked on, it will return to its originally
        /// generated panel. The top panel without a book will become unoccupied.
        /// The book recieves it's original location.
        /// </summary>
        private void DescriptionPanelRightClick()
        {
            if (!originalDescriptionShelfLocations.TryGetValue(selectedDescriptionPanel, out Point originalLocation))
            {
                return;
            }

            selectedDescriptionPanel.Location = originalLocation;
            int index = GetBottomShelfIndex(selectedDescriptionPanel);
            bottomShelfOccupancyStatus[index] = true;

            if (!(selectedDescriptionPanel.Tag is Panel prevTopShelf))
            {
                return;
            }

            string prevTopShelfName = prevTopShelf.Name;
            rightShelfOccupancyStatus[prevTopShelfName] = false;

            descriptionShelfLabelToRightShelfMap.Remove(prevTopShelfName);

            selectedDescriptionPanel.Tag = null;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// A boolean method to return if a top shelf panel
        /// is occupied by a book.
        /// </summary>
        /// <param name="topShelfName"></param>
        /// <returns></returns>
        private bool IsTopShelfOccupied(string rightShelfName)
        {
            return rightShelfOccupancyStatus.ContainsKey(rightShelfName) && rightShelfOccupancyStatus[rightShelfName];
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// A method of type Panel to calculate the center points
        /// of a book and find the nearest open top shelf.
        /// </summary>
        /// <param name="bottomShelfPanel">closest avaliable top shelf panel</param>
        /// <returns></returns>
        private Panel FindClosestRightShelf(Panel descriptionShelfPanel)
        {
            Point bottomCenter = Class1.CalculateCenter(descriptionShelfPanel);

            Panel closestTopShelf = FindClosestUnoccupiedRightShelf(bottomCenter);

            return closestTopShelf;
        }
        //-------------------------------------------------------------------------------------------//
        /// <summary>
        /// Used ChatGPT here.
        /// Iterates through all the top shelf panels.
        /// Finds the closest and unoccupied panel.
        /// checks if the distance is more than the closest distance
        /// between the top and bottom panels.
        /// </summary>
        /// <param name="bottomCenter"></param>
        /// <returns></returns>
        private Panel FindClosestUnoccupiedRightShelf(Point bottomCenter)
        {
            Panel closestTopShelf = null;
            double closestDistance = double.MaxValue;

            foreach (Control control in Controls)
            {
                if (!(control is Panel rightShelfPanel) || !rightShelfPanel.Name.StartsWith("rightShelf"))
                    continue;

                string rightShelfName = rightShelfPanel.Name;
                int index = GetRightShelfIndex(rightShelfPanel);

                if (rightShelfOccupancyStatus.ContainsKey(rightShelfName) && rightShelfOccupancyStatus[rightShelfName])
                    continue;

                Point topCenter = Class1.CalculateCenter(rightShelfPanel);

                double distance = Class1.CalculateDistance(bottomCenter, topCenter);

                if (distance < closestDistance)
                {
                    closestTopShelf = rightShelfPanel;
                    closestDistance = distance;
                }
            }

            return closestTopShelf;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds and returns the index of the top shelf panel
        /// </summary>
        /// <param name="topShelfPanel"></param>
        /// <returns></returns>
        private int GetRightShelfIndex(Panel rightShelfPanel)
        {
            int index = int.Parse(Regex.Match(rightShelfPanel.Name, @"\d+").Value) - 1;
            return index;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds and returns the index of the bottom shelf panel
        /// </summary>
        /// <param name="bottomShelfPanel"></param>
        /// <returns></returns>
        private int GetBottomShelfIndex(Panel descriptionShelfPanel)
        {
            int index = int.Parse(Regex.Match(descriptionShelfPanel.Name, @"\d+").Value) - 1;
            return index;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnRestart.Enabled = false;

            foreach (Panel descriptionShelf in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {
                descriptionShelf.MouseDown -= IdentifyAreasControl_MouseDown;
                descriptionShelf.MouseUp -= IdentifyAreasControl_MouseUp;
            }

            for (int i = 1; i <= books.Count; i++)
            {
                Panel descriptionShelf = Controls.Find($"descriptionShelf{i}", true).FirstOrDefault() as Panel;

                descriptionShelf.MouseDown += IdentifyAreasControl_MouseDown;
                descriptionShelf.MouseUp += IdentifyAreasControl_MouseUp;
                descriptionShelf.Draggable(true);
                descriptionShelf.BringToFront();
            }

            if (!isTimerRunning)
            {
                identifyAreas_timer.Start();
                isTimerRunning = true;
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnStart.Enabled = true;

            seconds = 0;

            lblTimer.Text = "Timer: 0 seconds";

            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {

                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown -= IdentifyAreasControl_MouseDown;
                bottomShelfPanel.MouseUp -= IdentifyAreasControl_MouseUp;

                if (!originalDescriptionShelfLocations.TryGetValue(bottomShelfPanel, out Point originalLocation))
                {
                    continue;
                }

                bottomShelfPanel.Location = originalLocation;

                int index = GetBottomShelfIndex(bottomShelfPanel);
                bottomShelfOccupancyStatus[index] = true;

                if (bottomShelfPanel.Tag is Panel prevTopShelf)
                {
                    string prevTopShelfName = prevTopShelf.Name;

                    rightShelfOccupancyStatus[prevTopShelfName] = false;

                    descriptionShelfLabelToRightShelfMap.Remove(prevTopShelfName);
                }

                bottomShelfPanel.Tag = null;
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Display the user's score
            DialogResult myResult = MessageBox.Show("Are you sure you would like to Restart?\n" +
                "Restarting will change the labels and where the books need to be placed.\n" +
                "Click Yes to Confirm or No to Cancel."
              , "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (myResult == DialogResult.Yes)
            {
                btnReset.Enabled = false;
                btnStart.Enabled = true;

                seconds = 0;

                lblTimer.Text = "Timer: 0 seconds";
                identifyAreas_timer.Stop();

                foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
                {
                    ControlExtension.Draggable(bottomShelfPanel, false);
                    bottomShelfPanel.MouseDown -= IdentifyAreasControl_MouseDown;
                    bottomShelfPanel.MouseUp -= IdentifyAreasControl_MouseUp;
                    bottomShelfPanel.Controls.Clear();

                    originalDescriptionShelfLocations.TryGetValue(bottomShelfPanel, out Point originalLocation);
                    bottomShelfPanel.Location = originalLocation;
                    int index = GetBottomShelfIndex(bottomShelfPanel);
                    bottomShelfOccupancyStatus[index] = true;

                    rightShelfOccupancyStatus[bottomShelfPanel.Name] = false;

                    descriptionShelfLabelToRightShelfMap.Remove(bottomShelfPanel.Name);
                }

                //originalGeneratedOrder.Clear();
                //correctOrderStructure.Clear();
                books.Clear();

                GenerateRandomListings();

                btnReset.Enabled = false;
                btnRestart.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void btnResults_Click(object sender, EventArgs e)
        {
            
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
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//