using System;
using System.Collections.Generic;

namespace LibraryV11
{
    /// <summary>
    /// This class represents a collection of Book objects,
    /// for instance the books in a library
    /// </summary>
    public class BookCatalog
    {
        #region Instance fields
        private Dictionary<string, Book> _books;
        #endregion

        #region Constructor
        public BookCatalog()
        {
            _books = new Dictionary<string, Book>();
        }
        #endregion

        #region Methods
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
        #endregion
    }
}