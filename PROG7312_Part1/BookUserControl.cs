using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BooksClassLibrary;

namespace PROG7312_Part1
{
    public partial class BookUserControl : UserControl
    {
        /// <summary>
        ///  Variables:
        ///  seconds is for the timer.
        ///  isTimerRunning checks if the timer is still counting
        ///  selectedBottomShelfPanel is the selected book.
        ///  random is to generate random integers and characters.
        /// </summary>
        private int seconds = 0; // Variable to store the timer value
        private bool isTimerRunning = false; // Flag to track whether the timer is running
        private Panel selectedBottomShelfPanel;
        private string bookGame = "Book Shelf Game";
        private Random random = new Random();

        /// <summary>
        /// A boolean array to check if the top shelf is occupied.
        /// </summary>
        private bool[] bottomShelfOccupancyStatus = new bool[10]; // Assuming you have 10 top shelf panels

        /// <summary>
        /// Lists to store:
        /// User results.
        /// The created books.
        /// Author surnames
        /// First 3 numbers.
        /// Second 2 numbers.
        /// </summary>
        private List<UserResults> results = new List<UserResults>();
        private List<string> books = new List<string>();
        private List<string> authorSurnames = new List<string>();
        private List<int> threeDecimal = new List<int>();
        private List<int> twoDecimal = new List<int>();

