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

        public int FindFirstLevelElement()
        {
            int randomNumber = random.Next(1, 10);

            // Multiply the random number by 100
            int result = randomNumber * 100;

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        public int FindSecondLevelElement(int firstLevelElement)
        {
            int randomNumber = random.Next(1, 10);

            // Multiply the random number by 10 and add it to the first level element
            int result = firstLevelElement + (randomNumber * 10);

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//


        public int FindThirdLevelElement(int secondLevelElement)
        {
            int randomNumber = random.Next(1, 10);

            // Add the random number to the first level element
            int result = secondLevelElement + randomNumber;

            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        public List<int> GenerateHundredOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            // Extract the hundreds digit from the correct answer
            int hundredsDigit = (correctAnswer / 100) % 10;

            // Generate one correct option with the same hundreds digit and two zeros
            int correctOption = hundredsDigit * 100;
            options.Add(correctOption);

            // Generate three incorrect options with different hundreds digits and two zeros
            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9) * 100;
                while (options.Contains(option) || option / 100 == hundredsDigit || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9) * 100;

                }
                options.Add(option);

            }

            // Shuffle the options
            options = Shuffle(options);

            return options;

        }

        //-------------------------------------------------------------------------------------------------------------------------------------//


        public List<int> GenerateTensOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;
            hundredsDigit *= 100;
            // Extract the tens digit from the correct answer
            int tensDigit = (correctAnswer / 10) % 10;

            // Generate one correct option with the same tens digit
            int correctOption = hundredsDigit + (tensDigit * 10);
            options.Add(correctOption);

            // Generate three incorrect options with different tens digits
            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9) * 10;
                while (options.Contains(option) || option / 10 == tensDigit || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9) * 10;
                }
                options.Add(hundredsDigit + option);
            }

            // Shuffle the options
            options = Shuffle(options);

            return options;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        public List<int> GenerateIntegerOptions(int correctAnswer)
        {
            List<int> options = new List<int>();

            int hundredsDigit = (correctAnswer / 100) % 10;
            hundredsDigit *= 100;
            // Extract the tens digit from the correct answer
            int tensDigit = (correctAnswer / 10) % 10;

            // Extract the ones digit from the correct answer
            int onesDigit = correctAnswer % 10;

            // Generate one correct option with the same ones digit
            int correctOption = hundredsDigit + (tensDigit * 10) + onesDigit;
            options.Add(correctOption);

            // Generate three incorrect options with different ones digits
            for (int i = 0; i < 3; i++)
            {
                int option = GenerateRandomNumber(1, 9);
                while (options.Contains(option) || option == correctAnswer)
                {
                    option = GenerateRandomNumber(1, 9);
                }
                options.Add(hundredsDigit + (tensDigit * 10) + option);
            }

            // Shuffle the options
            options = Shuffle(options);

            return options;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

        private int GenerateRandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------//

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
