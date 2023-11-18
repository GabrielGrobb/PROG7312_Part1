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
    public partial class CNHelpForm : Form
    {
        /// <summary>
        /// Setting the currentImageIndex to zero.
        /// String array for the images' names.
        /// </summary>
        private int currentImageIndex = 0;
        private string[] imageNames = { "CNHelp1", "CNHelp2", "CNHelp3", "CNHelp4", "CNHelp5", "CNHelp6", "CNHelp7"};

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Displaying the images when the form is opened.
        /// </summary>
        public CNHelpForm()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Displaying an image in a PictureBox. (blawford, 2014)
        /// Stretching the image to fit to the appropriate picture box.
        /// Accessing the images from the resource manager.
        /// </summary>
        /// <param name="index"></param>
        private void DisplayImage(int imageNameIndex)
        {
            if (imageNameIndex >= 0 && imageNameIndex < imageNames.Length)
            {
                pBoxHelp.SizeMode = PictureBoxSizeMode.StretchImage;
                pBoxHelp.Image = Properties.Resources.ResourceManager.GetObject(imageNames[imageNameIndex]) as Image;

            }
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        ///  A back button to decrement through the array indexes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                DisplayImage(currentImageIndex);
            }
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// A next button to increment through the array indexes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < imageNames.Length - 1)
            {
                currentImageIndex++;
                DisplayImage(currentImageIndex);
            }
        }

        //------------------------------------------------------------------------------------------//
    }
}
//------------------------------------------EndOfFile-----------------------------------------------//

#region /// REFERENCES - CODE ATTRIBUTION:
/* 
 * 
Aurthor:  blawford
Webisite: StackOverFlow, 2014/08/27. Load Image from Resources/ResourceManager. [Online]
Accessed on: 2023/09/26
URL:https://stackoverflow.com/questions/25520933/load-image-from-resources-resourcemanager

 */
#endregion