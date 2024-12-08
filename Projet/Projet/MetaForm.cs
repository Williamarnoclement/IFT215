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
    public partial class MetaForm : Form
    {
        public static BookController BookController { get; set; }
        public static UserController UserController { get; set; }
        public static LoanController LoanController {  get; set; }

        public static UserControl form1;
        public static UserControl form2;
        public static UserControl form3;
        public MetaForm()
        {
            BookController = new BookController(new BookRepository());
            UserController = new UserController(new UserRepository());
            LoanController = new LoanController(new LoanRepository(BookController, UserController));
            InitializeComponent();
            InitializePanels();
            form1.Visible = true;
            form2.Visible = false;
            form3.Visible = false;
            Controls.Add(form1);
            Controls.Add(form2);
            Controls.Add(form3);
        }
        private void InitializePanels()
        {
            form1 = new Form1 { Dock = DockStyle.Fill, Visible = true };
            form2 = new Form2 { Dock = DockStyle.Fill, Visible = false };
            form3 = new Form3 { Dock = DockStyle.Fill, Visible = false };
        }
        public static void SwitchPanel(UserControl targetPanel)
        {
            form1.Visible = false;
            form2.Visible = false;
            form3.Visible = false;
            targetPanel.Visible = true;
        }
    }
}
