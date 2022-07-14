using libraryBooks.data.Models;
using System.Collections.Generic;

namespace libraryBooks.data.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Books> Books { get; }
        IEnumerable<Books> FavBook { get; set; }

        Books GetObjectBooks(int id);
    }
}
