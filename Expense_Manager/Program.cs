using System;

namespace Expense_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Expense Manager!");
            Console.WriteLine("Enter the file path of the expense data:");

            string filePath = Console.ReadLine();

            var expenses = FileHandler.ReadExpenses(filePath);

            if (expenses != null)
            {
                ExpenseDisplay.ShowExpenses(expenses);
                ExpenseDisplay.ShowMenu(expenses);
            }
        }
    }
}
