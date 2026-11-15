namespace LibrarySystem
{
    // INHERITANCE
    public class Faculty : Person
    {
        public Faculty(string id, string name, string contact) : base(id, name, contact) { }

        public override string BorrowerType { get { return "Faculty"; } }
        public override int MaxItems { get { return 5; } }

        // POLYMORPHISM: 50% fine discount for faculty
        public override decimal GetDiscountedFine(decimal fine)
        {
            return fine * 0.5m;
        }
    }
}
