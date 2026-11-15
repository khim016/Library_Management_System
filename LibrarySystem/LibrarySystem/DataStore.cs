using System;

namespace LibrarySystem
{
    // One shared Library object for all forms
    public static class DataStore
    {
        public static Library Lib = new Library();

        static DataStore()
        {
            // Sample data so the demo is not empty
            Lib.AddItem(new Book("B001", "Clean Code", "Robert Martin"));
            Lib.AddItem(new Book("B002", "Introduction to Algorithms", "Thomas Cormen"));
            Lib.AddItem(new Book("B003", "Harry Potter and the Sorcerer's Stone", "J.K. Rowling"));
            Lib.AddItem(new Book("B004", "The Little Prince", "Antoine de Saint-Exupéry"));
            Lib.AddItem(new Magazine("M001", "National Geographic", "NatGeo Society"));
            Lib.AddItem(new Thesis("T001", "Inventory System Design", "Juan Dela Cruz"));
            Lib.AddItem(new Book("NM001", "Noli Me Tangere", "Jose Rizal"));

            Lib.AddBorrower(new Student("S001", "Maria Santos", "09171234567"));
            Lib.AddBorrower(new Faculty("F002", "Prof. Reyes", "09981234567"));
            Lib.AddBorrower(new Faculty("kL003", "Khim Maldia", "09063969656"));
            Lib.AddBorrower(new Faculty("JY004", "Jhandy M. Paguinto", "09761690568"));
            Lib.AddBorrower(new Faculty("J005", "Jared Ricarte", "09872345127"));
            Lib.AddBorrower(new Faculty("CJ006", "Chris Julian Ornedo", "09765645321"));
            
        }
    }
}
