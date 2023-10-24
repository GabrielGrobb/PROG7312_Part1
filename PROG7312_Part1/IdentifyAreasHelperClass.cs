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
        private Dictionary<string, string> randomlyChosencallNumberDescriptions;

        //-------------------------------------------------------------------------------------------//

        private Dictionary<string, string> leftShelfGeneratedOrder;
        private Dictionary<string, string> descriptionShelfGeneratedOrder;

        private Dictionary<Panel, Point> originalDescriptionShelfLocations;
        private Dictionary<string, Point> originalRightShelfLocations;

        private Dictionary<string, bool> rightShelfOccupancyStatus;
        private List<string> books;

        //-------------------------------------------------------------------------------------------//

        public IdentifyAreasHelperClass(
            Dictionary<string, string> randomlyChosencallNumberDescriptions,
            Dictionary<string, string> leftShelfGeneratedOrder,
            Dictionary<string, string> descriptionShelfGeneratedOrder,
            Dictionary<Panel, Point> originalDescriptionShelfLocations,
            Dictionary<string, Point> originalRightShelfLocations,
            Dictionary<string, bool> rightShelfOccupancyStatus,
            List<string> books)
        {
            this.randomlyChosencallNumberDescriptions = randomlyChosencallNumberDescriptions;
            this.leftShelfGeneratedOrder = leftShelfGeneratedOrder;
            this.descriptionShelfGeneratedOrder = descriptionShelfGeneratedOrder;
            this.originalDescriptionShelfLocations = originalDescriptionShelfLocations;
            this.originalRightShelfLocations = originalRightShelfLocations;
            this.rightShelfOccupancyStatus = rightShelfOccupancyStatus;
            this.books = books;
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForLeftShelf(Control.ControlCollection controls)
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

                    leftShelfGeneratedOrder.Add(leftShelf.Name, leftShelfLabel.Text);
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForDescriptionShelf(Control.ControlCollection controls)
        {
            List<string> descriptionTexts = randomlyChosencallNumberDescriptions.Values.ToList();
            Random random = new Random();

            for (int i = 1; i <= 7; i++)
            {
                int randomIndex = random.Next(descriptionTexts.Count);
                string descriptionText = descriptionTexts[randomIndex];
                descriptionTexts.RemoveAt(randomIndex);

                Panel descriptionShelf = controls.Find($"descriptionShelf{i}", true).FirstOrDefault() as Panel;

                if (descriptionShelf != null)
                {
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
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// This method iterates through all the top shelves with the
        /// names starting with topShelf followed by a integer.
        /// The properties are added to the corresponding 
        /// dictionaries.
        /// </summary>
        public void StoreRightShelfProperties(Control.ControlCollection controls)
        {
            for (int i = 1; i <= 4; i++)
            {
                Panel rightShelfPanel = controls.Find($"rightShelf{i}", true).FirstOrDefault() as Panel;

                if (rightShelfPanel != null)
                {
                    originalRightShelfLocations[$"rightShelf{i}"] = rightShelfPanel.Location;

                    rightShelfOccupancyStatus[$"rightShelf{i}"] = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public void CreateLabelsForRightShelf(Control.ControlCollection controls)
        {
            List<string> descriptionTexts = randomlyChosencallNumberDescriptions.Values.ToList();
            Random random = new Random();

            for (int i = 1; i < 5; i++)
            {
                int randomIndex = random.Next(descriptionTexts.Count);
                string callNumber = descriptionTexts[randomIndex];
                descriptionTexts.RemoveAt(randomIndex);

                Panel leftShelf = controls.Find($"rightShelf{i}", true).FirstOrDefault() as Panel;

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

                    leftShelfGeneratedOrder.Add(leftShelf.Name, leftShelfLabel.Text);
                }
            }
        }

        public void CreateLabelsForCallingNumberShelf(Control.ControlCollection controls)
        {
            List<string> callNumbers = randomlyChosencallNumberDescriptions.Keys.ToList();
            Random random = new Random();

            for (int i = 1; i <= 7; i++)
            {
                int randomIndex = random.Next(callNumbers.Count);
                string descriptionText = callNumbers[randomIndex];
                callNumbers.RemoveAt(randomIndex);

                Panel descriptionShelf = controls.Find($"callingShelf{i}", true).FirstOrDefault() as Panel;

                if (descriptionShelf != null)
                {
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
        }

        public void StoreLeftShelfProperties(Control.ControlCollection controls)
        {
            for (int i = 1; i <= 4; i++)
            {
                Panel rightShelfPanel = controls.Find($"leftShelf{i}", true).FirstOrDefault() as Panel;

                if (rightShelfPanel != null)
                {
                    originalRightShelfLocations[$"leftShelf{i}"] = rightShelfPanel.Location;

                    rightShelfOccupancyStatus[$"leftShelf{i}"] = false;
                }
            }
        }
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//