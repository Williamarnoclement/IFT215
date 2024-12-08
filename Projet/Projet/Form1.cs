using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();
            //Rafraichir la liste lorsqu'on a ajouté ou retiré des livres
            searchBookTextBox.TextChanged += SearchTextBoxTextChanged;
            ageComboBox.SelectedIndexChanged += ComboBoxSelectionChanged;
            typeComboBox.SelectedIndexChanged += ComboBoxSelectionChanged;
            RefreshBookList();
            ageComboBox.Items.Add("Tout");
            ageComboBox.Items.AddRange(Enum.GetNames(typeof(AgeGroup)));
            typeComboBox.Items.Add("Tout");
            typeComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            ageComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
            MetaForm.BookController.BooksChanged += RefreshBookList;
            VisibleChanged += HandleOnVisibleChanged;
        }
        private void RefreshBookList()
        {
            booksFlowLayoutPanel.Controls.Clear();
            foreach (var book in MetaForm.BookController.GetBooks())
            {
                booksFlowLayoutPanel.Controls.Add(CreateBookPanel(book));
            }
        }
        private Panel CreateBookPanel(Book book)
        {
            var bookPanel = new Panel
            {
                Size = new Size(460, 140),
                BackColor = SystemColors.WindowFrame,
                Margin = new Padding(10),
                Tag = book
            };
            bookPanel.Controls.Add(new Label
            {
                Name = "bookTitleLabel",
                Text = book.Title,
                Font = new Font("Segoe UI", 18, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(14, 9),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Name = "bookAuthorLabel",
                Text = book.Author,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(16, 40),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Name = "bookAgeGroupLabel",
                Text = $"Âge: {book.AgeGroup}",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Italic),
                ForeColor = Color.LightGray,
                Location = new Point(20, 68),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Name = "bookCategoryLabel",
                Text = $"Catégorie: {book.Category}",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Italic),
                ForeColor = Color.LightGray,
                Location = new Point(20, 88),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Name = "bookCategoryLabel",
                Text = $"État: {book.State}",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Italic),
                ForeColor = Color.LightGray,
                Location = new Point(20, 110),
                AutoSize = true
            });
            //Livre réservé
            Loan? loan = MetaForm.LoanController.GetLoans().Where(x => x.Book == book).FirstOrDefault();
            if (loan != null)
            {
                bookPanel.Controls.Add(new Label
                {
                    Name = "bookCategoryLabel",
                    Text = $"Réservé Jusqu'au:\n         {loan.ReturnDate.ToString("dd/MM/yyyy")}",
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                    ForeColor = Color.White,
                    Location = new Point(255, 90),
                    AutoSize = true
                });
            }
            else
            {
                Button current_button = new Button();
                current_button.Text = "Réserver";
                current_button.Font = new Font("Segoe UI", 18, FontStyle.Regular);
                current_button.BackColor = Color.White;
                current_button.ForeColor = Color.Black;
                current_button.Location = new Point(255, 90);
                current_button.Size = new Size(199, 43);
                current_button.Click += (sender, e) => OpenForm2WithBook(book);

                bookPanel.Controls.Add(current_button);
            }
            
            return bookPanel;
        }
        //Permet de recharger la liste lorsque le composant redevient visible
        private void HandleOnVisibleChanged(object? sender, EventArgs e)
        {
            if (Visible)
            {
                RefreshBookList();
            }
        }
        private void SearchTextBoxTextChanged(object? sender, EventArgs e)
        {
            FilterBooks(searchBookTextBox.Text);
        }
        private void ComboBoxSelectionChanged(object? sender, EventArgs e)
        {
            FilterBooks(searchBookTextBox.Text);
        }
        private void FilterBooks(string searchText)
        {
            searchText = searchText.ToLower();
            AgeGroup? selectedAge = ageComboBox.SelectedItem != null && ageComboBox.SelectedItem.ToString() != "Tout"
                ? Enum.Parse<AgeGroup>(ageComboBox.SelectedItem.ToString())
                : null;
            Category? selectedCategory = typeComboBox.SelectedItem != null && typeComboBox.SelectedItem.ToString() != "Tout"
                ? Enum.Parse<Category>(typeComboBox.SelectedItem.ToString())
                : null;
            foreach (Control panel in booksFlowLayoutPanel.Controls)
            {
                if (panel is Panel bookPanel)
                {
                    Book book = bookPanel.Tag as Book;
                    if (book != null)
                    {
                        bool matchesSearch = string.IsNullOrWhiteSpace(searchText) ||
                                             book.Title.ToLower().Contains(searchText) ||
                                             book.Author.ToLower().Contains(searchText);
                        bool matchesAge = !selectedAge.HasValue || book.AgeGroup == selectedAge;
                        bool matchesCategory = !selectedCategory.HasValue || book.Category == selectedCategory;
                        bookPanel.Visible = matchesSearch && matchesAge && matchesCategory;
                    }
                }
            }
        }
        private void OpenForm2WithBook(Book book)
        {
            if (MetaForm.form2 is Form2 form2)
            {
                form2.SetBook(book);
                MetaForm.SwitchPanel(MetaForm.form2);
            }
        }
        private void manageBookBorrowingsButton_Click(object sender, EventArgs e)
        {
            MetaForm.SwitchPanel(MetaForm.form3);
        }

        private void searchBookTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
