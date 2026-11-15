namespace LibrarySystem
{
    // ABSTRACTION: contract only, no implementation
    public interface IBorrowable
    {
        bool IsAvailable { get; }
        void MarkBorrowed();
        void MarkReturned();
    }
}
