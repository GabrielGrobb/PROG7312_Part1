using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_Part1
{
    public class UserResultsManager
    {
        /// <summary>
        /// Used ChatGPT
        /// Static field to store the cumulative attempts count.
        /// Static property to expose the attempts count.
        /// List to store user results.
        /// </summary>

        private static int attempts = 0;
        public static int Attempts => attempts;
        public static List<UserResults> UserResultsList { get; } = new List<UserResults>();

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to add user results.
        /// Increment the attempts count for other games.
        /// Add user results to the list
        /// </summary>
        /// <param name="results"></param>
        public static void AddUserResults(UserResults results)
        {
            attempts++;
            results.Attempt = attempts;

            UserResultsList.Add(results);
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        ///  Method to reset user results
        /// </summary>
        public static void ResetUserResults()
        {
            UserResultsList.Clear();
            attempts = 0;
        }

        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//