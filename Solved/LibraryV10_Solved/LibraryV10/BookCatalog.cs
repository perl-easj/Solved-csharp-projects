using System;
using System.Collections.Generic;

namespace LibraryV10
{
    public class BookCatalog
    {
        private List<Book> _books;

        public BookCatalog()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book aBook)
        {
            if (LookupBook(aBook.ISBN) == null)
            {
                _books.Add(aBook);
            }
        }

        public void PrintAllBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine(book.AllInformation);
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            foreach (var book in _books)
            {
                if (book.ISBN == isbn)
                {
                    matchingBook = book;
                }
            }

            return matchingBook;
        }
    }
}