        /// <summary>
        /// Dictionaries to store:
        /// The orginal generated order of books.
        /// The correct order of books (ascending order).
        /// The top shelf panel locations.
        /// The bottom shelf panel locations.
        /// Occupancy status of top shelf.
        /// Map of the assigned/placed shelves.
        /// </summary>
        private Dictionary<string, string> originalGeneratedOrder = new Dictionary<string, string>(); // Store the original order
        private Dictionary<string, KeyValuePair<string, string>> correctOrderStructure = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, Point> originalTopShelfLocations = new Dictionary<string, Point>();
        private Dictionary<Panel, Point> originalBottomShelfLocations = new Dictionary<Panel, Point>();
        private Dictionary<string, bool> topShelfOccupancyStatus = new Dictionary<string, bool>();
        private Dictionary<string, string> bottomShelfLabelToTopShelfMap = new Dictionary<string, string>();

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Initializing component
        /// </summary>
        public BookUserControl()
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
        private void BookUserControl_Load(object sender, EventArgs e)
        {
            GenerateRandomBooks();

            btnSubmit.Enabled = false;
            btnReset.Enabled = false;
            btnRestart.Enabled = false;
            lblTimer.Text = "Timer: 0 seconds";
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Orders the books randomly in a list.
        /// Orders the original dictionary into
        /// acesending order.
        /// </summary>
        private void GenerateRandomBooks()
        {
            int index = 1;

            books = books.OrderBy(x => random.Next()).ToList();

            CreateAuthorSurnameAndDecimals();

            CreatBookLabel();

            CreateBooksWithLabels();

            StoreTopShlfProperties();
            
            foreach (var item in originalGeneratedOrder.OrderBy(x => GetNumericValueFromLabel(x.Value)))
            {
                string topShelfName = $"topShelf{index++}";
                correctOrderStructure[topShelfName] = item;
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Generates first three random numbers.
        /// Generates second two random numbers.
        /// Generates three random letters for the author surname.
        /// Adds each variable to its own list
        /// </summary>
        private void CreateAuthorSurnameAndDecimals()
        {
            for (int i = 0; i < 10; i++)
            {
                char firstLetter = (char)random.Next('A', 'Z' + 1);
                char secondLetter = (char)random.Next('A', 'Z' + 1);
                char thirdLetter = (char)random.Next('A', 'Z' + 1);

                string authorSurname = $"{firstLetter}{secondLetter}{thirdLetter}";
                authorSurnames.Add(authorSurname);

                threeDecimal.Add(random.Next(1000));
                twoDecimal.Add(random.Next(100));

            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// This method creates the book label.
        /// Adds all three into a string and adds it to a list
        /// for the book label.
        /// </summary>
        private void CreatBookLabel()
        {
            for (int i = 0; i < 10; i++)
            {
                int randomThreeDecimalIndex = random.Next(threeDecimal.Count);
                int randomTwoDecimalIndex = random.Next(twoDecimal.Count);
                int randomAuthorIndex = random.Next(authorSurnames.Count);

                string threeDecimalPart = threeDecimal[randomThreeDecimalIndex].ToString().PadLeft(3, '0');

                string bookLabel = $"{threeDecimalPart}.{twoDecimal[randomTwoDecimalIndex]} {authorSurnames[randomAuthorIndex].ToUpper().Substring(0, 3)}";

                books.Add(bookLabel);

                threeDecimal.RemoveAt(randomThreeDecimalIndex);
                twoDecimal.RemoveAt(randomTwoDecimalIndex);
                authorSurnames.RemoveAt(randomAuthorIndex);
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// This method iterates through all the bottom shelves with the
        /// names starting with bottomShelf followed by a integer.
        /// The properties are added to the corresponding 
        /// dictionaries.
        /// The labels are added to the panels and their generated order is stored
        /// in a dictionary.
        /// </summary>
        private void CreateBooksWithLabels()
        {
            for (int i = 1; i <= books.Count; i++)
            {
                Panel bottomShelf = Controls.Find($"bottomShelf{i}", true).FirstOrDefault() as Panel;

                bottomShelf.Tag = bottomShelf.Location;

                originalBottomShelfLocations[bottomShelf] = bottomShelf.Location;

                bottomShelf.BackColor = Color.Gray;
                bottomShelf.Size = new Size(80, 155);

                Label bookLabel = new Label();
                bookLabel.Text = books[i - 1]; 
                bookLabel.TextAlign = ContentAlignment.MiddleCenter;
                bookLabel.Size = new Size(60, 40);

                bookLabel.Dock = DockStyle.Bottom;
                bookLabel.BorderStyle = BorderStyle.FixedSingle;
                bookLabel.BackColor = Color.Orange;
                bookLabel.AutoSize = false;

                bottomShelf.Controls.Add(bookLabel);

                originalGeneratedOrder.Add(bottomShelf.Name, bookLabel.Text = books[i - 1]);
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
        private void StoreTopShlfProperties() 
        {
            for (int i = 1; i <= 10; i++)
            {
                Panel topShelfPanel = Controls.Find($"topShelf{i}", true).FirstOrDefault() as Panel;

                if (topShelfPanel != null)
                {
                    originalTopShelfLocations[$"topShelf{i}"] = topShelfPanel.Location;

                    topShelfOccupancyStatus[$"topShelf{i}"] = false;
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
        private void BookControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedBottomShelfPanel = sender as Panel;
                ControlExtension.Draggable(sender as Panel, true);
                selectedBottomShelfPanel.BringToFront();
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
            if (e.Button == MouseButtons.Right)
            {
                selectedBottomShelfPanel = sender as Panel;
                ControlExtension.Draggable(sender as Panel, true);
                selectedBottomShelfPanel.BringToFront();
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
        private void BookControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedBottomShelfPanel == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                BookPanelLeftClick();
            }
            else if (e.Button == MouseButtons.Right)
            {
                BookPanelRightClick();
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
        private void BookPanelLeftClick()
        {
            Panel closestTopShelf = FindClosestTopShelf(selectedBottomShelfPanel);

            if (closestTopShelf == null)
            {
                return; 
            }

            string topShelfName = closestTopShelf.Name;

            if (IsTopShelfOccupied(topShelfName))
            {
                return; 
            }

            if (selectedBottomShelfPanel.Tag is Panel prevTopShelf)
            {
                string prevTopShelfName = prevTopShelf.Name;
                topShelfOccupancyStatus[prevTopShelfName] = false;
            }

            int newX = closestTopShelf.Left + (closestTopShelf.Width - selectedBottomShelfPanel.Width) / 2;
            int newY = closestTopShelf.Top + (closestTopShelf.Height - selectedBottomShelfPanel.Height) / 2;
            selectedBottomShelfPanel.Location = new Point(newX, newY);

            topShelfOccupancyStatus[topShelfName] = true;

            selectedBottomShelfPanel.Tag = closestTopShelf;

            bottomShelfLabelToTopShelfMap[closestTopShelf.Name] = selectedBottomShelfPanel.Name;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// This method is called when the right mouse button is clicked.
        /// When a book is clicked on, it will return to its originally
        /// generated panel. The top panel without a book will become unoccupied.
        /// The book recieves it's original location.
        /// </summary>
        private void BookPanelRightClick()
        {
            if (!originalBottomShelfLocations.TryGetValue(selectedBottomShelfPanel, out Point originalLocation)) 
            {
                return;
            }
            
            selectedBottomShelfPanel.Location = originalLocation;
            int index = GetBottomShelfIndex(selectedBottomShelfPanel);
            bottomShelfOccupancyStatus[index] = true;

            if (!(selectedBottomShelfPanel.Tag is Panel prevTopShelf)) 
            {
                return;
            }
                
            string prevTopShelfName = prevTopShelf.Name;
            topShelfOccupancyStatus[prevTopShelfName] = false;

            bottomShelfLabelToTopShelfMap.Remove(prevTopShelfName);

            selectedBottomShelfPanel.Tag = null;
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
            string gameName = bookGame;

            int attempt = results.Count + 1;

            results.Add(new UserResults
            {
                Attempt = attempt,
                CorrectBooks = correctBooks,
                TimeTaken = timeTaken,
                gameName = gameName,
               
            });
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

            Panel closestTopShelf = FindClosestUnoccupiedTopShelf(bottomCenter);

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
        private Panel FindClosestUnoccupiedTopShelf(Point bottomCenter)
        {
            Panel closestTopShelf = null;
            double closestDistance = double.MaxValue;

            foreach (Control control in Controls)
            {
                if (!(control is Panel topShelfPanel) || !topShelfPanel.Name.StartsWith("topShelf"))
                    continue;

                string topShelfName = topShelfPanel.Name;
                int index = GetTopShelfIndex(topShelfPanel);

                if (topShelfOccupancyStatus.ContainsKey(topShelfName) && topShelfOccupancyStatus[topShelfName])
                    continue;

                Point topCenter = Class1.CalculateCenter(topShelfPanel);

                double distance = Class1.CalculateDistance(bottomCenter, topCenter);

                if (distance < closestDistance)
                {
                    closestTopShelf = topShelfPanel;
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
        /// Used ChatGPT here.
        /// Iterate through the keys in bottomShelfLabelToTopShelfMap.
        /// When the keys are matched a point will be awarded for each match.
        /// </summary>
        /// <returns></returns>
        private int CalculateScore()
        {
            int userScore = 0;

            foreach (string bottomShelfName in bottomShelfLabelToTopShelfMap.Keys)
            {
                if (correctOrderStructure.TryGetValue(bottomShelfName, out KeyValuePair<string, string> correctValue) &&
                    bottomShelfLabelToTopShelfMap.TryGetValue(bottomShelfName, out string userValue) &&
                    correctValue.Key == userValue)
                {
                    
                    userScore++;
                }
            }

            return userScore;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// Extract the first 3 numbers from the Dewey decimal system format
        /// on the book label.
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        private int GetNumericValueFromLabel(string label)
        {
            string deweyDecimalPart = label.Substring(0, 3);

            if (int.TryParse(deweyDecimalPart, out int result))
            {
                return result;
            }

            return -1;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// As the timer ticks, the label holding the time
        /// will be updated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookTimer_Tick(object sender, EventArgs e)
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

        /// <summary>
        /// The score will be calculated.
        /// Iterates through the bottom shelf and
        /// removes mouse events.
        /// Timer is stopped.
        /// A messagebox will display the results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userScore = CalculateScore();

            CalculateResults();

            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("bottomShelf")))
            {
                ControlExtension.Draggable(bottomShelfPanel, false);
                bottomShelfPanel.MouseDown -= BookControl_MouseDown;
                bottomShelfPanel.MouseUp -= BookControl_MouseUp;
            }

            bookTimer.Stop();
            isTimerRunning = false;

            btnStart.Enabled = false;
            btnSubmit.Enabled = false;
            btnReset.Enabled = true;
            btnRestart.Enabled = true;

            MessageBox.Show($"Your score: {userScore}/10", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// This button will remove any mouse up and down events
        /// associated to books. It will then re-add the events to the 
        /// books. Thereafter, the timer will begin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnRestart.Enabled = false;

            foreach (Panel bottomShelf in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("bottomShelf")))
            {
                bottomShelf.MouseDown -= BookControl_MouseDown;
                bottomShelf.MouseUp -= BookControl_MouseUp;
            }

            for (int i = 1; i <= books.Count; i++)
            {
                Panel bottomShelf = Controls.Find($"bottomShelf{i}", true).FirstOrDefault() as Panel;

                bottomShelf.MouseDown += BookControl_MouseDown;
                bottomShelf.MouseUp += BookControl_MouseUp;
                bottomShelf.Draggable(true);
                bottomShelf.BringToFront();
            }

            if (!isTimerRunning)
            {
                bookTimer.Start();
                isTimerRunning = true;
                btnSubmit.Enabled = true;
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Resets the timer to 0.
        /// Iterates through bottom shelf panels (books) and 
        /// removes mouse events.
        /// Returns the books to their original location.
        /// Sets bottomshelf occupancy to true and top shelf
        /// occupancy to false.
        /// Removes the corresponding books.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            btnReset.Enabled = false;
            btnStart.Enabled = true;

            seconds = 0;

            lblTimer.Text = "Timer: 0 seconds";

            foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("bottomShelf")))
            {
 
                ControlExtension.Draggable(bottomShelfPanel, false);

                bottomShelfPanel.MouseDown -= BookControl_MouseDown;
                bottomShelfPanel.MouseUp -= BookControl_MouseUp;

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

                    bottomShelfLabelToTopShelfMap.Remove(prevTopShelfName);
                }

                bottomShelfPanel.Tag = null;
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// This button is responsible for asking the user if they want to 
        /// restart the entire book shelf. All the lists and dictionaries will 
        /// be cleared. The books will be reset to the bottom shelf with new
        /// labels. The timer will be reset to 0. Removes any existing controls
        /// and events.This is similar to creating a new instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Display the user's score
            DialogResult myResult = MessageBox.Show("Are you sure you would like to Restart?\n" +
                "Restarting will change the labels and where the books need to be placed.\n" +
                "Click Yes to Confirm or No to Cancel."
              , "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (myResult == DialogResult.Yes) 
            {
                btnSubmit.Enabled = false;
                btnReset.Enabled = false;
                btnStart.Enabled = true;

                seconds = 0;

                lblTimer.Text = "Timer: 0 seconds";
                bookTimer.Stop();

                foreach (Panel bottomShelfPanel in Controls.OfType<Panel>().Where(panel => panel.Name.StartsWith("bottomShelf")))
                {
                    ControlExtension.Draggable(bottomShelfPanel, false);
                    bottomShelfPanel.MouseDown -= BookControl_MouseDown;
                    bottomShelfPanel.MouseUp -= BookControl_MouseUp;
                    bottomShelfPanel.Controls.Clear();

                    originalBottomShelfLocations.TryGetValue(bottomShelfPanel, out Point originalLocation);
                    bottomShelfPanel.Location = originalLocation;
                    int index = GetBottomShelfIndex(bottomShelfPanel);
                    bottomShelfOccupancyStatus[index] = true;

                    topShelfOccupancyStatus[bottomShelfPanel.Name] = false;

                    bottomShelfLabelToTopShelfMap.Remove(bottomShelfPanel.Name);
                }

                originalGeneratedOrder.Clear();
                correctOrderStructure.Clear();
                books.Clear();

                GenerateRandomBooks();

                btnSubmit.Enabled = false;
                btnReset.Enabled = false;
                btnRestart.Enabled = false;
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
            ResultsForm resultsForm = new ResultsForm(results);
            resultsForm.UpdateDisplay(FindBestAttempt(results));
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
            using (HelpForm helpForm = new HelpForm())
            {
                helpForm.ShowDialog();
            }
        }
        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//

#region /// REFERENCES - CODE ATTRIBUTION:
/* 
 * 
Aurthor:  Farhan Ahmed
Webisite: c-sharpcorner, 2018/08/05. How To Use Data Sorting Operations With Database Using LINQ. [Online]
Accessed on: 2023/09/26
URL:https://www.c-sharpcorner.com/article/understanding-useful-operators-for-sorting-data-in-linq/

 */
#endregion