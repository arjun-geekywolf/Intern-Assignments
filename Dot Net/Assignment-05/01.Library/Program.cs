

using Library.Books;
using Library.Members;
using Library.Transactions;

Book book = new Book();
Magazine magazine = new Magazine();
Journal journal = new Journal();

Librarian librarian = new Librarian();
Member member = new Member();

BorrowTransaction borrowTransaction = new BorrowTransaction();
ReturnTrasaction returnTrasaction = new ReturnTrasaction();

book.Info();
magazine.Info();
journal.Info();

librarian.Details();
member.Details();

borrowTransaction.Borrow();
returnTrasaction.Return();
