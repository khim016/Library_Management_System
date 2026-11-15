using System;

namespace LibrarySystem
{
    // INHERITANCE
    public class Thesis : LibraryItem
    {
        public Thesis(string id, string title, string author) : base(id, title, author) { }

        // POLYMORPHISM: overriding
        public override string ItemType { get { return "Thesis"; } }
        public override int LoanDays { get { return 2; } }

        public override decimal CalculateFine(int daysLate)
        {
            if (daysLate <= 0) return 0m;
            return daysLate * 20m;     // P20 per day
        }

        // Example of overriding a virtual method
        public override string GetDetails()
        {
            return "[Reference Only] " + base.GetDetails();
        }
    }
}
