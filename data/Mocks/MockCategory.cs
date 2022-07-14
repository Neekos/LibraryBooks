using libraryBooks.data.Interfaces;
using libraryBooks.data.Models;
using System.Collections.Generic;

namespace libraryBooks.data.Mocks
{
    internal class MockCategory : ICategoryBooks
    {
        public IEnumerable<Category> AllCategory {
            get
            {
                return new List<Category>{
                    new Category{CategoryName="Роман", Desc="Классические романы" },
                    new Category{CategoryName="Фантастика", Desc="Фентази истории" }
                };
            }
        }
    }
}
