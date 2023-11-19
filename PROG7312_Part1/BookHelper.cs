using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    public class BookHelper
    {
        private Random random = new Random();
        //-------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BookHelper() 
        {
            
        }

        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// This method creates the book label.
        /// Adds all three into a string and adds it to a list
        /// for the book label.
        /// </summary>
        public void CreatBookLabel(List<int> twoDecimal,List<int> threeDecimal,List<string> books ,List<string> authorSurnames)
        {
            for (int i = 0; i < 10; i++)
            {
                int randomThreeDecimalIndex = random.Next(threeDecimal.Count);
                int randomTwoDecimalIndex = random.Next(twoDecimal.Count);
                int randomAuthorIndex = random.Next(authorSurnames.Count);

                string threeDecimalPart = threeDecimal[randomThreeDecimalIndex].ToString().PadLeft(3, '0');

                string bookLabel = $"{threeDecimalPart}.{twoDecimal[randomTwoDecimalIndex]} {authorSurnames[randomAuthorIndex].ToUpper().Substring(0, 3)}";

                books.Add(bookLabel);

                threeDecimal.RemoveAt(randomThreeDecimalIndex);
                twoDecimal.RemoveAt(randomTwoDecimalIndex);
                authorSurnames.RemoveAt(randomAuthorIndex);
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds and returns the index of the top shelf panel
        /// </summary>
        /// <param name="topShelfPanel"></param>
        /// <returns></returns>
        public int GetTopShelfIndex(Panel topShelfPanel)
        {
            int index = int.Parse(Regex.Match(topShelfPanel.Name, @"\d+").Value) - 1;
            return index;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Finds and returns the index of the bottom shelf panel
        /// </summary>
        /// <param name="bottomShelfPanel"></param>
        /// <returns></returns>
        public int GetBottomShelfIndex(Panel bottomShelfPanel)
        {
            int index = int.Parse(Regex.Match(bottomShelfPanel.Name, @"\d+").Value) - 1;
            return index;
        }
        //-------------------------------------------------------------------------------------------//


        /// <summary>
        /// Used ChatGPT here and (Ahmed, 2018)
        /// Finding the best attempt for sorting the books.
        /// A LINQ query to sort the list of type UserResults
        /// in descending order then the duration.
        /// </summary>
        /// <param name="results">The best attempt</param>
        /// <returns></returns>
        public UserResults FindBestAttempt(List<UserResults> results)
        {
            if (results.Count == 0)
            {
                return null;
            }

            var bestAttempt = results
                .OrderByDescending(result => result.CorrectBooks)
                .ThenBy(result => result.TimeTaken)
                .First();

            return bestAttempt;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// Iterate through the keys in bottomShelfLabelToTopShelfMap.
        /// When the keys are matched a point will be awarded for each match.
        /// </summary>
        /// <returns></returns>
        public int CalculateScore(Dictionary<string, string> bottomShelfLabelToTopShelfMap, Dictionary<string, KeyValuePair<string, string>> correctOrderStructure)
        {
            int userScore = 0;

            foreach (string bottomShelfName in bottomShelfLabelToTopShelfMap.Keys)
            {
                if (correctOrderStructure.TryGetValue(bottomShelfName, out KeyValuePair<string, string> correctValue) &&
                    bottomShelfLabelToTopShelfMap.TryGetValue(bottomShelfName, out string userValue) &&
                    correctValue.Key == userValue)
                {
                    userScore++;
                }
            }

            return userScore;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Generates first three random numbers.
        /// Generates second two random numbers.
        /// Generates three random letters for the author surname.
        /// Adds each variable to its own list
        /// </summary>
        public void CreateAuthorSurnameAndDecimals(List<int> twoDecimal, List<int> threeDecimal,List<string> authorSurnames)
        {
            for (int i = 0; i < 10; i++)
            {
                char firstLetter = (char)random.Next('A', 'Z' + 1);
                char secondLetter = (char)random.Next('A', 'Z' + 1);
                char thirdLetter = (char)random.Next('A', 'Z' + 1);

                string authorSurname = $"{firstLetter}{secondLetter}{thirdLetter}";
                authorSurnames.Add(authorSurname);

                threeDecimal.Add(random.Next(1000));
                twoDecimal.Add(random.Next(100));
            }
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        ///  Used ChatGPT here.
        ///  Retrieving the resukts from the user attempts.
        ///  Storing attempt number, correctly placed books,
        ///  and the time span (duration) in seconds.
        /// </summary>
        public void CalculateResults(string bookGame, int seconds , List<UserResults> results, 
                                      Dictionary<string, string> bottomShelfLabelToTopShelfMap, 
                                      Dictionary<string, KeyValuePair<string, string>> correctOrderStructure)
        {
            int correctBooks = CalculateScore(bottomShelfLabelToTopShelfMap, correctOrderStructure);
            TimeSpan timeTaken = GetTimeTaken(seconds);
            string gameName = bookGame;

            int attempt = results.Count + 1;

            results.Add(new UserResults(attempt, correctBooks, timeTaken, gameName)
            {
                Attempt = attempt,
                CorrectBooks = correctBooks,
                TimeTaken = timeTaken,
                gameName = gameName,

            });

            UserResultsManager.AddUserResults(new UserResults(attempt, correctBooks, timeTaken, gameName));
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Getting the time it took for the user
        /// to complete the game.
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetTimeTaken(int seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// Extract the first 3 numbers from the Dewey decimal system format
        /// on the book label.
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public int GetNumericValueFromLabel(string label)
        {
            string deweyDecimalPart = label.Substring(0, 3);

            if (int.TryParse(deweyDecimalPart, out int result))
            {
                return result;
            }

            return -1;
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// A boolean method to return if a top shelf panel
        /// is occupied by a book.
        /// </summary>
        /// <param name="topShelfName"></param>
        /// <returns></returns>
        public bool IsTopShelfOccupied(string topShelfName, Dictionary<string, bool> topShelfOccupancyStatus)
        {
            return topShelfOccupancyStatus.ContainsKey(topShelfName) && topShelfOccupancyStatus[topShelfName];
        }
        //-------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// An alternative sorting algorithm to sort the books inascending order.
        /// Using bubble sort.
        /// This is not utilized.
        /// </summary>
        /// <param name="inputDictionary"></param>
        /// <returns></returns>
        private Dictionary<string, KeyValuePair<string, string>> BubbleSortDictionaryByNumericValue(Dictionary<string, KeyValuePair<string, string>> inputDictionary)
        {
            List<KeyValuePair<string, KeyValuePair<string, string>>> dictionaryList = inputDictionary.ToList();
            int n = dictionaryList.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    double value1 = double.Parse(dictionaryList[j].Value.Key.Split(' ')[0]);
                    double value2 = double.Parse(dictionaryList[j + 1].Value.Key.Split(' ')[0]);

                    if (value1 > value2)
                    {
                        KeyValuePair<string, KeyValuePair<string, string>> temp = dictionaryList[j];
                        dictionaryList[j] = dictionaryList[j + 1];
                        dictionaryList[j + 1] = temp;
                    }
                }
            }

            Dictionary<string, KeyValuePair<string, string>> sortedDictionary = dictionaryList
                .ToDictionary(item => item.Key, item => item.Value);

            return sortedDictionary;
        }
        //-------------------------------------------------------------------------------------------//
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//