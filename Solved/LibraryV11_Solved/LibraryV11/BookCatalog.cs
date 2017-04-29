using System;
using System.Collections.Generic;

namespace LibraryV11
{
    public class BookCatalog
    {
        private Dictionary<string, Book> _books;

        public BookCatalog()
        {
            _books = new Dictionary<string, Book>();
        }

        public void AddBook(Book aBook)
        {
            _books.Add(aBook.ISBN, aBook);
        }

        public void PrintAllBooks()
        {
            foreach (var bookKeyValue in _books)
            {
                Console.WriteLine(bookKeyValue.Value.AllInformation);
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            if (_books.ContainsKey(isbn))
            {
                matchingBook = _books[isbn];
            }

            return matchingBook;
        }
    }
}