using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libraryBooks.data.Models
{
    public class Books
    {
        public int id { set; get; }
        public string NameBook { set; get; }
        public string Description { set; get; }
        public string Img { set; get; }
        public string CategoryID { set; get; }
        public bool FavBook { get; set; }
        public int available { get; set; }
        public virtual Category Category { set; get; }
        public List<Books> Book { set; get; }
    }
}
