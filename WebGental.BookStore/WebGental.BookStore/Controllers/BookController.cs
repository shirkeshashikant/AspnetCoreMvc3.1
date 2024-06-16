using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebGental.BookStore.Models;
using WebGental.BookStore.Repository;

namespace WebGental.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllbook()
        {
            return _bookRepository.GetAllbooks();
        }
        public BookModel Getbook( int id)
        {
            return _bookRepository.GetBookbyid(id);
        }
        public List<BookModel> Searchbook(string bookName,string AuthorName)
        {
            return _bookRepository.Searchbook(bookName, AuthorName);
        }
    }
}
