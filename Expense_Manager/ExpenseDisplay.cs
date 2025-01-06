using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Expense_Manager
{
    public class ExpenseDisplay
    {
        public static void ShowExpenses(List<Expense> expenses)
        {
            if (expenses == null || expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded yet.");
                return;
            }

            // Set culture to ensure correct currency formatting
            CultureInfo culture = new CultureInfo("en-US"); // Change to "en-IN" for ₹, etc.

            Console.WriteLine("Date       | Category      | Amount   | Description");
            Console.WriteLine("----------------------------------------------------");

            foreach (var expense in expenses)
            {
                Console.WriteLine($"{expense.Date:yyyy-MM-dd} | {expense.Category,-12} | {expense.Amount.ToString("C", culture),-8} | {expense.Description}");
            }
        }

        public static void ShowMenu(List<Expense> expenses)
        {
            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Filter by Category");
                Console.WriteLine("2. Filter by Date Range");
                Console.WriteLine("3. Return to Main Menu");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FilterByCategory(expenses);
                        break;
                    case "2":
                        FilterByDateRange(expenses);
                        break;
                    case "3":
                        return;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void FilterByCategory(List<Expense> expenses)
        {
            Console.Write("Enter the category to filter: ");
            string category = Console.ReadLine();

            var filtered = expenses.Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            ShowExpenses(filtered);
        }

        private static void FilterByDateRange(List<Expense> expenses)
        {
            Console.Write("Enter the start date (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the end date (yyyy-MM-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            var filtered = expenses.Where(e => e.Date >= startDate && e.Date <= endDate).ToList();
            ShowExpenses(filtered);
        }
    }
}
