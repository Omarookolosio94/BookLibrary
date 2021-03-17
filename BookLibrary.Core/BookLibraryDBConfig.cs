using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Core
{
    public class BookLibraryDBConfig
    {
        public string Database_Name { get; set; }
        public string Books_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
