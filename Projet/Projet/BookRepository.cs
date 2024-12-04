using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        public event Action? BooksChanged;
        public List<Book> GetAllBooks() => books;
        public void AddBook(Book book)
        {
            books.Add(book);
            BooksChanged?.Invoke();
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
            BooksChanged?.Invoke();
        }
    }
}
