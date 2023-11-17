using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROG7312_Part1.RedBlackTree;

namespace PROG7312_Part1
{
    public partial class CallingNumbersUserControl : UserControl
    {
        private enum QuizSet
        {
            Hundreds,
            Tens,
            Integers
            // Add more sets as needed
        }
        private static CallingNumbersHelper Helper = new CallingNumbersHelper();

        private QuizSet currentQuizSet;
        private Random random = new Random();
        private int seconds = 0;
        private bool isTimerRunning = false;
        private int correctHundredAnswer;
        private int correctTensAnswer;
        private int correctAnswer;
        private RedBlackTree globalRedBlackTree;


        private Dictionary<string, KeyValuePair<string, string>> hundredsCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, KeyValuePair<string, string>> tensCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, KeyValuePair<string, string>> integerCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();

        public CallingNumbersUserControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void HandleRadioButtonClick(RadioButton clickedRadioButton)
        {
            string validationMessage = "";

            switch (currentQuizSet)
            {
                case QuizSet.Hundreds:
                    validationMessage = ValidateHundredsSet(clickedRadioButton.Name, correctHundredAnswer, globalRedBlackTree);

                    // Check if the validation was correct before moving to the next set
                    if (validationMessage.StartsWith("Correct"))
                    {
                        RemoveLabelsFromPanels();
                        
                        // Set state to Tens set
                        currentQuizSet = QuizSet.Tens;

                        // Generate options and labels for the Tens set
                        List<int> tensOptions = Helper.GenerateTensOptions(correctAnswer);
                        CreateLabelsForTensSet(tensOptions);

                        // Show a message or perform other actions for transitioning to the Tens set
                        MessageBox.Show("Congratulations! Moving to the Tens set.");

                        ResetRadioButtons();
                        // Exit the method to avoid showing the message box for the Hundreds set
                        return;
                    }
                    break;

                case QuizSet.Tens:
                    validationMessage = ValidateTensSet(clickedRadioButton.Name, correctTensAnswer, globalRedBlackTree);
                    // Check if the validation was correct before moving to the next set
                    if (validationMessage.StartsWith("Correct"))
                    {
                        RemoveLabelsFromPanels();
                        // Set state to Integer set
                        currentQuizSet = QuizSet.Integers;

                        // Generate options and labels for the Integer set
                        List<int> integerOptions = Helper.GenerateIntegerOptions(correctAnswer);
                        CreateLabelsForIntegerSet(integerOptions);

                        // Show a message or perform other actions for transitioning to the Integer set
                        MessageBox.Show("Congratulations! Moving to the Integer set.");

                        ResetRadioButtons();

                        // Exit the method to avoid showing the message box for the Tens set
                        return;
                    }
                    break;

                case QuizSet.Integers:
                    validationMessage = ValidateIntegerSet(clickedRadioButton.Name, correctAnswer, globalRedBlackTree);
                    // Handle Integer set validation as needed
                    break;


            }

            // Display or handle the validation message as needed
            MessageBox.Show(validationMessage);
        }

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
                    : $"Incorrect! Correct answer: {correctHundredsDigit * 100} - {hundreds.DeweyData.Caption}";
            }

