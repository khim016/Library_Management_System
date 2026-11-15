using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LibrarySystem
{
    public class Library
    {
        // ENCAPSULATION: private lists
        private List<LibraryItem> items = new List<LibraryItem>();
        private List<Person> borrowers = new List<Person>();
        private List<BorrowTransaction> transactions = new List<BorrowTransaction>();

        // Only read-only views are exposed
        public ReadOnlyCollection<LibraryItem> Items { get { return items.AsReadOnly(); } }
        public ReadOnlyCollection<Person> Borrowers { get { return borrowers.AsReadOnly(); } }
        public ReadOnlyCollection<BorrowTransaction> Transactions { get { return transactions.AsReadOnly(); } }

        // ---------- ITEMS ----------
        public void AddItem(LibraryItem item)
        {
            if (FindItem(item.ItemId) != null)
                throw new InvalidOperationException("Item ID already exists.");
            items.Add(item);
        }

        public void RemoveItem(string id)
        {
            LibraryItem item = FindItem(id);
            if (item == null) return;
            if (!item.IsAvailable)
                throw new InvalidOperationException("Cannot delete an item that is currently borrowed.");
            items.Remove(item);
        }

        public LibraryItem FindItem(string id)
        {
            return items.FirstOrDefault(i => i.ItemId == id);
        }

        public List<LibraryItem> GetAvailableItems()
        {
            return items.Where(i => i.IsAvailable).ToList();
        }

        public List<LibraryItem> SearchItems(string keyword)
        {
            keyword = (keyword ?? "").Trim().ToLower();
            return items.Where(i => i.Title.ToLower().Contains(keyword)
                                 || i.Author.ToLower().Contains(keyword)
                                 || i.ItemId.ToLower().Contains(keyword)).ToList();
        }

        // ---------- BORROWERS ----------
        public void AddBorrower(Person p)
        {
            if (FindBorrower(p.PersonId) != null)
                throw new InvalidOperationException("Borrower ID already exists.");
            borrowers.Add(p);
        }

        public void RemoveBorrower(string id)
        {
            Person p = FindBorrower(id);
            if (p == null) return;
            if (CountActiveLoans(p) > 0)
                throw new InvalidOperationException("Cannot delete a borrower who still has unreturned items.");
            borrowers.Remove(p);
        }

        public Person FindBorrower(string id)
        {
            return borrowers.FirstOrDefault(b => b.PersonId == id);
        }

        public List<Person> SearchBorrowers(string keyword)
        {
            keyword = (keyword ?? "").Trim().ToLower();
            return borrowers.Where(b => b.Name.ToLower().Contains(keyword)
                                     || b.PersonId.ToLower().Contains(keyword)).ToList();
        }

        // ---------- TRANSACTIONS ----------
        public int CountActiveLoans(Person p)
        {
            return transactions.Count(t => !t.IsReturned && t.Borrower == p);
        }

        public BorrowTransaction BorrowItem(Person p, LibraryItem item, DateTime date)
        {
            if (!item.IsAvailable)
                throw new InvalidOperationException("Item is not available.");
            if (CountActiveLoans(p) >= p.MaxItems)   // POLYMORPHISM: Student and Faculty have different limits
                throw new InvalidOperationException(p.Name + " reached the limit of " + p.MaxItems + " items.");

            item.MarkBorrowed();
            string id = "T" + (transactions.Count + 1).ToString("000");
            BorrowTransaction t = new BorrowTransaction(id, p, item, date);
            transactions.Add(t);
            return t;
        }

        public decimal ReturnItem(BorrowTransaction t, DateTime date)
        {
            t.Return(date);
            return t.Fine;
        }

        public List<BorrowTransaction> GetActiveTransactions()
        {
            return transactions.Where(t => !t.IsReturned).ToList();
        }
    }
}
