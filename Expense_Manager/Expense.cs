using System;

namespace Expense_Manager
{
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
