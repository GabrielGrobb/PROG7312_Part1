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
    public partial class CallNumbersForm : Form
    {
        public CallNumbersForm()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// An event for when the form is closing.
        /// This will terminate the application.
        /// All threads will be removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallNumbersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//