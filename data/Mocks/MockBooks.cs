using libraryBooks.data.Interfaces;
using libraryBooks.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libraryBooks.data.Mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly ICategoryBooks _categoryBooks = new MockCategory();
        public IEnumerable<Books> Books {
            get { 
                return new List<Books>{ 
                    new Books { NameBook="Кафка на пляже", Description="Роман Мураками", Img="" ,available=5, Category=_categoryBooks.AllCategory.First()},
                    new Books { NameBook="Властели колец", Description="Фентези путешействия, гломы и тд", Img="", available=2 , Category=_categoryBooks.AllCategory.Last()}
                };
            }
        }
        public IEnumerable<Books> FavBook { get; set ; }

        public Books GetObjectBooks(int id)
        {
            throw new NotImplementedException();
        }
    }
}
