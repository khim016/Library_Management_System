namespace LibrarySystem
{
    // INHERITANCE
    public class Student : Person
    {
        public Student(string id, string name, string contact) : base(id, name, contact) { }

        public override string BorrowerType { get { return "Student"; } }
        public override int MaxItems { get { return 3; } }
    }
}
