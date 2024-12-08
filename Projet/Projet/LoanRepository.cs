using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class LoanRepository
    {
        private List<Loan> Loans {  get; set; }
        public LoanRepository(BookController books, UserController users) 
        {
            //Juste pour avoir des données tests
            List<Book> bookList = books.GetBooks();
            List<User> userList = users.GetUsers();

            Loans = new List<Loan>
            {
                new Loan(bookList[2], userList[1]),
                new Loan(bookList[3], userList[1]),
                new Loan(bookList[0], userList[3]),
                new Loan(bookList[4], userList[4]),
            };
        }

        public event Action? LoansChanged;
        public List<Loan> GetAllLoans() => Loans;
        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
            LoansChanged?.Invoke();
        }
        public void RemoveLoan(Loan loan)
        {
            Loans.Remove(loan);
            LoansChanged?.Invoke();
        }
    }
}
