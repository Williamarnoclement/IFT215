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
    public partial class Form1 : Form
    {
        private BookController bookController;
        public Form1()
        {
            InitializeComponent();
            var bookRepository = new BookRepository();
            bookController = new BookController(bookRepository);
            bookRepository.BooksChanged += RefreshBookList;
            bookController.AddBook(new Book("Titre du livre 1", "Auteur 1"));
            bookController.AddBook(new Book("Titre du livre 2", "Auteur 2"));
            bookController.AddBook(new Book("Titre du livre 3", "Auteur 3"));
            RefreshBookList();
            ageComboBox.Items.AddRange(new string[] { "Enfant", "Adolescent", "Adulte" });
            typeComboBox.Items.AddRange(new string[] { "Policier", "Aventure", "Action", "Science", "Science-Fiction", "Mathématique", "Course" });
            ageComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
        }
        private void RefreshBookList()
        {
            booksFlowLayoutPanel.Controls.Clear();
            foreach (var book in bookController.GetBooks())
            {
                booksFlowLayoutPanel.Controls.Add(CreateBookPanel(book));
            }
        }
        private Panel CreateBookPanel(Book book)
        {
            var bookPanel = new Panel
            {
                Size = new Size(467, 122),
                BackColor = SystemColors.WindowFrame,
                Margin = new Padding(10)
            };
            bookPanel.Controls.Add(new Label
            {
                Text = book.Title,
                Font = new Font("Segoe UI", 18, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(13, 9),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Label
            {
                Text = book.Author,
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(13, 48),
                AutoSize = true
            });
            bookPanel.Controls.Add(new Button
            {
                Text = "Réserver",
                Font = new Font("Segoe UI", 18, FontStyle.Regular),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Location = new Point(262, 70),
                Size = new Size(199, 43)
            });
            return bookPanel;
        }
    }
}
