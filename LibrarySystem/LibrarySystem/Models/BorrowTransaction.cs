using System;
using System.ComponentModel;

namespace LibrarySystem
{
    public class BorrowTransaction
    {
        private string transactionId;
        private Person borrower;
        private LibraryItem item;
        private DateTime borrowDate;
        private DateTime dueDate;
        private DateTime? returnDate;
        private decimal fine;
        private bool isReturned;

        public BorrowTransaction(string id, Person borrower, LibraryItem item, DateTime borrowDate)
        {
            this.transactionId = id;
            this.borrower = borrower;
            this.item = item;
            this.borrowDate = borrowDate.Date;
            this.dueDate = borrowDate.Date.AddDays(item.LoanDays);  // polymorphic: depends on item type
            this.isReturned = false;
        }

        // [Browsable(false)] = not shown as a DataGridView column
        [Browsable(false)] public Person Borrower { get { return borrower; } }
        [Browsable(false)] public LibraryItem Item { get { return item; } }
        [Browsable(false)] public bool IsReturned { get { return isReturned; } }

        public string TransactionId { get { return transactionId; } }
        public string BorrowerName { get { return borrower.Name; } }
        public string ItemTitle { get { return item.Title; } }
        public string ItemType { get { return item.ItemType; } }
        public DateTime BorrowDate { get { return borrowDate; } }
        public DateTime DueDate { get { return dueDate; } }
        public DateTime? ReturnDate { get { return returnDate; } }
        public decimal Fine { get { return fine; } }
        public string Status { get { return isReturned ? "Returned" : "Borrowed"; } }

        // Computes the fine only (does not record it)
        public decimal PreviewFine(DateTime date)
        {
            int daysLate = (date.Date - dueDate).Days;
            decimal baseFine = item.CalculateFine(daysLate);        // POLYMORPHISM (item)
            return borrower.GetDiscountedFine(baseFine);            // POLYMORPHISM (borrower)
        }

        public void Return(DateTime date)
        {
            if (isReturned)
                throw new InvalidOperationException("This item was already returned.");
            if (date.Date < borrowDate)
                throw new ArgumentException("Return date cannot be earlier than the borrow date.");

            fine = PreviewFine(date);
            returnDate = date.Date;
            isReturned = true;
            item.MarkReturned();
        }
    }
}
