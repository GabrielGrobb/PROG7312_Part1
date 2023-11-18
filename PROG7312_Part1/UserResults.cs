using System;

namespace PROG7312_Part1
{
    public class UserResults
    {
        /// <summary>
        /// Gets and sets the attempt number for the user's performance.
        /// </summary>
        public int Attempt { get; set; }

        /// <summary>
        /// Gets and sets the number of correct books placed by the user.
        /// </summary>
        public int CorrectBooks { get; set; }

        /// <summary>
        /// Gets and sets the amount of time taken by the user to complete the task.
        /// </summary>
        public TimeSpan TimeTaken { get; set; }

        /// <summary>
        /// Gets and sets the game name.
        /// </summary>
        public string gameName { get; set; }

        public UserResults(int Attempt, int CorrectBool, TimeSpan TimeTaken, string gameName) 
        {
            this.Attempt = Attempt;
            this.CorrectBooks = CorrectBool;
            this.TimeTaken = TimeTaken;
            this.gameName = gameName;
        }
    }
}
//------------------------------------------EndOfFile-----------------------------------------------//
