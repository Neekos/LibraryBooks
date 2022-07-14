using libraryBooks.data.Models;
using System;
using System.Collections.Generic;

namespace libraryBooks.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Books> MyAllBooks { get; set; }
        public string currCategory { get; set; }
    }
}
