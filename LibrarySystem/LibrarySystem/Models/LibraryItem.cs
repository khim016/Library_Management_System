using System;

namespace LibrarySystem
{
    // ABSTRACTION: abstract class, cannot be instantiated
    public abstract class LibraryItem : IBorrowable
    {
        // ENCAPSULATION: all fields are private
        private string itemId;
        private string title;
        private string author;
        private bool isAvailable;

        // CONSTRUCTOR (protected: only subclasses can call it)
        protected LibraryItem(string id, string title, string author)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Item ID is required.");
            this.itemId = id.Trim();
            this.Title = title;      // goes through property validation
            this.Author = author;
            this.isAvailable = true;
        }

        // ENCAPSULATION: public properties with validation
        public string ItemId { get { return itemId; } }

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title is required.");
                title = value.Trim();
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Author is required.");
                author = value.Trim();
            }
        }

        public bool IsAvailable { get { return isAvailable; } }

        // For the DataGridView
        public string Status { get { return isAvailable ? "Available" : "Borrowed"; } }

        // ABSTRACT members: every subclass must override (POLYMORPHISM)
        public abstract string ItemType { get; }
        public abstract int LoanDays { get; }
        public abstract decimal CalculateFine(int daysLate);

        public void MarkBorrowed()
        {
            if (!isAvailable)
                throw new InvalidOperationException("Item is already borrowed.");
            isAvailable = false;
        }

        public void MarkReturned()
        {
            isAvailable = true;
        }

        // virtual: may be overridden, has a default
        public virtual string GetDetails()
        {
            return ItemType + ": " + title + " by " + author;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
