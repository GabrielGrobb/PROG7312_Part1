using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    public partial class IdentifyAreasUserControl : UserControl
    {
        //-------------------------------------------------------------------------------------------//
        /// <summary>
        ///  Global Variables:
        ///  - seconds is for the timer.
        ///  - isTimerRunning checks if the timer is still counting
        ///  - selectedPanel is the selected bottom shelf panel.
        ///  - score is the end value for the user.
        ///  - random number holds either 1 or 0.
        /// </summary>
        private int seconds = 0;
        private bool isTimerRunning = false;
        private Panel selectedPanel;
        private int randomNumber;
        private string matchColumnGame = "Match Column Game";

        private List<UserResults> results = new List<UserResults>();
        private List<string> books = new List<string>();

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// A boolean array to check if the top shelf is occupied.
        /// </summary>
        private bool[] bottomShelfOccupancyStatus = new bool[7]; // Assuming you have 7 top shelf panels
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// A dictionary holding all 10 indexes for the application to select from.
        /// </summary>
        Dictionary<string, string> callNumberDescriptions = new Dictionary<string, string>
        {
            { "000", "Generalities" }, { "100", "Philosophy" }, { "200", "Religion" },
            { "300", "Social Sciences" }, { "400", "Language" }, { "500", "Natural Sciences and Mathematics" },
            { "600", "Technology" }, { "700", "Arts and Recreation" }, { "800", "Literature" },
            { "900", "History and Geography" }
        };

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Dictionaries responsible for:
        /// - The correct placement order.
        /// - The name of the top panels and their label contents.
        /// - The name of the bottom panels and their label contents.
        /// - The randomly chosen calling numbers to descriptions.
        /// - The randomly chosen descriptions to calling numbers.
        /// - The original top shelf panel locations.
        /// - The original bottom shelf panel locations.
        /// - The occupany status of the top shelf.
        /// - The placements of where the bottom shelf panel was placed on the top shelf panel.
        /// </summary>
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

        /// <summary>
        /// Initializing component
        /// </summary>
        public IdentifyAreasUserControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// On load the books are generated.
        /// Specific buttons are disabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdentifyAreasUserControl_Load(object sender, EventArgs e)
        {
            GenerateRandomListings(Controls);

            btnReset.Enabled = false;
            btnReset.Visible = false;
            btnPause.Enabled = false;
            btnPause.Visible = false;
            btnResume.Enabled = false;
            btnResume.Visible = false;
            lblTimer.Text = "Timer: 0 seconds";
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method is used to generate a random order for panels to be matched.
        /// Method is responsible for generating either the description or
        /// calling numbers matches. It is chosen randomly. 
        /// </summary>
        /// <param name="controls"></param>
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
                lblDescriptionHeading.Visible = false;
                RandomlySelectItems();
                helper.CreateLabelsForTopLeftShelf(controls);
                helper.CreateLabelsForDescriptionShelf(controls);
                helper.StoreTopRightShelfProperties(controls);

                GenerateCorrectDescriptionResults();
            }
            else
            {
                lblDescription.Visible = false;
                lblCallingNumberHeading.Visible = false;
                RandomlySelectItems();
                helper.CreateLabelsForRightShelf(controls);
                helper.CreateLabelsForCallingNumberShelf(controls);
                helper.StoreLeftShelfProperties(controls);

                GenerateCorrectCallingNumberResults();
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method is responsible for generating the correct order when
        /// descriptions have to be matched to the calling numbers
        /// fields to attain 100% for the placements.
        /// </summary>
        private void GenerateCorrectDescriptionResults() 
        {
            foreach (var kvp in topShelfGeneratedOrder)
            {
                if (randomlyChosencallNumberDescriptions.TryGetValue(kvp.Value, out string description))
                {
                    // Replace 'description' with the description panel name
                    string bottomPanelName = GetMatchingBottomPanelName(description);
                    ExpectedOrder[$"rightShelf{kvp.Key.Substring(9)}"] = bottomPanelName;
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method is responsible for generating the correct order when 
        /// calling numbers have to be matched to the description/category
        /// fields to attain 100% for the placements.
        /// </summary>
        private void GenerateCorrectCallingNumberResults()
        {
            foreach (var kvp in topShelfGeneratedOrder)
            {
                if (randomlyChosenDescriptionsCallNumbers.TryGetValue(kvp.Value, out string callingNumber))
                {
                    // Replace 'description' with the description panel name
                    string bottomPanelName = GetMatchingBottomPanelName(callingNumber);
                    ExpectedOrder[$"leftShelf{kvp.Key.Substring(10)}"] = bottomPanelName;
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method resturns the bottom panels name
        /// in a string format.
        /// Handle the case where no matching description panel is found
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        private string GetMatchingBottomPanelName(string description)
        {
            foreach (var kvp in bottomShelfGeneratedOrder)
            {
                if (kvp.Value == description)
                {
                    return kvp.Key;
                }
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to randomly select 7 key-value pairs.
        /// Shuffles the items to get a random order.
        /// Select the first 7 items and add them to the randomlyChosencallNumberDescriptions and
        /// randomlyChosenDescriptionsCallNumbers dictionaries.
        /// </summary>
        private void RandomlySelectItems()
        {
            Random random = new Random();
            List<KeyValuePair<string, string>> items = callNumberDescriptions.ToList();

            for (int i = 0; i < items.Count - 1; i++)
            {
                int j = random.Next(i, items.Count);
                var temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }

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
        /// Iterates through all the top shelf panels (right).
        /// Finds the closest and unoccupied panel.
        /// checks if the distance is more than the closest distance
        /// between the top and bottom panels.
        /// </summary>
        /// <param name="bottomCenter"></param>
        /// <returns>The closest unoccupies top panel.</returns>
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

        /// <summary>
        /// Used ChatGPT here.
        /// Iterates through all the top shelf panels (left).
        /// Finds the closest and unoccupied panel.
        /// checks if the distance is more than the closest distance
        /// between the top and bottom panels.
        /// </summary>
        /// <param name="bottomCenter"></param>
        /// <returns>The closest unoccupies top panel.</returns>
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
        /// Finds and returns the index of the top shelf panel.
        /// </summary>
        /// <param name="topShelfPanel"></param>
        /// <returns>The index of the top shelf panel</returns>
        private int GetTopShelfIndex(Panel topShelfPanel)
        {
            int index = int.Parse(Regex.Match(topShelfPanel.Name, @"\d+").Value) - 1;
            return index;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds and returns the index of the bottom shelf panel.
        /// </summary>
        /// <param name="bottomShelfPanel"></param>
        /// <returns>The index of the bottom shelf panel</returns>
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

        /// <summary>
        /// Method to check if all the top shelf panels 
        /// are occupied by a bottom shelf panel.
        /// </summary>
        /// <returns>Returns all the values as true</returns>
        private bool AllRightShelfOccupied()
        {
            // Check if all boolean values in the dictionary are true
            return topShelfOccupancyStatus.Values.All(value => value);
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// When the last panel is placed, timer will pause,
        /// Enable, disable, hide and display specific buttons.
        /// Checks what the random number variable is holding. 
        /// Foreach will itterate through the dictionaries to 
        /// check for all the matches and produce a score out of 4.
        /// </summary>
        private void CheckScoreAndShowMessageBox()
        {
            int score = CalculateScore();

            CalculateResults();

            identifyAreas_timer.Stop();
            btnReset.Enabled = true;
            btnReset.Visible = true;
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnPause.Enabled = false;
            btnPause.Visible = false;
            btnResume.Enabled = false;
            btnResume.Visible = false;

            if (randomNumber == 0)
            {
                RemoveDescriptionPanelControls();
            }
            else
            {
                RemoveCallingNumberPanelControls();
            }

            // Display a message box with the score
            MessageBox.Show($"Your Score! Your score is {score} out of 4.", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here and (Ahmed, 2018)
        /// Finding the best attempt for sorting the books.
        /// A LINQ query to sort the list of type UserResults
        /// in descending order then the duration.
        /// </summary>
        /// <param name="results">The best attempt</param>
        /// <returns></returns>
        private UserResults FindBestAttempt(List<UserResults> results)
        {
            if (results.Count == 0)
            {
                return null;
            }

            var bestAttempt = results
                .OrderByDescending(result => result.CorrectBooks)
                .ThenBy(result => result.TimeTaken)
                .First();

            return bestAttempt;
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        ///  Used ChatGPT here.
        ///  Retrieving the resukts from the user attempts.
        ///  Storing attempt number, correctly placed books,
        ///  and the time span (duration) in seconds.
        /// </summary>
        private void CalculateResults()
        {
            int correctBooks = CalculateScore();
            TimeSpan timeTaken = GetTimeTaken();
            string gameName = matchColumnGame;

            int attempt = results.Count + 1;

            results.Add(new UserResults(attempt, correctBooks, timeTaken, gameName)
            {
                Attempt = attempt,
                CorrectBooks = correctBooks,
                TimeTaken = timeTaken,
                gameName = gameName,

            });

            UserResultsManager.AddUserResults(new UserResults(attempt, correctBooks, timeTaken, gameName));
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method of type int to calculate the score.
        /// </summary>
        /// <returns>returns the users score.</returns>
        private int CalculateScore()
        {
            int score = 0;

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

            return score;
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to remove the mouse up and down events for the
        /// description shelf panels.
        /// </summary>
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

        /// <summary>
        /// Method to remove the mouse up and down events for the
        /// calling number shelf panels.
        /// </summary>
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
        /// Method to create the mouse up and down events for the
        /// description shelf panels.
        /// </summary>
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

        /// <summary>
        /// Method to create the mouse up and down events for the
        /// calling number shelf panels.
        /// </summary>
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

        /// <summary>
        /// Deactivates the start button.
        /// Activates the pause button.
        /// Checks if random number is 0 or 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnPause.Visible = true;
            btnPause.Enabled = true;

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

        /// <summary>
        /// Method removes any mouse up or down events for the panels.
        /// Itterates through the description shelf panels and adds
        /// the mouse up and down events.
        /// Allows the panels to be draggable.
        /// Brings the panels to front.
        /// Checks if the timer is not counting.
        /// </summary>
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

        /// <summary>
        /// Method removes any mouse up or down events for the panels.
        /// Itterates through the calling shelf panels and adds
        /// the mouse up and down events.
        /// Allows the panels to be draggable.
        /// Brings the panels to front.
        /// Checks if the timer is not counting.
        /// </summary>
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

        /// <summary>
        /// When the description shelf is the moveable panels;
        /// Firstly removes exsisting controls.
        /// Finds the panels orignal locations when generated.
        /// Places the panels in their orignal locations.
        /// </summary>
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

        /// When the calling number shelf is the moveable panels;
        /// Firstly removes exsisting controls.
        /// Finds the panels orignal locations when generated.
        /// Places the panels in their orignal locations.
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

        /// <summary>
        /// Reset columns button will disable pause and reset button.
        /// Enable, disable, hide and display specific buttons.
        /// Checks if the timner is counting
        /// Checks if random number is 0 or 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnReset.Visible = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;
            btnPause.Enabled = false;
            btnPause.Visible = false;

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

        /// <summary>
        /// Opens a new instance of the results form.
        /// The form will be populated with the results
        /// list of data.The the form will open in a dialog
        /// format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResults_Click(object sender, EventArgs e)
        {
            List<UserResults> allUserResults = UserResultsManager.UserResultsList;
            ResultsForm resultsForm = new ResultsForm(allUserResults);
            resultsForm.UpdateDisplay(FindBestAttempt(allUserResults));
            resultsForm.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Opens a new main menu instance when yes is clicked 
        /// on the cofirmation message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Opens the help form in a dialog format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            using (IDAreasHelpForm helpForm = new IDAreasHelpForm())
            {
                helpForm.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Allows the user to pause the game.
        /// Enable, disable, hide and display specific buttons.
        /// Checks if the timer is running and if the 
        /// random number is 0 or 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnResume.Enabled = true;
            btnResume.Visible = true;
            btnPause.Enabled = false;
            btnPause.Visible = false;

            if (isTimerRunning)
            {
                identifyAreas_timer.Stop();
                isTimerRunning = false;
            }
            if (randomNumber == 0)
            {
                lblDescription.Visible = false;
                lblCallingNumberHeading.Visible = false;
                HideDescriptionPanels();
                RemoveDescriptionPanelControls();
            }
            else
            {
                lblCallingNumbers.Visible = false;
                lblDescriptionHeading.Visible = false;
                HideCallingNumberPanels();
                RemoveCallingNumberPanelControls();
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Allows the user to resume the game after the pause button is clicked.
        /// Enable, disable, hide and display specific buttons.
        /// Checks if the timer is not running.
        /// Checks if the timer is running and if the 
        /// random number is 0 or 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResume_Click(object sender, EventArgs e)
        {
            btnResume.Enabled = false;
            btnResume.Visible = false;
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnPause.Enabled = true;
            btnPause.Visible = true;

            if (!isTimerRunning)
            {
                identifyAreas_timer.Start();
                seconds = seconds++ -1;
                isTimerRunning = true;
            }

            if (randomNumber == 0) 
            {
                lblDescription.Visible = true;
                lblCallingNumberHeading.Visible = true;
                DisplayDescriptionPanels();
                CreateDescriptionPanelControls();
            }
            else
            {
                lblCallingNumbers.Visible = true;
                lblDescriptionHeading.Visible = true;
                DisplayCallingNumberPanels();
                CreateCallingNumberPanelControls();
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Hides the Description panels and Headings.
        /// </summary>
        private void HideDescriptionPanels() 
        {
            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {
               ControlExtension.Draggable(bottomShelfPanel, false);
               bottomShelfPanel.Visible = false;
            }

            foreach (Panel topShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("leftShelf")))
            {
                topShelfPanel.Visible = false;
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Hides the related panels and Headings.
        /// </summary>
        private void HideCallingNumberPanels()
        {
            foreach (Panel topShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("rightShelf")))
            {
                topShelfPanel.Visible = false;
            }

            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("callingShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, false);
                bottomShelfPanel.Visible = false;
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Display the Description panels and related Headings description panels.
        /// </summary>
        private void DisplayDescriptionPanels()
        {
            foreach (Panel topShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("leftShelf")))
            {
                topShelfPanel.Visible = true;
            }

            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("descriptionShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, true);
                bottomShelfPanel.Visible = true;
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Hides the related panels and Headings for calling numbers.
        /// </summary>
        private void DisplayCallingNumberPanels()
        {
            foreach (Panel topShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("rightShelf")))
            {
                topShelfPanel.Visible = true;
            }

            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("callingShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, true);
                bottomShelfPanel.Visible = true;
            }
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// A button to exit the application entirely.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?\nExiting will result in data loss", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }


        //-------------------------------------------------------------------------------------------//

    }
}
//---------------------------------------------EndOfFile---------------------------------------------//