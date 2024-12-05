using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet
{
    public partial class Form4 : Form
    {
        public string ReturnState { get; private set; }

        public Form4()
        {
            InitializeComponent();

            StateComboBox.Items.Add("Excellent");
            StateComboBox.Items.Add("Bon");
            StateComboBox.Items.Add("Abimé");
            StateComboBox.Items.Add("Détruit");
        }

        private void Confirm()
        {

        }
        private void Cancel()
        {

        }
    }
}
