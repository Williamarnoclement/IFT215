using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public class BookController
    {
        private readonly BookRepository BookRepository;
        private Button b;
        public BookController(BookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }

        public void setButton(Button my_buton) {
            b = my_buton;
        }
        public List<Book> GetBooks() => BookRepository.GetAllBooks();
        public void AddBook(Book book) => BookRepository.AddBook(book);
        public void RemoveBook(Book book) => BookRepository.RemoveBook(book);
    }
}
