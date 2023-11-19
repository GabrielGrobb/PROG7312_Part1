using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    public class IdentifyAreasHelperClass
    {
        //-------------------------------------------------------------------------------------------//

        private Dictionary<string, string> randomlyChosencallNumberDescriptions;
        private Dictionary<string, string> randomlyChosenDescriptionsCallNumbers;

        //-------------------------------------------------------------------------------------------//

        private Dictionary<string, string> topShelfGeneratedOrder;
        private Dictionary<string, string> bottomShelfGeneratedOrder;

        private Dictionary<Panel, Point> originalbottomShelfLocations;
        private Dictionary<string, Point> originalTopShelfLocations;

        private Dictionary<string, bool> topShelfOccupancyStatus;
        private List<string> books;

        //-------------------------------------------------------------------------------------------//

        public IdentifyAreasHelperClass(
            Dictionary<string, string> randomlyChosencallNumberDescriptions,
            Dictionary<string, string> randomlyChosenDescriptionsCallNumbers,
            Dictionary<string, string> topShelfGeneratedOrder,
            Dictionary<string, string> bottomShelfGeneratedOrder,
            Dictionary<Panel, Point> originalbottomShelfLocations,
            Dictionary<string, Point> originalTopShelfLocations,
            Dictionary<string, bool> topShelfOccupancyStatus,
            List<string> books)
        {
            this.randomlyChosencallNumberDescriptions = randomlyChosencallNumberDescriptions;
            this.randomlyChosenDescriptionsCallNumbers = randomlyChosenDescriptionsCallNumbers;
            this.topShelfGeneratedOrder = topShelfGeneratedOrder;
            this.bottomShelfGeneratedOrder = bottomShelfGeneratedOrder;
            this.originalbottomShelfLocations = originalbottomShelfLocations;
            this.originalTopShelfLocations = originalTopShelfLocations;
            this.topShelfOccupancyStatus = topShelfOccupancyStatus;
            this.books = books;
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForTopLeftShelf(Control.ControlCollection controls)
        {
            List<string> callNumbers = randomlyChosencallNumberDescriptions.Keys.ToList();
            Random random = new Random();

            for (int i = 1; i < 5; i++)
            {
                int randomIndex = random.Next(callNumbers.Count);
                string callNumber = callNumbers[randomIndex];
                callNumbers.RemoveAt(randomIndex);

                Panel leftShelf = controls.Find($"leftShelf{i}", true).FirstOrDefault() as Panel;

                if (leftShelf != null)
                {
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

                    topShelfGeneratedOrder.Add(leftShelf.Name, leftShelfLabel.Text);
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForDescriptionShelf(Control.ControlCollection controls)
        {
            List<string> descriptionTexts = randomlyChosencallNumberDescriptions.Values.ToList();
            Random random = new Random();

            // Shuffle the descriptionTexts list randomly
            for (int i = 0; i < descriptionTexts.Count - 1; i++)
            {
                int j = random.Next(i, descriptionTexts.Count);
                string temp = descriptionTexts[i];
                descriptionTexts[i] = descriptionTexts[j];
                descriptionTexts[j] = temp;
            }

            for (int i = 1; i <= 7; i++)
            {
                Panel descriptionShelf = controls.Find($"descriptionShelf{i}", true).FirstOrDefault() as Panel;

                if (descriptionShelf != null)
                {
                    originalbottomShelfLocations[descriptionShelf] = descriptionShelf.Location;

                    descriptionShelf.BackColor = Color.Silver;

                    Label descriptionShelfLabel = new Label();
                    descriptionShelfLabel.Text = descriptionTexts[i - 1];
                    descriptionShelfLabel.TextAlign = ContentAlignment.MiddleCenter;
                    descriptionShelfLabel.Size = new Size(60, 40);

                    descriptionShelfLabel.Dock = DockStyle.Bottom;
                    descriptionShelfLabel.BorderStyle = BorderStyle.FixedSingle;
                    descriptionShelfLabel.BackColor = Color.Orange;
                    descriptionShelfLabel.AutoSize = false;
                    descriptionShelfLabel.Enabled = false;

                    books.Add(descriptionShelfLabel.Text);

                    descriptionShelf.Controls.Add(descriptionShelfLabel);

                    bottomShelfGeneratedOrder.Add(descriptionShelf.Name, descriptionShelfLabel.Text);
                }
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
        public void StoreTopRightShelfProperties(Control.ControlCollection controls)
        {
            for (int i = 1; i <= 4; i++)
            {
                Panel rightShelfPanel = controls.Find($"rightShelf{i}", true).FirstOrDefault() as Panel;

                if (rightShelfPanel != null)
                {
                    originalTopShelfLocations[$"rightShelf{i}"] = rightShelfPanel.Location;

                    topShelfOccupancyStatus[$"rightShelf{i}"] = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForRightShelf(Control.ControlCollection controls)
        {
            List<string> descriptionTexts = randomlyChosenDescriptionsCallNumbers.Keys.ToList();
            Random random = new Random();

            // Shuffle the descriptionTexts list randomly
            for (int i = 0; i < descriptionTexts.Count - 1; i++)
            {
                int j = random.Next(i, descriptionTexts.Count);
                string temp = descriptionTexts[i];
                descriptionTexts[i] = descriptionTexts[j];
                descriptionTexts[j] = temp;
            }

            for (int i = 1; i < 5; i++)
            {
                int randomIndex = random.Next(descriptionTexts.Count);
                string callNumber = descriptionTexts[randomIndex];
                descriptionTexts.RemoveAt(randomIndex);

                Panel rightShelf = controls.Find($"rightShelf{i}", true).FirstOrDefault() as Panel;

                if (rightShelf != null)
                {
                    rightShelf.BackColor = Color.Silver;

                    Label rightShelfLabel = new Label();
                    rightShelfLabel.Text = callNumber;
                    rightShelfLabel.TextAlign = ContentAlignment.MiddleCenter;
                    rightShelfLabel.Size = new Size(200, 40);

                    rightShelfLabel.Dock = DockStyle.Bottom;
                    rightShelfLabel.BorderStyle = BorderStyle.FixedSingle;
                    rightShelfLabel.BackColor = Color.Orange;
                    rightShelfLabel.AutoSize = false;

                    rightShelf.Controls.Add(rightShelfLabel);

                    topShelfGeneratedOrder.Add(rightShelf.Name, rightShelfLabel.Text);
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForCallingNumberShelf(Control.ControlCollection controls)
        {
            List<string> callNumbers = randomlyChosenDescriptionsCallNumbers.Values.ToList();
            Random random = new Random();

            for (int i = 1; i <= 7; i++)
            {
                int randomIndex = random.Next(callNumbers.Count);
                string callNumbersText = callNumbers[randomIndex];
                callNumbers.RemoveAt(randomIndex);

                Panel callingShelf = controls.Find($"callingShelf{i}", true).FirstOrDefault() as Panel;

                if (callingShelf != null)
                {
                    originalbottomShelfLocations[callingShelf] = callingShelf.Location;

                    callingShelf.BackColor = Color.Silver;

                    Label callingShelfLabel = new Label();
                    callingShelfLabel.Text = callNumbersText;
                    callingShelfLabel.TextAlign = ContentAlignment.MiddleCenter;
                    callingShelfLabel.Size = new Size(60, 40);

                    callingShelfLabel.Dock = DockStyle.Bottom;
                    callingShelfLabel.BorderStyle = BorderStyle.FixedSingle;
                    callingShelfLabel.BackColor = Color.Orange;
                    callingShelfLabel.AutoSize = false;
                    callingShelfLabel.Enabled = false;

                    books.Add(callingShelfLabel.Text);

                    callingShelf.Controls.Add(callingShelfLabel);

                    bottomShelfGeneratedOrder.Add(callingShelf.Name, callingShelfLabel.Text);
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public void StoreLeftShelfProperties(Control.ControlCollection controls)
        {
            for (int i = 1; i <= 4; i++)
            {
                Panel leftShelfPanel = controls.Find($"leftShelf{i}", true).FirstOrDefault() as Panel;

                if (leftShelfPanel != null)
                {
                    originalTopShelfLocations[$"leftShelf{i}"] = leftShelfPanel.Location;

                    topShelfOccupancyStatus[$"leftShelf{i}"] = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//