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
        Book? selected_book;
        public Form2()
        {
            InitializeComponent();
        }
        public void SetBook(Book book)
        {
            selected_book = book;
            if (book != null)
            {
                label1.Text = selected_book.Title;
            }
        }

        private void manageBookBorrowingsButton_Click(object sender, EventArgs e)
        {
            MetaForm.SwitchPanel(MetaForm.form1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
