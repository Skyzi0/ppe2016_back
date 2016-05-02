using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static bool IsPowerOfTwo(int i)
        {
            return i > 0 && (i & (i - 1)) == 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAccueil x = new FormAccueil();
            x.Show();
            this.Hide();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (IsPowerOfTwo(Decimal.ToInt32(numericUpDown1.Value)) == false || numericUpDown1.Value == 1)
            {
                MessageBox.Show("Le nombre de participant doit être une puissance de 2 (ex: 2, 4, 8, 16 etc...)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MTournois.ajouterTournoi(textBoxName.Text, Decimal.ToInt32(numericUpDown1.Value), description.Text))
                {
                    FormAccueil x = new FormAccueil();
                    x.Show();
                    this.Hide();
                    MessageBox.Show("Votre tournoi '" + textBoxName.Text + "' comportant " + numericUpDown1.Value.ToString() + " participants a bien été créé.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