            // Handle the case where the radio button name is not found in the dictionary
            return "Error: Radio button information not found.";
        }


        //-------------------------------------------------------------------------------------------------------------------------------------//

        private string ValidateTensSet(string radioBtnName,int correctAnswer, RedBlackTree redBlackTree)
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
            : $"Incorrect! Correct answer: {hundredsDigit + (correctTensDigit * 10) }- {tens.DeweyData.Caption}";
            }
            // Handle the case where the radio button name is not found in the dictionary
            return "Error: Radio button information not found.";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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
                    : $"Incorrect! Correct answer: {hundredsDigit + (tensDigit * 10) + correctOnesDigit} - {integer.DeweyData.Caption}";
            }
            // Handle the case where the radio button name is not found in the dictionary
            return "Error: Radio button information not found.";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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
                    captionPanel.BackColor = Color.Silver;

                    Label captionPanelLabel = new Label();
                    captionPanelLabel.Text = foundNode.DeweyData.Class;
                    captionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    captionPanelLabel.Size = new Size(60, 40);

                    captionPanelLabel.Dock = DockStyle.Bottom;
                    captionPanelLabel.BorderStyle = BorderStyle.FixedSingle;
                    captionPanelLabel.BackColor = Color.Orange;
                    captionPanelLabel.AutoSize = false;

                    captionPanel.Controls.Add(captionPanelLabel);

                    hundredsCaptionPanelGeneratedOrder.Add(radioButton.Name, new KeyValuePair<string, string>(captionPanel.Name, callNumber.ToString()));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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
                    captionPanel.BackColor = Color.Silver;

                    Label captionPanelLabel = new Label();
                    captionPanelLabel.Text = foundNode.DeweyData.Class;
                    captionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    captionPanelLabel.Size = new Size(60, 40);

                    captionPanelLabel.Dock = DockStyle.Bottom;
                    captionPanelLabel.BorderStyle = BorderStyle.FixedSingle;
                    captionPanelLabel.BackColor = Color.Orange;
                    captionPanelLabel.AutoSize = false;

                    captionPanel.Controls.Add(captionPanelLabel);

                    tensCaptionPanelGeneratedOrder.Add(radioButton.Name, new KeyValuePair<string, string>(captionPanel.Name, callNumber.ToString()));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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
                    captionPanel.BackColor = Color.Silver;

                    Label captionPanelLabel = new Label();
                    captionPanelLabel.Text = foundNode.DeweyData.Class;
                    captionPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    captionPanelLabel.Size = new Size(60, 40);

                    captionPanelLabel.Dock = DockStyle.Bottom;
                    captionPanelLabel.BorderStyle = BorderStyle.FixedSingle;
                    captionPanelLabel.BackColor = Color.Orange;
                    captionPanelLabel.AutoSize = false;

                    captionPanel.Controls.Add(captionPanelLabel);

                    integerCaptionPanelGeneratedOrder.Add(radioButton.Name, new KeyValuePair<string, string>(captionPanel.Name, callNumber.ToString()));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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

        private void RemoveLabelsFromPanel(Panel panel)
        {
            // Remove all labels from the panel
            foreach (Control control in panel.Controls.OfType<Label>().ToList())
            {
                panel.Controls.Remove(control);
                control.Dispose(); // Dispose the label to free up resources
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
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
            catch (Exception ex)
            {
                
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnPause.Visible = true;
            btnPause.Enabled = true;

            rdoOption1.Enabled = true;
            rdoOption2.Enabled = true;
            rdoOption3.Enabled = true;
            rdoOption4.Enabled = true;

            CreateQuizGame();
            if (!isTimerRunning)
            {
                callingNumbersTimer.Start();
                isTimerRunning = true;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void CallingNumbersUserControl_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnPause.Visible = false;
            btnResume.Enabled = false;
            btnResume.Visible = false;

            rdoOption1.Enabled = false;
            rdoOption2.Enabled = false;
            rdoOption3.Enabled = false;
            rdoOption4.Enabled = false;

            lblTimer.Text = "Timer: 0 seconds";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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

        private void ConfigureRedBlackTree()
        {
            string fileName = "dewey.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            RedBlackTree redBlackTree = new RedBlackTree();
            globalRedBlackTree = redBlackTree;
            ReadCsvFile(redBlackTree, filePath);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void SetCorrectLevelAnswers(int firstLevelElement, int secondLevelElement, int thirdLevelElement)
        {
            correctHundredAnswer = firstLevelElement;
            correctTensAnswer = secondLevelElement;
            correctAnswer = thirdLevelElement;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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

        private void ResetRadioButtons()
        {
            rdoOption1.Checked = false;
            rdoOption2.Checked = false;
            rdoOption3.Checked = false;
            rdoOption4.Checked = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void EnableRadioButtons() 
        {
            rdoOption1.Enabled = true;
            rdoOption2.Enabled = true;
            rdoOption3.Enabled = true;
            rdoOption4.Enabled = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void DisableRadioButtons() 
        {
            rdoOption1.Enabled = false;
            rdoOption2.Enabled = false;
            rdoOption3.Enabled = false;
            rdoOption4.Enabled = false;


            
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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

        private void callingNumbersTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = $"Timer: {seconds} seconds";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void rdoOption1_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void rdoOption2_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void rdoOption3_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void rdoOption4_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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
    }
}
//----------------------------------------------------------------EndOfFile--------------------------------------------------------------------//