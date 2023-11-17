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

        private QuizSet currentQuizSet;
        private Random random = new Random();
        private int seconds = 0;
        private bool isTimerRunning = false;
        private int correctHundredAnswer;
        private int correctTensAnswer;
        private int correctAnswer;
        private RedBlackTree globalRedBlackTree;


        private List<int> options = new List<int>();

        private Dictionary<string, KeyValuePair<string, string>> hundredsCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, KeyValuePair<string, string>> tensCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();
        private Dictionary<string, KeyValuePair<string, string>> integerCaptionPanelGeneratedOrder = new Dictionary<string, KeyValuePair<string, string>>();

        public CallingNumbersUserControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private int FindFirstLevelElement()
        {
            int randomNumber = random.Next(1, 10);

            // Multiply the random number by 100
            int result = randomNumber * 100;

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        int FindSecondLevelElement(int firstLevelElement)
        {
            int randomNumber = random.Next(1, 10);

            // Multiply the random number by 10 and add it to the first level element
            int result = firstLevelElement + (randomNumber * 10);

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//


        private int FindThirdLevelElement(int secondLevelElement)
        {
            int randomNumber = random.Next(1, 10);

            // Add the random number to the first level element
            int result = secondLevelElement + randomNumber;

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private List<int> GenerateHundredOptions(int correctAnswer)
        {
            options = new List<int>();

            // Extract the hundreds digit from the correct answer
            int hundredsDigit = (correctAnswer / 100) % 10;

            // Generate one correct option with the same hundreds digit and two zeros
            int correctOption = hundredsDigit * 100;
            options.Add(correctOption);

            // Generate three incorrect options with different hundreds digits and two zeros
            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9) * 100;
                while (options.Contains(option) || option / 100 == hundredsDigit || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9) * 100;

                }
                options.Add(option);

            }

            // Shuffle the options
            options = Shuffle(options);

            return options;

        }

        //-------------------------------------------------------------------------------------------------------------------------------------//


        private List<int> GenerateTensOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;
            hundredsDigit *= 100;
            // Extract the tens digit from the correct answer
            int tensDigit = (correctAnswer / 10) % 10;

            // Generate one correct option with the same tens digit
            int correctOption = hundredsDigit + (tensDigit * 10);
            options.Add(correctOption);

            // Generate three incorrect options with different tens digits
            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9) * 10;
                while (options.Contains(option) || option / 10 == tensDigit || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9) * 10;
                }
                options.Add(hundredsDigit + option);
            }

            // Shuffle the options
            options = Shuffle(options);

            return options;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private List<int> GenerateIntegerOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;
            hundredsDigit *= 100;
            // Extract the tens digit from the correct answer
            int tensDigit = (correctAnswer / 10) % 10;

            // Extract the ones digit from the correct answer
            int onesDigit = correctAnswer % 10;

            // Generate one correct option with the same ones digit
            int correctOption = hundredsDigit + (tensDigit * 10) + onesDigit;
            options.Add(correctOption);

            // Generate three incorrect options with different ones digits
            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9);
                while (options.Contains(option) || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9);
                }
                options.Add(hundredsDigit + (tensDigit * 10) + option);
            }

            // Shuffle the options
            options = Shuffle(options);

            return options;
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
                    if (validationMessage.Contains("Correct"))
                    {
                        RemoveLabelsFromPanels();
                        // Set state to Tens set
                        currentQuizSet = QuizSet.Tens;

                        // Generate options and labels for the Tens set
                        List<int> tensOptions = GenerateTensOptions(correctAnswer);
                        CreateLabelsForTensSet(tensOptions);

                        // Show a message or perform other actions for transitioning to the Tens set
                        MessageBox.Show("Congratulations! Moving to the Tens set.");

                        // Exit the method to avoid showing the message box for the Hundreds set
                        return;
                    }
                    break;

                case QuizSet.Tens:
                    validationMessage = ValidateTensSet(clickedRadioButton.Name, correctTensAnswer, globalRedBlackTree);
                    // Check if the validation was correct before moving to the next set
                    if (validationMessage.Contains("Correct"))
                    {
                        RemoveLabelsFromPanels();
                        // Set state to Integer set
                        currentQuizSet = QuizSet.Integers;

                        // Generate options and labels for the Integer set
                        List<int> integerOptions = GenerateIntegerOptions(correctAnswer);
                        CreateLabelsForIntegerSet(integerOptions);

                        // Show a message or perform other actions for transitioning to the Integer set
                        MessageBox.Show("Congratulations! Moving to the Integer set.");

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

                return userHundredsDigit == correctHundredsDigit * 100
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

        private int GenerateRandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = GenerateRandomNumber(0, n);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void DisplayThirdLevel(RedBlackTree redBlackTree)
        {
            int firstLevelElement = FindFirstLevelElement();
            int secondLevelElement = FindSecondLevelElement(firstLevelElement);
            int thirdLevelElement = FindThirdLevelElement(secondLevelElement);

            // Find the node based on the thirdLevelElement and display information
            Node foundNode = redBlackTree.FindElementByCallingNumber(thirdLevelElement.ToString());
            if (foundNode != null)
            {
                // Assuming you have properties like Class, Caption, and Summary in your Node class
                txtDescription.AppendText($"{foundNode.DeweyData.Class}, {foundNode.DeweyData.Caption}");
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
                //MessageBox.Show(ex.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private void CallingNumbersUserControl_Load(object sender, EventArgs e)
        {
            string fileName = "dewey.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            RedBlackTree redBlackTree = new RedBlackTree();
            globalRedBlackTree = redBlackTree;
            ReadCsvFile(redBlackTree, filePath);

            int firstLevelElement = FindFirstLevelElement();
            int secondLevelElement = FindSecondLevelElement(firstLevelElement);
            int thirdLevelElement = FindThirdLevelElement(secondLevelElement);

            correctHundredAnswer = firstLevelElement;
            correctTensAnswer = secondLevelElement;
            correctAnswer= thirdLevelElement;

            // Find the node based on the thirdLevelElement and display information
            Node foundNode = redBlackTree.FindElementByCallingNumber(thirdLevelElement.ToString());
            if (foundNode != null)
            {
                // Assuming you have properties like Class, Caption, and Summary in your Node class
                txtDescription.AppendText($"{foundNode.DeweyData.Class}, {foundNode.DeweyData.Caption}");
            }

            currentQuizSet = QuizSet.Hundreds;

            List<int> hundredsOptions = GenerateHundredOptions(thirdLevelElement);
            CreateLabelsForHundredsSet(hundredsOptions);
        }

        private void callingNumbersTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = $"Timer: {seconds} seconds";
        }

        private void rdoOption1_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        private void rdoOption2_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        private void rdoOption3_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        private void rdoOption4_Click(object sender, EventArgs e)
        {
            HandleRadioButtonClick((RadioButton)sender);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//


    }
}
