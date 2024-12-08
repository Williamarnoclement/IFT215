using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>
        {
            new Book("Pat-Patrouille", "Patrick Patrouille", AgeGroup.Enfant, Category.Policier),
            new Book("Les Explorateurs", "Jérémy A.", AgeGroup.Adolescent, Category.Science),
            new Book("Les Aventure de Bilbon", "J.K. Rowling", AgeGroup.Adulte, Category.Aventure),
            new Book("Bilbon 2: Electric Boogaloo", "J.K. Rowling", AgeGroup.Adulte, Category.Aventure),
            new Book("Bible", "Jésus", AgeGroup.Adulte, Category.ScienceFiction),
            new Book("Planet Wars", "Lucas George", AgeGroup.Adolescent, Category.ScienceFiction),
            new Book("Oui-Oui dans l'espace", "Jésus", AgeGroup.Enfant, Category.ScienceFiction),

        };
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
        public void ModifyBookState(Book book, string state)
        {
            int index = books.FindIndex(b => b.Equals(book));

            if (index != -1)
            {
                books[index].State = state;
                BooksChanged?.Invoke();
            }
        }
    }
}
