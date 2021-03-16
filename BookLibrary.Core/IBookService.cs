using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Core
{
    public interface IBookService
    {
        List<Book> GetBooks();

    }
}
