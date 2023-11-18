using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WECPOFLogic;
using static PROG7312_Part1.RedBlackTree;

namespace PROG7312_Part1
{
    public partial class CallingNumbersUserControl : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private enum QuizSet
        {
            Hundreds,
            Tens,
            Integers
        }

        /// <summary>
        /// 
        /// </summary>
        private static CallingNumbersHelper Helper = new CallingNumbersHelper();

        /// <summary>
        /// 
        /// </summary>
        private QuizSet currentQuizSet;
        private RedBlackTree globalRedBlackTree;
        private Random random = new Random();

        private int correctHundredAnswer;
        private int correctTensAnswer;
        private int correctAnswer;
        private int seconds = 0;
        private int score = 0;

        private string callNumberGame = "Calling Numbers Game";
        private string validationMessage = "";
        private bool isTimerRunning = false;
        
        
        /// <summary>
        /// 
        /// </summary>
        private List<UserResults> results = new List<UserResults>();

        /// <summary>
        /// Diction
        /// </summary>
        private Dictionary<string, KeyValuePair<string, string>> hundredsCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, KeyValuePair<string, string>> tensCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, KeyValuePair<string, string>> integerCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        public CallingNumbersUserControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clickedRadioButton"></param>
        private void HandleRadioButtonClick(RadioButton clickedRadioButton)
        {
            switch (currentQuizSet)
            {
                case QuizSet.Hundreds:
                    validationMessage = ValidateHundredsSet(clickedRadioButton.Name, correctHundredAnswer, globalRedBlackTree);

                    // Check if the validation was correct before moving to the next set
                    if (validationMessage.StartsWith("Correct"))
                    {
                        score++;
                        RemoveLabelsFromPanels();
                        // Set state to Tens set
                        currentQuizSet = QuizSet.Tens;

                        // Generate options and labels for the Tens set
                        List<int> tensOptions = Helper.GenerateTensOptions(correctAnswer);
                        CreateLabelsForTensSet(tensOptions);

                        // Show a message or perform other actions for transitioning to the Tens set
                        ShowCustomMessageBox("Well Done!. Get ready for the next challenge!", "Next Challenge Awaits", MessageBoxIcon.Information);

                        ResetRadioButtons();
                        // Exit the method to avoid showing the message box for the Hundreds set
                        return;
                    }
                    else if (validationMessage.StartsWith("Try Again"))
                    {
                        score--;
                        if (score <= 0)
                        {
                            score = 0;
                        }
                        ResetRadioButtons();
                        MessageBox.Show(validationMessage);
                        // Exit the method to avoid showing the message box for the Hundreds set
                        return;
                    }
                    break;

                case QuizSet.Tens:
                    validationMessage = ValidateTensSet(clickedRadioButton.Name, correctTensAnswer, globalRedBlackTree);
                    // Check if the validation was correct before moving to the next set
                    if (validationMessage.StartsWith("Correct"))
                    {
                        score++;
                        RemoveLabelsFromPanels();
                        // Set state to Integer set
                        currentQuizSet = QuizSet.Integers;

                        // Generate options and labels for the Integer set
                        List<int> integerOptions = Helper.GenerateIntegerOptions(correctAnswer);
                        CreateLabelsForIntegerSet(integerOptions);

                        // Show a message or perform other actions for transitioning to the Integer set
                        ShowCustomMessageBox("Well Done!. Get ready for the next challenge!", "Next Challenge Awaits", MessageBoxIcon.Information);

                        ResetRadioButtons();

                        // Exit the method to avoid showing the message box for the Tens set
                        return;
                    }
                    else if (validationMessage.StartsWith("Try Again"))
                    {
                        score--;
                        if (score <= 0)
                        {
                            score = 0;
                        }
                        ResetRadioButtons();
                        MessageBox.Show(validationMessage);

                        return;
                    }
                    break;

                case QuizSet.Integers:
                    validationMessage = ValidateIntegerSet(clickedRadioButton.Name, correctAnswer, globalRedBlackTree);
                    if (validationMessage.StartsWith("Correct"))
                    {
                        score++;
                        if (score <= 0) 
                        {
                            score = 0;
                        }
                        RemoveLabelsFromPanels();
                        ResetRadioButtons();
                        DisableRadioButtons();
                        ShowCustomMessageBox($"Thank you for playing!\nFinal Score: {score}", "Game Completed", MessageBoxIcon.Information);
                        btnPlayAgain.Visible = true;
                        btnPlayAgain.Enabled = true;
                    }
                    else if (validationMessage.StartsWith("Try Again"))
                    {
                        score--;
                        ResetRadioButtons();
                        MessageBox.Show(validationMessage);
                        // Exit the method to avoid showing the message box for the Hundreds set
                        return;
                    }
                    CalculateResults();
                    break;

            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radioBtnName"></param>
        /// <param name="correctAnswer"></param>
        /// <param name="redBlackTree"></param>
        /// <returns></returns>
        private string ValidateHundredsSet(string radioBtnName, int correctAnswer, RedBlackTree redBlackTree)
        {
            if (hundredsCaptionPanelGeneratedOrder.TryGetValue(radioBtnName, out KeyValuePair<string, string> panelInfo))
            {
                // Extract the hundreds digit from the correct answer
                int correctHundredsDigit = (correctAnswer / 100) % 10;

                // Extract the hundreds digit from the user answer (using the panel information)
                int userHundredsDigit = int.Parse(panelInfo.Value);

                Node hundreds = redBlackTree.FindElementByCallingNumber((correctHundredsDigit * 100).ToString());

                return userHundredsDigit == correctAnswer
                    ? "Correct!"
                    : $"Try Again! Correct answer is: {hundreds.DeweyData.Caption}";
            }

            // Handle the case where the radio button name is not found in the dictionary
            return "Error: Radio button information not found.";
        }


        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radioBtnName"></param>
        /// <param name="correctAnswer"></param>
        /// <param name="redBlackTree"></param>
        /// <returns></returns>
        private string ValidateTensSet(string radioBtnName, int correctAnswer, RedBlackTree redBlackTree)
        {
            if (tensCaptionPanelGeneratedOrder.TryGetValue(radioBtnName, out KeyValuePair<string, string> panelInfo))
            {
                int hundredsDigit = (correctAnswer / 100) % 10;
                hundredsDigit *= 100;
                // Extract the tens digit from the correct answer
                int correctTensDigit = (correctAnswer / 10) % 10;

                // Extract the tens digit from the user answer
                int userTensDigit = int.Parse(panelInfo.Value);

                Node tens = redBlackTree.FindElementByCallingNumber((hundredsDigit + (correctTensDigit * 10)).ToString());

                return userTensDigit == correctAnswer
                     ? "Correct!"
            : $"Try Again! Correct answer is: {tens.DeweyData.Caption}";
            }
            // Handle the case where the radio button name is not found in the dictionary
            return "Error: Radio button information not found.";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radioBtnName"></param>
        /// <param name="correctAnswer"></param>
        /// <param name="redBlackTree"></param>
        /// <returns></returns>
        private string ValidateIntegerSet(string radioBtnName, int correctAnswer, RedBlackTree redBlackTree)
        {
            if (integerCaptionPanelGeneratedOrder.TryGetValue(radioBtnName, out KeyValuePair<string, string> panelInfo))
            {
                int hundredsDigit = (correctAnswer / 100) % 10;
                hundredsDigit *= 100;
                // Extract the tens digit from the correct answer
                int tensDigit = (correctAnswer / 10) % 10;
                // Extract the ones digit from the correct answer
                int correctOnesDigit = correctAnswer % 10;

                // Extract the ones digit from the user answer
                int userOnesDigit = int.Parse(panelInfo.Value);

                Node integer = redBlackTree.FindElementByCallingNumber((hundredsDigit + (tensDigit * 10) + correctOnesDigit).ToString());

                if (isTimerRunning)
                {
                    callingNumbersTimer.Stop();
                    isTimerRunning = false;
                }

                return userOnesDigit == correctAnswer
                    ? "Correct!"
                    : $"Try Again! Correct answer is: {integer.DeweyData.Caption}";
            }
            // Handle the case where the radio button name is not found in the dictionary
            return "Error: Radio button information not found.";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// Creating a custom message box.
        /// Customize the appearance of the message box.
        /// Show the message box with the specified parameters
        /// Reset the message box appearance
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <param name="icon"></param>
        private void ShowCustomMessageBox(string message, string caption, MessageBoxIcon icon)
        {
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Register();

            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);

            MessageBoxManager.Unregister();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public void CreateLabelsForHundredsSet(List<int> options)
        {
            for (int i = 1; i < 5; i++)
            {
                int randomIndex = random.Next(options.Count);
                string callNumber = options[randomIndex].ToString();
                options.RemoveAt(randomIndex);

                Panel captionPanel = Controls.Find($"captionPanel{i}", true).FirstOrDefault() as Panel;
                RadioButton radioButton = Controls.Find($"rdoOption{i}", true).FirstOrDefault() as RadioButton;
                Node foundNode = globalRedBlackTree.FindElementByCallingNumber(callNumber.ToString());
                if (captionPanel != null)
                {
                    captionPanel.BackColor = Color.Transparent;

                    Label captionPanelLabel = new Label();
                    captionPanelLabel.Text = foundNode.DeweyData.Class + " - " + foundNode.DeweyData.Caption;
                    captionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    captionPanelLabel.Size = new Size(60, 40);

                    captionPanelLabel.Dock = DockStyle.Bottom;
                    captionPanelLabel.BorderStyle = BorderStyle.FixedSingle;
                    captionPanelLabel.BackColor = Color.Plum;
                    captionPanelLabel.AutoSize = false;

                    captionPanel.Controls.Add(captionPanelLabel);

                    hundredsCaptionPanelGeneratedOrder.Add(radioButton.Name, new KeyValuePair<string, string>(captionPanel.Name, callNumber.ToString()));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public void CreateLabelsForTensSet(List<int> options)
        {
            for (int i = 1; i < 5; i++)
            {
                int randomIndex = random.Next(options.Count);
                string callNumber = options[randomIndex].ToString();
                options.RemoveAt(randomIndex);

                Panel captionPanel = Controls.Find($"captionPanel{i}", true).FirstOrDefault() as Panel;
                RadioButton radioButton = Controls.Find($"rdoOption{i}", true).FirstOrDefault() as RadioButton;
                Node foundNode = globalRedBlackTree.FindElementByCallingNumber(callNumber.ToString());
                if (captionPanel != null)
                {
                    captionPanel.BackColor = Color.Transparent;

                    Label captionPanelLabel = new Label();
                    captionPanelLabel.Text = foundNode.DeweyData.Class + " - " + foundNode.DeweyData.Caption;
                    captionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    captionPanelLabel.Size = new Size(60, 40);

                    captionPanelLabel.Dock = DockStyle.Bottom;
                    captionPanelLabel.BorderStyle = BorderStyle.FixedSingle;
                    captionPanelLabel.BackColor = Color.LightPink;
                    captionPanelLabel.AutoSize = false;

                    captionPanel.Controls.Add(captionPanelLabel);

                    tensCaptionPanelGeneratedOrder.Add(radioButton.Name, new KeyValuePair<string, string>(captionPanel.Name, callNumber.ToString()));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public void CreateLabelsForIntegerSet(List<int> options)
        {
            for (int i = 1; i < 5; i++)
            {
                int randomIndex = random.Next(options.Count);
                string callNumber = options[randomIndex].ToString();
                options.RemoveAt(randomIndex);

                Panel captionPanel = Controls.Find($"captionPanel{i}", true).FirstOrDefault() as Panel;
                RadioButton radioButton = Controls.Find($"rdoOption{i}", true).FirstOrDefault() as RadioButton;
                Node foundNode = globalRedBlackTree.FindElementByCallingNumber(callNumber.ToString());

                if (captionPanel != null)
                {
                    captionPanel.BackColor = Color.Transparent;

                    Label captionPanelLabel = new Label();
                    captionPanelLabel.Text = foundNode.DeweyData.Class + " - " + foundNode.DeweyData.Caption;
                    captionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    captionPanelLabel.Size = new Size(60, 40);

                    captionPanelLabel.Dock = DockStyle.Bottom;
                    captionPanelLabel.BorderStyle = BorderStyle.FixedSingle;
                    captionPanelLabel.BackColor = Color.SkyBlue;
                    captionPanelLabel.AutoSize = false;

                    captionPanel.Controls.Add(captionPanelLabel);

                    integerCaptionPanelGeneratedOrder.Add(radioButton.Name, new KeyValuePair<string, string>(captionPanel.Name, callNumber.ToString()));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Iterate through panels.
        /// Remove labels from the panels.
        /// </summary>
        private void RemoveLabelsFromPanels()
        {
            for (int i = 1; i < 5; i++)
            {
                Panel captionPanel = Controls.Find($"captionPanel{i}", true).FirstOrDefault() as Panel;

                if (captionPanel != null)
                {
                    RemoveLabelsFromPanel(captionPanel);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Remove all labels from the panel.
        /// Dispose the label to free up resources
        /// </summary>
        /// <param name="panel"></param>
        private void RemoveLabelsFromPanel(Panel panel)
        {
            foreach (Control control in panel.Controls.OfType<Label>().ToList())
            {
                panel.Controls.Remove(control);
                control.Dispose();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// 
        /// </summary>
        /// <param name="redBlackTree"></param>
        /// <param name="filePath"></param>
        private void ReadCsvFile(RedBlackTree redBlackTree, string filePath)
        {
            try
            {
                bool isFirstRow = true;

                // Mention in readme (references)
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");

                    while (!parser.EndOfData)
                    {
                        // Read the fields from the CSV file
                        string[] fields = parser.ReadFields();

                        if (isFirstRow)
                        {
                            isFirstRow = false;
                            continue; // Skip the first row
                        }

                        // Assuming Class is an integer
                        if (fields.Length >= 3 && int.TryParse(fields[0].Trim(), out int deweyDecimal))
                        {
                            CSVModel model = new CSVModel
                            {
                                Class = fields[0].Trim(),
                                Caption = fields[1].Trim(),
                                Summary = int.Parse(fields[2].Trim())
                            };

                            // Insert deweyDecimal into the Red-Black Tree
                            redBlackTree.Insert(model);
                        }
                    }
                }
            }
            catch (Exception ex){}
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnPause.Visible = true;
            btnPause.Enabled = true;

            EnableRadioButtons();

            CreateQuizGame();
            if (!isTimerRunning)
            {
                callingNumbersTimer.Start();
                isTimerRunning = true;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallingNumbersUserControl_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnPause.Visible = false;
            btnResume.Enabled = false;
            btnResume.Visible = false;
            btnPlayAgain.Enabled = false;
            btnPlayAgain.Visible = false;

            DisableRadioButtons();

            lblTimer.Text = "Timer: 0 seconds";
            lblCaption.Text = "";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// Create the different quiz sets.
        /// Start with the top-level set.
        /// </summary>
        private void CreateQuizGame()
        {
            ConfigureRedBlackTree();
            int firstLevelElement = Helper.FindFirstLevelElement();
            int secondLevelElement = Helper.FindSecondLevelElement(firstLevelElement);
            int thirdLevelElement = Helper.FindThirdLevelElement(secondLevelElement);

            SetCorrectLevelAnswers(firstLevelElement, secondLevelElement, thirdLevelElement);
            DisplayNodeInformation(thirdLevelElement);

            currentQuizSet = QuizSet.Hundreds;

            List<int> hundredsOptions = Helper.GenerateHundredOptions(thirdLevelElement);
            CreateLabelsForHundredsSet(hundredsOptions);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds the dewey.csv file.
        /// Read the csv file.
        /// </summary>
        private void ConfigureRedBlackTree()
        {
            string fileName = "dewey.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            RedBlackTree redBlackTree = new RedBlackTree();
            globalRedBlackTree = redBlackTree;
            ReadCsvFile(redBlackTree, filePath);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Set the correct answer for each quiz set.
        /// </summary>
        /// <param name="firstLevelElement"></param>
        /// <param name="secondLevelElement"></param>
        /// <param name="thirdLevelElement"></param>
        private void SetCorrectLevelAnswers(int firstLevelElement, int secondLevelElement, int thirdLevelElement)
        {
            correctHundredAnswer = firstLevelElement;
            correctTensAnswer = secondLevelElement;
            correctAnswer = thirdLevelElement;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thirdLevelElement"></param>
        private void DisplayNodeInformation(int thirdLevelElement)
        {
            // Find the node based on the thirdLevelElement and display information
            Node foundNode = globalRedBlackTree.FindElementByCallingNumber(thirdLevelElement.ToString());
            if (foundNode != null)
            {
                // Assuming you have properties like Class, Caption, and Summary in your Node class
                lblCaption.Text = $"{foundNode.DeweyData.Class}, {foundNode.DeweyData.Caption}";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Getting the time it took for the user
        /// to complete the game.
        /// </summary>
        /// <returns></returns>
        private TimeSpan GetTimeTaken()
        {
            return TimeSpan.FromSeconds(seconds);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        ///  Used ChatGPT here.
        ///  Retrieving the resukts from the user attempts.
        ///  Storing attempt number, correctly placed books,
        ///  and the time span (duration) in seconds.
        /// </summary>
        private void CalculateResults()
        {
            int correctPanels = score;
            TimeSpan timeTaken = GetTimeTaken();
            string gameName = callNumberGame;

            int attempt = results.Count + 1;

            results.Add(new UserResults(attempt, correctPanels, timeTaken, gameName)
            {
                Attempt = attempt,
                CorrectBooks = correctPanels,
                TimeTaken = timeTaken,
                gameName = gameName,

            });

            UserResultsManager.AddUserResults(new UserResults(attempt, correctPanels, timeTaken, gameName));
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Reset the radio buttons to unchecked.
        /// </summary>
        private void ResetRadioButtons()
        {
            rdoOption1.Checked = false;
            rdoOption2.Checked = false;
            rdoOption3.Checked = false;
            rdoOption4.Checked = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Enable all the radio buttons.
        /// </summary>
        private void EnableRadioButtons()
        {
            rdoOption1.Enabled = true;
            rdoOption2.Enabled = true;
            rdoOption3.Enabled = true;
            rdoOption4.Enabled = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Disable all the radio buttons.
        /// </summary>
        private void DisableRadioButtons()
        {
            rdoOption1.Enabled = false;
            rdoOption2.Enabled = false;
            rdoOption3.Enabled = false;
            rdoOption4.Enabled = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Hide the radio buttons.
        /// Find and hide all the panels.
        /// </summary>
        private void HidePanelsAndButtons()
        {
            rdoOption1.Visible = false;
            rdoOption2.Visible = false;
            rdoOption3.Visible = false;
            rdoOption4.Visible = false;

            for (int i = 1; i < 5; i++)
            {
                Panel captionPanel = Controls.Find($"captionPanel{i}", true).FirstOrDefault() as Panel;

                if (captionPanel != null)
                {
                    captionPanel.Visible = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Make the radio buttons visable.
        /// Find and shopw all the panels.
        /// </summary>
        private void ShowPanelsAndButtons()
        {
            rdoOption1.Visible = true;
            rdoOption2.Visible = true;
            rdoOption3.Visible = true;
            rdoOption4.Visible = true;

            for (int i = 1; i < 5; i++)
            {
                Panel captionPanel = Controls.Find($"captionPanel{i}", true).FirstOrDefault() as Panel;

                if (captionPanel != null)
                {
                    captionPanel.Visible = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void callingNumbersTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = $"Timer: {seconds} seconds";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// On click event for the first radio button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoOption1_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// On click event for the second radio button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoOption2_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// On click event for the third radio button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoOption3_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// On click event for the fourth radio button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoOption4_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Allows the user to pause the game.
        /// Enable, disable, hide and display specific buttons.
        /// Checks if the timer is running.
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

            DisableRadioButtons();
            HidePanelsAndButtons();

            if (isTimerRunning)
            {
                callingNumbersTimer.Stop();
                isTimerRunning = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Allows the user to resume the game after the pause button is clicked.
        /// Enable, disable, hide and display specific buttons.
        /// Checks if the timer is not running.
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

            EnableRadioButtons();
            ShowPanelsAndButtons();

            if (!isTimerRunning)
            {
                callingNumbersTimer.Start();
                seconds = seconds++ - 1;
                isTimerRunning = true;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Ask the user if they would like to play again.
        /// Enable, disable, hide and display specific buttons.
        /// Reset the timer and caption label.
        /// Clear the dictionaries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnPause.Visible = false;
            btnResume.Enabled = false;
            btnResume.Visible = false;
            btnPlayAgain.Enabled = false;
            btnPlayAgain.Visible = false;
            btnStart.Enabled = true;
            btnStart.Visible = true;

            DisableRadioButtons();

            lblTimer.Text = "Timer: 0 seconds";
            lblCaption.Text = "";
            seconds = 0;
            score = 0;
            hundredsCaptionPanelGeneratedOrder.Clear();
            tensCaptionPanelGeneratedOrder.Clear();
            integerCaptionPanelGeneratedOrder.Clear();
            
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Opens a new main menu instance when yes is clicked 
        /// on the cofirmation message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
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

        //-------------------------------------------------------------------------------------------------------------------------------------//

        // <summary>
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

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Opens the help form in a dialog format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            using (CNHelpForm helpForm = new CNHelpForm())
            {
                helpForm.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//
    }
}
//----------------------------------------------------------------EndOfFile--------------------------------------------------------------------//