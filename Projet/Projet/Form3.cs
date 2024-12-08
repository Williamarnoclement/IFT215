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
    public partial class Form3 : UserControl
    {
        private string SearchString = "";
        public Form3()
        {
            InitializeComponent();
            RefreshLoanList();
            MetaForm.LoanController.LoansChanged += RefreshLoanList;
            VisibleChanged += HandleOnVisibleChanged;

        }

        private Panel CreateLoanPanel(Loan loan)
        {
            var bookPanel = new Panel
            {
                Size = new Size(600, 150),
                BackColor = SystemColors.WindowFrame,
                Margin = new Padding(10)
            };
            bookPanel.Controls.Add(new Label
            {
                Text = loan.Book.Title,
                Font = new Font("Segoe UI", 18, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(14, 9),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Text = $"Emprunté par: {loan.User.Name}",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(20, 48),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Text = $"Date de retour: {loan.ReturnDate.ToShortDateString()}",
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(20, 70),
                AutoSize = true
            });


            Button current_button = new Button();
            current_button.Text = "Retourner";
            current_button.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            current_button.BackColor = Color.White;
            current_button.ForeColor = Color.Black;
            current_button.Location = new Point(385, 90);
            current_button.Size = new Size(200, 45);
            current_button.Click += (sender, e) => OpenForm4(loan);

            bookPanel.Controls.Add(current_button);
            return bookPanel;
        }

        private void RefreshLoanList()
        {
            booksFlowLayoutPanel.Controls.Clear();
            foreach (var loan in MetaForm.LoanController.GetLoans())
            {
                if (IsInSearch(loan))
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
                    string returnState = form4.ReturnState;
                    MetaForm.BookController.ModifyBookState(loan.Book, returnState);
                    MetaForm.LoanController.RemoveLoan(loan);
                    RefreshLoanList();
                }
            }
        }

        private void manageBookBorrowingsButton_Click(object sender, EventArgs e)
        {
            MetaForm.SwitchPanel(MetaForm.form1);
        }
        
        private void HandleOnEnter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Recherche")
            {
                searchTextBox.Text = string.Empty;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchString = searchTextBox.Text.ToLower();
            RefreshLoanList();
        }
        private void HandleOnVisibleChanged(object? sender, EventArgs e)
        {
            if (Visible)
            {
                RefreshLoanList();
            }
        }
    }
}
