using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_Part1
{
    public class UserResultsManager
    {
        //-------------------------------------------------------------------------------------------//

        // Static field to store the cumulative attempts count
        private static int attempts = 0;

        // Static property to expose the attempts count
        public static int Attempts => attempts;

        // List to store user results
        public static List<UserResults> UserResultsList { get; } = new List<UserResults>();

        //-------------------------------------------------------------------------------------------//

        // Method to add user results
        public static void AddUserResults(UserResults results)
        {
            // Increment the attempts count
            attempts++;
            results.Attempt = attempts;

            // Add user results to the list
            UserResultsList.Add(results);
        }

        //-------------------------------------------------------------------------------------------//

        // Method to reset user results
        public static void ResetUserResults()
        {
            UserResultsList.Clear();
            attempts = 0;
        }

        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//