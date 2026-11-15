# Library Borrowing Management System

OOP Final Project - C# Windows Forms (SharpDevelop 4.x / .NET Framework 4.0, C# 5)

## Group Members
| Member | Responsibilities |
|---|---|
| Member 1 | LibraryItem, Book, Magazine, Thesis, IBorrowable, frmItems, frmMain |
| Member 2 | Person, Student, Faculty, frmBorrowers, frmTransactions, Documentation + Class Diagram |
| Member 3 | BorrowTransaction, Library, DataStore, frmBorrow, frmReturn, Canva slides |

*(Replace with your real names.)*

## How to Run
1. Open `LibrarySystem.sln` in SharpDevelop (or Visual Studio).
2. Press **F5** (Build > Run).
3. No database needed - data is stored in memory (`List<T>`) and resets on exit.
   The system starts with sample data (4 items, 2 borrowers).

## Features
- Add / update / delete / search library items (Book, Magazine, Thesis)
- Register / update / delete / search borrowers (Student, Faculty)
- Borrow items with automatic due date (Book 7 days, Magazine 3 days, Thesis 2 days)
- Borrowing limits (Student 3 items, Faculty 5 items)
- Return items with automatic fine (Book P5/day, Magazine P10/day, Thesis P20/day; Faculty gets 50% off)
- Live fine preview before returning
- Transaction history and live status bar on the main menu

## Four Pillars of OOP
| Pillar | Where |
|---|---|
| Encapsulation | Private fields + validated properties (`LibraryItem.Title`, `Person.Name`); `Library` exposes `ReadOnlyCollection` only |
| Inheritance | `Book/Magazine/Thesis : LibraryItem`, `Student/Faculty : Person` |
| Polymorphism | `CalculateFine()`, `LoanDays`, `MaxItems`, `GetDiscountedFine()` overridden per subclass; `LibraryItem item = new Book(...)` |
| Abstraction | `abstract class LibraryItem`, `abstract class Person`, `interface IBorrowable` |

## Folder Structure
```
LibrarySystem/
├── README.md
├── LibrarySystem.sln
├── .gitignore
├── LibrarySystem/
│   ├── Models/      <- LibraryItem, Book, Person, Library, ...
│   ├── Forms/       <- frmMain, frmItems, ... (+ .Designer.cs)
│   ├── Properties/
│   ├── DataStore.cs
│   ├── Program.cs
│   └── LibrarySystem.csproj
└── Documentation/
    ├── ProjectDocumentation.md
    └── ClassDiagram.mmd
```
