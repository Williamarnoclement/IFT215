using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class LoanRepository
    {
        //TODO Ajouter des emprunts
        private List<Loan> Loans = new List<Loan>();

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
