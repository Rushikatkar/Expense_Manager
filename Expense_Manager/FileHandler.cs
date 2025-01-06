using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Expense_Manager
{
    public class FileHandler
    {
        public static List<Expense> ReadExpenses(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The specified file does not exist. Please check the path and try again.");
                return null;
            }

            try
            {
                if (filePath.EndsWith(".txt"))
                {
                    return ReadFromTxt(filePath);
                }
                else if (filePath.EndsWith(".json"))
                {
                    return ReadFromJson(filePath);
                }
                else
                {
                    Console.WriteLine("Unsupported file format. Please provide a .txt or .json file.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while processing the file: {ex.Message}");
                return null;
            }
        }

        private static List<Expense> ReadFromTxt(string filePath)
        {
            var expenses = new List<Expense>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 4)
                {
                    expenses.Add(new Expense
                    {
                        Date = DateTime.Parse(parts[0]),
                        Category = parts[1],
                        Amount = decimal.Parse(parts[2]),
                        Description = parts[3]
                    });
                }
            }

            return expenses;
        }

        private static List<Expense> ReadFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Expense>>(jsonContent);
        }
    }
}
