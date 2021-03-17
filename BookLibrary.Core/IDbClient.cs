using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Core
{
    public interface IDbClient
    {
        IMongoCollection<Book> GetBooksCollection();
    }
}
