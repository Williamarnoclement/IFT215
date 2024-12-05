using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class LoanController
    {
        private readonly LoanRepository LoanRepository;
        public LoanController(LoanRepository loanRepository)
        {
            LoanRepository = loanRepository;
        }

        public List<Loan> GetLoans() => LoanRepository.GetAllLoans();
        public void AddLoan(Loan loan) => LoanRepository.AddLoan(loan);
        public void RemoveLoan(Loan loan) => LoanRepository.RemoveLoan(loan);
    }
}
