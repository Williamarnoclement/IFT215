using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class BookController
    {
        private readonly BookRepository BookRepository;
        public BookController(BookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }
        public List<Book> GetBooks() => BookRepository.GetAllBooks();
        public void AddBook(Book book) => BookRepository.AddBook(book);
        public void RemoveBook(Book book) => BookRepository.RemoveBook(book);
    }
}
