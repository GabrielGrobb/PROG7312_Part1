using System.Collections.Generic;
using System.Linq;

namespace PROG7312_Part1
{
    public class BookHelper
    {
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