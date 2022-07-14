using libraryBooks.data.Models;
using System.Collections.Generic;

namespace libraryBooks.data.Interfaces
{
    public interface ICategoryBooks
    {
        IEnumerable<Category> AllCategory { get; }
        
    }
}
