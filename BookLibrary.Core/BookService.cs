using System;
using System.Collections.Generic;

namespace BookLibrary.Core
{
    public class BookService : IBookService
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "Book One",
                    Author = "Dev Developer",
                    Category = "Web Design"
                }
            };
        }
    }
}
