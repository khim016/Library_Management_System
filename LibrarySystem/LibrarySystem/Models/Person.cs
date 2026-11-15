using System;

namespace LibrarySystem
{
    // ABSTRACTION: base class of all borrowers
    public abstract class Person
    {
        // ENCAPSULATION
        private string personId;
        private string name;
        private string contact;

        protected Person(string id, string name, string contact)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Borrower ID is required.");
            this.personId = id.Trim();
            this.Name = name;
            this.Contact = contact;
        }

        public string PersonId { get { return personId; } }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name is required.");
                name = value.Trim();
            }
        }

        public string Contact
        {
            get { return contact; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Contact is required.");
                contact = value.Trim();
            }
        }

        public abstract string BorrowerType { get; }
        public abstract int MaxItems { get; }

        // virtual: default is no discount
        public virtual decimal GetDiscountedFine(decimal fine)
        {
            return fine;
        }

        public virtual string GetInfo()
        {
            return BorrowerType + ": " + name + " (" + personId + ")";
        }

        public override string ToString()
        {
            return name;
        }
    }
}
