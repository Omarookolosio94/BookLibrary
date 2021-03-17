using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookLibrary.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books;

        public DbClient(IOptions<BookLibraryDBConfig> bookLibraryDBConfig)
        {
            var client = new MongoClient(bookLibraryDBConfig.Value.Connection_String);
            var database = client.GetDatabase(bookLibraryDBConfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookLibraryDBConfig.Value.Books_Collection_Name);
        }

        public IMongoCollection<Book> GetBooksCollection() => _books;
    }
}
