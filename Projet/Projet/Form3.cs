using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Projet
{
    public partial class Form3 : Form
    {
        private LoanController loanController;
        private BookController bookController;
        private string SearchString = "";
        public Form3()
        {
            InitializeComponent();
            var loanRepository = new LoanRepository();
            loanController = new LoanController(loanRepository);
            loanController.AddLoan(new Loan(new Book("le roi lion", "Jeff", AgeGroup.Adulte, Category.Mathematique), new User("JeanGuy")));
            RefreshLoanList();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(HandleKeyDown);
            searchTextBox.Enter += new EventHandler(HandleOnEnter);
        }
        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                SearchString = searchTextBox.Text.ToLower();
                RefreshLoanList();
            }
        }
        private Panel CreateLoanPanel(Loan loan)
        {
            var bookPanel = new Panel
            {
                Size = new Size(467, 122),
                BackColor = SystemColors.WindowFrame,
                Margin = new Padding(10)
            };
            bookPanel.Controls.Add(new Label
            {
                Text = loan.Book.Title,
                Font = new Font("Segoe UI", 18, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(13, 9),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Text = loan.User.Name,
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(13, 48),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Text = loan.ReturnDate.ToShortDateString(),
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(13, 60),
                AutoSize = true
            });


            Button current_button = new Button();
            current_button.Text = "Retourner";
            current_button.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            current_button.BackColor = Color.White;
            current_button.ForeColor = Color.Black;
            current_button.Location = new Point(262, 70);
            current_button.Size = new Size(199, 43);
            current_button.Click += (sender, e) => OpenForm4(loan);

            bookPanel.Controls.Add(current_button);
            return bookPanel;
        }

        private void RefreshLoanList()
        {
            booksFlowLayoutPanel.Controls.Clear();
            foreach (var loan in loanController.GetLoans())
            {
                if(IsInSearch(loan))
                    booksFlowLayoutPanel.Controls.Add(CreateLoanPanel(loan));
            }
        }
        private bool IsInSearch(Loan loan)
        {
            return string.IsNullOrEmpty(SearchString) || loan.User.Name.ToLower().Contains(SearchString) || loan.Book.Title.ToLower().Contains(SearchString);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void OpenForm4(Loan loan)
        {
            using (var form4 = new Form4())
            {
                if (form4.ShowDialog() == DialogResult.OK)
                {
                    //TODO Gérer le returnState
                    string returnState = form4.ReturnState;

                    loanController.RemoveLoan(loan);
                    RefreshLoanList();
                }
            }
        }
        private void HandleOnEnter(object sender, EventArgs e)
        {
            if(searchTextBox.Text == "Recherche")
            {
                searchTextBox.Text = string.Empty;
            }
        }
    }
}
