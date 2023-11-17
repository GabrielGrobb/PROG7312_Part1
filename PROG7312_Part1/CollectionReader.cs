using System;
using System.Collections.Generic;
using System.IO;

namespace PROG7312_Part1
{
    public class CollectionReader
    {
        public static List<(string, string, string)> ReadCSV(string filePath)
        {
            List<(string, string, string)> data = new List<(string, string, string)>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split(';');

                        // Assuming your CSV file has at least 3 columns
                        if (values.Length >= 3)
                        {
                            string column1 = values[0].Trim();
                            string column2 = values[1].Trim();
                            string column3 = values[2].Trim();

                            // Add validation checks for column2 and column3
                            if (!column2.Equals("[Unassigned]", StringComparison.OrdinalIgnoreCase) &&
                                !column2.Equals("(Optional number)", StringComparison.OrdinalIgnoreCase))
                            {
                                data.Add((column1, column2, column3));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
            }

            return data;
        }

        public static void PrintCSVData(List<(string, string, string)> data)
        {
            foreach (var row in data)
            {
                Console.WriteLine($"Column 1: {row.Item1}, Column 2: {row.Item2}, Column 3: {row.Item3}");
            }
        }

        public void Display() 
        {
            string fileName = "dewey.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            List<(string, string, string)> csvData = ReadCSV(filePath);

            if (csvData.Count > 0)
            {
                Console.WriteLine("CSV Data:");
                PrintCSVData(csvData);
            }
            else
            {
                Console.WriteLine("No valid data found in the CSV file.");
            }
        }
    }
}
