using System;
using System.Collections.Generic;

namespace LibraryV10
{
    /// <summary>
    /// This class represents a collection of Book objects,
    /// for instance the books in a library
    /// </summary>
    public class BookCatalog
    {
        #region Instance fields
        private List<Book> _books;
        #endregion

        #region Constructor
        public BookCatalog()
        {
            _books = new List<Book>();
        }
        #endregion

        #region Methods
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
        #endregion
    }
}