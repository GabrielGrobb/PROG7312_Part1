using System.Collections.Generic;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    public partial class ResultsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the ResultsForm class with the specified list of UserResults.
        /// </summary>
        /// <param name="results">A list of type UserResults object.</param>
        public ResultsForm(List<UserResults> results)
        {
            InitializeComponent();
            DisplayResults(results);
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// Displays the results in a DataGridView.
        /// </summary>
        /// <param name="results">A list of type UserResults object.</param>
        private void DisplayResults(List<UserResults> results)
        {
            dgvResults.AutoGenerateColumns = true;
            dgvResults.DataSource = results;

            dgvResults.Columns["Attempt"].HeaderText = "Attempt";
            dgvResults.Columns["CorrectBooks"].HeaderText = "Books Correctly Placed";
            dgvResults.Columns["TimeTaken"].HeaderText = "Time Taken";

            dgvResults.Columns["TimeTaken"].DefaultCellStyle.Format = "hh\\:mm\\:ss";

            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.ReadOnly = true;
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// Updates the display lables with the information from the UserResults object.
        /// </summary>
        /// <param name="bestAttempt">The best book placement attempt.</param>
        public void UpdateDisplay(UserResults bestAttempt)
        {
            if (bestAttempt != null)
            {
                lblBestAttempt.Text = $"{bestAttempt.Attempt}";
                lblCorrectBooks.Text = $"{bestAttempt.CorrectBooks}";
                lblTimeTaken.Text = $"{bestAttempt.TimeTaken.TotalSeconds} seconds";
            }
            else
            {
                lblBestAttempt.Text = "N/A";
                lblCorrectBooks.Text = "N/A";
                lblTimeTaken.Text = "N/A";
            }
        }
        //------------------------------------------------------------------------------------------//
    }
}
//------------------------------------------EndOfFile-----------------------------------------------//
