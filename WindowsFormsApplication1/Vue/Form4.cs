using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classe;
using WindowsFormsApplication1.Modele;

namespace WindowsFormsApplication1.Vue
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Collection<Produit> lesProduits = MStock.getProduits();
        

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Produit leProduit in lesProduits)
            {
                dataGridView1.Rows.Add(leProduit.getId().ToString(), leProduit.getName(), leProduit.getType(), leProduit.getDesc(), leProduit.getPrix().ToString(), leProduit.getStock().ToString(), leProduit.getPicture());
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataGridView listProduit = sender as DataGridView;
            Collection<Produit> lesNouveauxProduits = new Collection<Produit>();
            foreach(DataGridViewRow CurrentRow in dataGridView1.Rows)
            {
                if(CurrentRow.Cells[1].Value != null)
                {
                    Produit produit = new Produit(int.Parse(CurrentRow.Cells[0].Value.ToString()), CurrentRow.Cells[1].Value.ToString(),
                        CurrentRow.Cells[2].Value.ToString(), CurrentRow.Cells[3].Value.ToString(),
                        int.Parse(CurrentRow.Cells[4].Value.ToString()), int.Parse(CurrentRow.Cells[5].Value.ToString()),
                        CurrentRow.Cells[6].Value.ToString());
                    lesNouveauxProduits.Add(produit);
                }
            }

            MStock.updateProduit(lesNouveauxProduits);
            this.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAccueil form = new FormAccueil();
            form.Show();
            this.Hide();
        }
    }
}
