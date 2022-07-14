using libraryBooks.data.Interfaces;
using libraryBooks.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace libraryBooks.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allbooks;
        private readonly ICategoryBooks _allcategory;


        public BooksController(ICategoryBooks iallcat, IAllBooks iallbooks)
        {
            _allbooks = iallbooks;
            _allcategory = iallcat;
        }

        public ViewResult List() {
            ViewBag.Title = "Все книги";
            BooksListViewModel obj = new BooksListViewModel();
            obj.MyAllBooks = _allbooks.Books;
            obj.currCategory = "Книги";
            return View(obj);
        }
    }
}
