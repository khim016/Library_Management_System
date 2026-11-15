using System;

namespace LibrarySystem
{
    // INHERITANCE
    public class Magazine : LibraryItem
    {
        public Magazine(string id, string title, string author) : base(id, title, author) { }

        // POLYMORPHISM: overriding
        public override string ItemType { get { return "Magazine"; } }
        public override int LoanDays { get { return 3; } }

        public override decimal CalculateFine(int daysLate)
        {
            if (daysLate <= 0) return 0m;
            return daysLate * 10m;     // P10 per day
        }
    }
}
