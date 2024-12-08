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
            //Permettre au View de savoir quand se rafraichir
            bookRepository.BooksChanged += this.BooksChanged;
            bookRepository.BooksChanged += test;
        }
        public void ModifyBookState(Book book, string state) => BookRepository.ModifyBookState(book, state);
        public List<Book> GetBooks() => BookRepository.GetAllBooks();
        public void AddBook(Book book) => BookRepository.AddBook(book);
        public void RemoveBook(Book book) => BookRepository.RemoveBook(book);
        public event Action? BooksChanged;
        public void test()
        {

        }
    }
}
