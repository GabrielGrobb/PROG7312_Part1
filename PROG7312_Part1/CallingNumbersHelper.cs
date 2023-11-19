using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_Part1
{
    public class CallingNumbersHelper
    {
        private Random random = new Random();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CallingNumbersHelper() 
        {
        
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Multiply the random number by 100
        /// </summary>
        /// <returns></returns>
        public int FindFirstLevelElement()
        {
            int randomNumber = random.Next(1, 10);

            int result = randomNumber * 100;

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Multiply the random number by 10 and add it to the first level element
        /// </summary>
        /// <param name="firstLevelElement"></param>
        /// <returns></returns>
        public int FindSecondLevelElement(int firstLevelElement)
        {
            int randomNumber = random.Next(1, 10);

            int result = firstLevelElement + (randomNumber * 10);

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Add the random number to the first level element.
        /// </summary>
        /// <param name="secondLevelElement"></param>
        /// <returns></returns>
        public int FindThirdLevelElement(int secondLevelElement)
        {
            int randomNumber = random.Next(1, 10);

            int result = secondLevelElement + randomNumber;

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// Extract the hundreds digit from the correct answer.
        /// Generate one correct option with the same hundreds digit and two zeros.
        /// Generate three incorrect options with different hundreds digits and two zeros.
        /// Shuffle the options.
        /// </summary>
        /// <param name="correctAnswer"></param>
        /// <returns></returns>
        public List<int> GenerateHundredOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;

            int correctOption = hundredsDigit * 100;
            options.Add(correctOption);

            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9) * 100;
                while (options.Contains(option) || option / 100 == hundredsDigit || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9) * 100;

                }
                options.Add(option);

            }

            options = Shuffle(options);

            return options;

        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// Extract the tens digit from the correct answer.
        /// Generate one correct option with the same tens digit.
        /// Generate three incorrect options with different tens digits.
        /// Shuffle the options.
        /// </summary>
        /// <param name="correctAnswer"></param>
        /// <returns></returns>
        public List<int> GenerateTensOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;
            hundredsDigit *= 100;

            int tensDigit = (correctAnswer / 10) % 10;

            int correctOption = hundredsDigit + (tensDigit * 10);
            options.Add(correctOption);

            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9) * 10;
                while (options.Contains(option) || (option / 10) == tensDigit || option == correctAnswer)
                {
                   option = GenerateRandomNumber(1, 9) * 10;
                }
                options.Add(hundredsDigit + option);
            }

            options = Shuffle(options);

            return options;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// Extract the tens digit from the correct answer.
        /// Extract the ones digit from the correct answer.
        /// Generate one correct option with the same ones digit.
        /// Generate three incorrect options with different ones digits.
        /// Shuffle the options
        /// </summary>
        /// <param name="correctAnswer"></param>
        /// <returns></returns>
        public List<int> GenerateIntegerOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;
            hundredsDigit *= 100;
            
            int tensDigit = (correctAnswer / 10) % 10;

            int onesDigit = correctAnswer % 10;

            int correctOption = hundredsDigit + (tensDigit * 10) + onesDigit;
            options.Add(correctOption);

            for (int i = 0; i < 3; i++)
            {
                int option;
                do
                {
                    option = GenerateRandomNumber(1, 9);
                } while (option == onesDigit);

                options.Add(hundredsDigit + (tensDigit * 10) + option);
            }
            options = Shuffle(options);

            return options;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// Generating a random number.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private int GenerateRandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT.
        /// A method to shuffle to options around.
        /// Prevents the same panel/radio button from
        /// holding the same answer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
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
    }
}
//----------------------------------------------------------------EndOfFile--------------------------------------------------------------------//