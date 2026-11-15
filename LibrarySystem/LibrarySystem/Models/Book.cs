using System;

namespace LibrarySystem
{
    // INHERITANCE
    public class Book : LibraryItem
    {
        public Book(string id, string title, string author) : base(id, title, author) { }

        // POLYMORPHISM: overriding
        public override string ItemType { get { return "Book"; } }
        public override int LoanDays { get { return 7; } }

        public override decimal CalculateFine(int daysLate)
        {
            if (daysLate <= 0) return 0m;
            return daysLate * 5m;     // P5 per day
        }
    }
}
