using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Form2 : UserControl
    {
        Book? SelectedBook;
        User? SelectedUser;
        DateTime startDate;
        DateTime endDate;
        public Form2()
        {
            InitializeComponent();
            SetStartDate();
            SetEndDate();
            radioButton1.CheckedChanged += OnRadioButtonChange;
            radioButton2.CheckedChanged += OnRadioButtonChange;
            radioButton3.CheckedChanged += OnRadioButtonChange;
            AddUserSelection();
            userComboBox.SelectedValueChanged += HandleUserChanged;
            SelectedUser = null;
            SetUserInformation();
        }
        public void SetBook(Book book)
        {
            SelectedBook = book;
            if (book != null)
            {
                titleLabel.Text = SelectedBook.Title;
            }
        }
        private void SetStartDate()
        {
            startDate = DateTime.Now;
            startDateLabel.Text = startDate.ToString("dd/MM/yyyy");
        }
        private void SetEndDate()
        {
            endDate = startDate;
            if (radioButton1.Checked)
            {
                endDate = endDate.AddDays(7);
            }
            else if (radioButton2.Checked)
            {
                endDate = endDate.AddMonths(1);
            }
            else if (radioButton3.Checked)
            {
                endDate = endDate.AddMonths(2);
            }
            endDateLabel.Text = endDate.ToString("dd/MM/yyyy");
        }

        private void OnRadioButtonChange(object sender, EventArgs e)
        {
            SetEndDate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetaForm.SwitchPanel(MetaForm.form3);
        }
        private void AddUserSelection()
        {
            userComboBox.Items.Clear();
            userComboBox.Items.AddRange(MetaForm.UserController.GetAllUsers().Select(x => x.Name).ToArray());
        }
        private void SetUserInformation()
        {
            List<User> users = MetaForm.UserController.GetAllUsers();
            User? selectedUser = users.Where(x => x.Name == userComboBox.Text).FirstOrDefault();
            if (selectedUser != null)
            {
                SelectedUser = selectedUser;
                emailLabel.Text = selectedUser.Email;
                nameLabel.Text = selectedUser.Name;
                phoneLabel.Text = selectedUser.PhoneNumber;
            }
            else
            {
                SelectedUser = null;
                emailLabel.Text = "";
                nameLabel.Text = "";
                phoneLabel.Text = "";
            }


        }
        private void HandleUserChanged(object sender, EventArgs e)
        {
            SetUserInformation();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedBook != null && SelectedUser != null)
            {
                MetaForm.LoanController.AddLoan(new Loan(SelectedBook, SelectedUser, endDate));
                MetaForm.SwitchPanel(MetaForm.form1);
            }
        }

        private void manageBookBorrowingsButton_Click(object sender, EventArgs e)
        {
            MetaForm.SwitchPanel(MetaForm.form1);
        }
    }
}
