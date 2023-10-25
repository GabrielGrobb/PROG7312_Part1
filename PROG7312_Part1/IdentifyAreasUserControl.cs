using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int score = 0;
        private IdentifyAreasHelperClass helper;
        private Control.ControlCollection controls;
        private int randomNumber;
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
        private Panel selectedPanel;
        private List<string> books = new List<string>();

        /// <summary>
        /// A boolean array to check if the top shelf is occupied.
        /// </summary>
        private bool[] bottomShelfOccupancyStatus = new bool[7]; // Assuming you have 7 top shelf panels
        //-------------------------------------------------------------------------------------------//

        Dictionary<string, string> callNumberDescriptions = new Dictionary<string, string>
        {
            { "000", "Generalities" }, { "100", "Philosophy" }, { "200", "Religion" },
            { "300", "Social Sciences" }, { "400", "Language" }, { "500", "Natural Sciences and Mathematics" },
            { "600", "Technology" }, { "700", "Arts and Recreation" }, { "800", "Literature" },
            { "900", "History and Geography" }
        };

        //-------------------------------------------------------------------------------------------//

        private Dictionary<string, string> ExpectedOrder = new Dictionary<string, string>();
        private Dictionary<string, string> topShelfGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, string> bottomShelfGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, string> randomlyChosencallNumberDescriptions = new Dictionary<string, string>();
        private Dictionary<string, string> randomlyChosenDescriptionsCallNumbers = new Dictionary<string, string>();

        private Dictionary<string, Point> originalTopShelfLocations = new Dictionary<string, Point>();
        private Dictionary<Panel, Point> originalBottomShelfLocations = new Dictionary<Panel, Point>();

        private Dictionary<string, bool> topShelfOccupancyStatus = new Dictionary<string, bool>();
        private Dictionary<string, string> bottomShelfToTopShelfMap = new Dictionary<string, string>();

        //-------------------------------------------------------------------------------------------//

        public IdentifyAreasUserControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------//

        private void IdentifyAreasUserControl_Load(object sender, EventArgs e)
        {
            GenerateRandomListings(Controls);

            btnReset.Enabled = false;
            lblTimer.Text = "Timer: 0 seconds";
        }

        //-------------------------------------------------------------------------------------------//

        private void GenerateRandomListings(Control.ControlCollection controls)
        {
            var helper = new IdentifyAreasHelperClass(randomlyChosencallNumberDescriptions, randomlyChosenDescriptionsCallNumbers,
                topShelfGeneratedOrder, bottomShelfGeneratedOrder, originalBottomShelfLocations, originalTopShelfLocations,
                topShelfOccupancyStatus, books);

            Random random = new Random();
            randomNumber = random.Next(2); // Generates either 0 or 1

            if (randomNumber == 0)
            {
                lblCallingNumbers.Visible = false;
                RandomlySelectItems();
                helper.CreateLabelsForTopLeftShelf(controls);
                helper.CreateLabelsForDescriptionShelf(controls);
                helper.StoreTopRightShelfProperties(controls);

                foreach (var kvp in topShelfGeneratedOrder)
                {
                    if (randomlyChosencallNumberDescriptions.TryGetValue(kvp.Value, out string description))
                    {
                        // Replace 'description' with the description panel name
                        string bottomPanelName = GetMatchingDescriptionPanelName(description);
                        ExpectedOrder[$"rightShelf{kvp.Key.Substring(9)}"] = bottomPanelName;
                    }
                }

            }
            else
            {
                lblDescription.Visible = false;
                RandomlySelectItems();
                helper.CreateLabelsForRightShelf(controls);
                helper.CreateLabelsForCallingNumberShelf(controls);
                helper.StoreLeftShelfProperties(controls);

                foreach (var kvp in topShelfGeneratedOrder)
                {
                    if (randomlyChosenDescriptionsCallNumbers.TryGetValue(kvp.Value, out string callingNumber))
                    {
                        // Replace 'description' with the description panel name
                        string bottomPanelName = GetMatchingDescriptionPanelName(callingNumber);
                        ExpectedOrder[$"leftShelf{kvp.Key.Substring(10)}"] = bottomPanelName;
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        // Add this method to get the matching description panel number
        private string GetMatchingDescriptionPanelName(string description)
        {
            foreach (var kvp in bottomShelfGeneratedOrder)
            {
                if (kvp.Value == description)
                {
                    return kvp.Key;
                }
            }
            return null; // Handle the case where no matching description panel is found
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
                randomlyChosenDescriptionsCallNumbers.Add(items[i].Value, items[i].Key);
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
                selectedPanel = sender as Panel;
                ControlExtension.Draggable(sender as Panel, true);
                selectedPanel.BringToFront();
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
            if (e.Button == MouseButtons.Right)
            {
                selectedPanel = sender as Panel;
                ControlExtension.Draggable(sender as Panel, true);
                selectedPanel.BringToFront();
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
            if (selectedPanel == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                PanelLeftClick();
            }
            else if (e.Button == MouseButtons.Right)
            {
                PanelRightClick();
            }
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
        private void PanelLeftClick()
        {
            Panel closestRightShelf = FindClosestTopShelf(selectedPanel);

            if (closestRightShelf == null)
            {
                return;
            }

            string topShelfName = closestRightShelf.Name;

            if (IsTopShelfOccupied(topShelfName))
            {
                return;
            }

            if (selectedPanel.Tag is Panel prevTopShelf)
            {
                string prevTopShelfName = prevTopShelf.Name;
                topShelfOccupancyStatus[prevTopShelfName] = false;
            }

            int newX = closestRightShelf.Left + (closestRightShelf.Width - selectedPanel.Width) / 2;
            int newY = closestRightShelf.Top + (closestRightShelf.Height - selectedPanel.Height) / 2;
            selectedPanel.Location = new Point(newX, newY);

            topShelfOccupancyStatus[topShelfName] = true;

            selectedPanel.Tag = closestRightShelf;

            bottomShelfToTopShelfMap[closestRightShelf.Name] = selectedPanel.Name;

            if (AllRightShelfOccupied())
            {
                CheckScoreAndShowMessageBox();
                score = 0;
                
            }
            else 
            {
                return;
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// This method is called when the right mouse button is clicked.
        /// When a book is clicked on, it will return to its originally
        /// generated panel. The top panel without a book will become unoccupied.
        /// The book recieves it's original location.
        /// </summary>
        private void PanelRightClick()
        {
            if (!originalBottomShelfLocations.TryGetValue(selectedPanel, out Point originalLocation))
            {
                return;
            }

            selectedPanel.Location = originalLocation;
            int index = GetBottomShelfIndex(selectedPanel);
            bottomShelfOccupancyStatus[index] = true;

            if (!(selectedPanel.Tag is Panel prevTopShelf))
            {
                return;
            }

            string prevTopShelfName = prevTopShelf.Name;
            topShelfOccupancyStatus[prevTopShelfName] = false;

            bottomShelfToTopShelfMap.Remove(prevTopShelfName);

            selectedPanel.Tag = null;
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// A boolean method to return if a top shelf panel
        /// is occupied by a book.
        /// </summary>
        /// <param name="topShelfName"></param>
        /// <returns></returns>
        private bool IsTopShelfOccupied(string topShelfName)
        {
            return topShelfOccupancyStatus.ContainsKey(topShelfName) && topShelfOccupancyStatus[topShelfName];
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// A method of type Panel to calculate the center points
        /// of a book and find the nearest open top shelf.
        /// </summary>
        /// <param name="bottomShelfPanel">closest avaliable top shelf panel</param>
        /// <returns></returns>
        private Panel FindClosestTopShelf(Panel bottomShelfPanel)
        {
            Point bottomCenter = Class1.CalculateCenter(bottomShelfPanel);
            _ = new Panel();
            Panel closestTopShelf;
            if (randomNumber == 0)
            {
                closestTopShelf = FindClosestUnoccupiedRightShelf(bottomCenter);
            }
            else
            {
                closestTopShelf = FindClosestUnoccupiedLeftShelf(bottomCenter);
            }


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
                int index = GetTopShelfIndex(rightShelfPanel);

                if (topShelfOccupancyStatus.ContainsKey(rightShelfName) && topShelfOccupancyStatus[rightShelfName])
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

        private Panel FindClosestUnoccupiedLeftShelf(Point bottomCenter)
        {
            Panel closestTopShelf = null;
            double closestDistance = double.MaxValue;

            foreach (Control control in Controls)
            {
                if (!(control is Panel leftShelfPanel) || !leftShelfPanel.Name.StartsWith("leftShelf"))
                    continue;

                string leftShelfName = leftShelfPanel.Name;
                int index = GetTopShelfIndex(leftShelfPanel);

                if (topShelfOccupancyStatus.ContainsKey(leftShelfName) && topShelfOccupancyStatus[leftShelfName])
                    continue;

                Point topCenter = Class1.CalculateCenter(leftShelfPanel);

                double distance = Class1.CalculateDistance(bottomCenter, topCenter);

                if (distance < closestDistance)
                {
                    closestTopShelf = leftShelfPanel;
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
        private int GetTopShelfIndex(Panel topShelfPanel)
        {
            int index = int.Parse(Regex.Match(topShelfPanel.Name, @"\d+").Value) - 1;
            return index;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds and returns the index of the bottom shelf panel
        /// </summary>
        /// <param name="bottomShelfPanel"></param>
        /// <returns></returns>
        private int GetBottomShelfIndex(Panel bottomShelfPanel)
        {
            int index = int.Parse(Regex.Match(bottomShelfPanel.Name, @"\d+").Value) - 1;
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

        private bool AllRightShelfOccupied()
        {
            // Check if all boolean values in the dictionary are true
            return topShelfOccupancyStatus.Values.All(value => value);
        }

        //-------------------------------------------------------------------------------------------//

        private void CheckScoreAndShowMessageBox()
        {
            identifyAreas_timer.Stop();
            btnReset.Enabled = true;
            btnStart.Enabled = false;
            btnPause.Enabled = false;
            btnResume.Enabled = false;

            if (randomNumber == 0)
            {
                RemoveDescriptionPanelControls();
            }
            else
            {
                RemoveCallingNumberPanelControls();
            }

            foreach (var kvp in ExpectedOrder)
            {
                if (bottomShelfToTopShelfMap.TryGetValue(kvp.Key, out string descriptionPanelName) &&
                    ExpectedOrder.TryGetValue(kvp.Key, out string expectedDescription))
                {
                    if (bottomShelfToTopShelfMap.TryGetValue(kvp.Key, out string descriptionText))
                    {
                        if (descriptionText == expectedDescription)
                        {
                            score++; // Increment the score if there's a match
                        }
                    }
                }
            }
            // Display a message box with the score
            MessageBox.Show($"Your Score! Your score is {score} out of 4.", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------//

        private void RemoveDescriptionPanelControls() 
        {
            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown -= IdentifyAreasControl_MouseDown;
                bottomShelfPanel.MouseUp -= IdentifyAreasControl_MouseUp;
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void RemoveCallingNumberPanelControls()
        {
            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("callingShelf")))
            {

                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown -= IdentifyAreasControl_MouseDown;
                bottomShelfPanel.MouseUp -= IdentifyAreasControl_MouseUp;
            }
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

            if (randomNumber == 0)
            {
                DescriptionGeneration();
            }
            else 
            {
                CallNumbersGeneration();
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void DescriptionGeneration() 
        {
            RemoveDescriptionPanelControls();

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

        private void CallNumbersGeneration()
        {
            RemoveCallingNumberPanelControls();

            for (int i = 1; i <= books.Count; i++)
            {
                Panel callingShelf = Controls.Find($"callingShelf{i}", true).FirstOrDefault() as Panel;

                callingShelf.MouseDown += IdentifyAreasControl_MouseDown;
                callingShelf.MouseUp += IdentifyAreasControl_MouseUp;
                callingShelf.Draggable(true);
                callingShelf.BringToFront();
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
            btnPause.Enabled = true;

            if (isTimerRunning)
            {
                seconds = 0;
                identifyAreas_timer.Stop();
                isTimerRunning = false;
                lblTimer.Text = "Timer: 0 seconds";
            }

            if (randomNumber == 0)
            {
                DescriptionGenerationReset();
            }
            else
            {
                CallingNumbersGenerationReset();
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void DescriptionGenerationReset() 
        {
            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {

                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown -= IdentifyAreasControl_MouseDown;
                bottomShelfPanel.MouseUp -= IdentifyAreasControl_MouseUp;

                if (!originalBottomShelfLocations.TryGetValue(bottomShelfPanel, out Point originalLocation))
                {
                    continue;
                }

                bottomShelfPanel.Location = originalLocation;

                int index = GetBottomShelfIndex(bottomShelfPanel);
                bottomShelfOccupancyStatus[index] = true;

                if (bottomShelfPanel.Tag is Panel prevTopShelf)
                {
                    string prevTopShelfName = prevTopShelf.Name;

                    topShelfOccupancyStatus[prevTopShelfName] = false;

                    bottomShelfToTopShelfMap.Remove(prevTopShelfName);
                }

                bottomShelfPanel.Tag = null;
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void CallingNumbersGenerationReset() 
        {
            foreach (Panel callingNumberShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("callingShelf")))
            {

                ControlExtension.Draggable(callingNumberShelfPanel, false);

                callingNumberShelfPanel.MouseDown -= IdentifyAreasControl_MouseDown;
                callingNumberShelfPanel.MouseUp -= IdentifyAreasControl_MouseUp;

                if (!originalBottomShelfLocations.TryGetValue(callingNumberShelfPanel, out Point originalLocation))
                {
                    continue;
                }

                callingNumberShelfPanel.Location = originalLocation;

                int index = GetBottomShelfIndex(callingNumberShelfPanel);
                bottomShelfOccupancyStatus[index] = true;

                if (callingNumberShelfPanel.Tag is Panel prevTopShelf)
                {
                    string prevTopShelfName = prevTopShelf.Name;

                    topShelfOccupancyStatus[prevTopShelfName] = false;

                    bottomShelfToTopShelfMap.Remove(prevTopShelfName);
                }

                callingNumberShelfPanel.Tag = null;
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

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnResume.Enabled = true;
            btnPause.Enabled = false;
            if (isTimerRunning)
            {
                identifyAreas_timer.Stop();
                isTimerRunning = false;
            }
            if (randomNumber == 0)
            {
                RemoveDescriptionPanelControls();
            }
            else
            {
                RemoveCallingNumberPanelControls();
            }
        }

        //-------------------------------------------------------------------------------------------//
        private void btnResume_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            if (!isTimerRunning)
            {
                identifyAreas_timer.Start();
                seconds = seconds++ -1;
                isTimerRunning = true;
            }

            if (randomNumber == 0) 
            {
                CreateDescriptionPanelControls();
            }
            else
            {
                CreateCallingNumberPanelControls();
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void CreateDescriptionPanelControls()
        {
            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown += IdentifyAreasControl_MouseDown;
                bottomShelfPanel.MouseUp += IdentifyAreasControl_MouseUp;
            }
        }

        //-------------------------------------------------------------------------------------------//

        private void CreateCallingNumberPanelControls()
        {
            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("callingShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown += IdentifyAreasControl_MouseDown;
                bottomShelfPanel.MouseUp += IdentifyAreasControl_MouseUp;
            }
        }

        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//