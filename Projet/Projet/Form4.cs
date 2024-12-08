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

            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(300, 150);
            Text = "Retour de livre";
        }

        private void BouttonConfirmer_Click(object sender, EventArgs e)
        {
            ReturnState = StateComboBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BoutonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void StateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
