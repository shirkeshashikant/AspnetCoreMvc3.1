using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebGental.BookStore.Models;

namespace WebGental.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllbooks()
        {
            return Datasource();

        }
        public BookModel GetBookbyid(int id)
        {

            return Datasource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> Searchbook(string title,string Authorname)
        {
            return Datasource().Where(x => x.Title.Contains(title) && x.Author.Contains(Authorname)).ToList();

        }
        private List<BookModel>  Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1,Title="MVC",Author="Nitesh"},
                new BookModel(){ Id=2,Title="ASP",Author="Nitesh"},
                new BookModel(){ Id=3,Title="PHP",Author="Shashikant"},
                new BookModel(){ Id=4,Title="JAVA",Author="Komal"},
                new BookModel(){ Id=5,Title="C#",Author="Suvarna"}

            };
         }

    }
}
