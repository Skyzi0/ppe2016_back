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
using WindowsFormsApplication1;
using WindowsFormsApplication1.Modele;
using WindowsFormsApplication1.Vue;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Collection<Tournoi> lesTournois = MTournois.GetTournois();

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Tournoi leTournoi in lesTournois)
            {
                String etat;
                if (MParticipant.GetParticipants(leTournoi.getIdTournoi()).Count == leTournoi.getnbParticipant())
                {
                    etat = "Inscriptions closes";
                }
                else
                {
                    etat = "Inscriptions ouvertes";
                }
                dataGridView1.Rows.Add(leTournoi.getIdTournoi(), leTournoi.getnomTournoi(), leTournoi.getnbParticipant(), etat, leTournoi.getDescTournoi());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView listeTournoi = sender as DataGridView;
            int rowIndex = e.RowIndex;
            Tournoi leTournoi = null;


            foreach (Tournoi unTournoi in lesTournois)
            {
                if (unTournoi.getIdTournoi() == Int32.Parse(listeTournoi.Rows[rowIndex].Cells[0].Value.ToString()))
                {
                    leTournoi = unTournoi;
                }
            }


            if (listeTournoi.CurrentRow.Selected)
            {
                try
                {
                    if(leTournoi != null)
                    {
                        dataGridView2.Rows.Clear();                        
                        Collection<Participant> lesParticipants = MParticipant.GetParticipants(leTournoi.getIdTournoi());
                        foreach(Participant part in lesParticipants)
                        {
                            dataGridView2.Rows.Add(part.getnomParticipant(),"",part.getIdParticipant(),leTournoi.getIdTournoi());
                        }
                    }
                    // t_prod_entrer.Text = listeTournoi.Rows[rowIndex].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView listeTournoi = sender as DataGridView;
            int rowIndex = e.RowIndex;
            


            if (listeTournoi.Rows[rowIndex].Cells[1].Selected)
            {
                try
                {
                    Tournoi leTournoi = MTournois.GetUnTournoi(Int32.Parse(listeTournoi.Rows[rowIndex].Cells[3].Value.ToString()));
                    if (MParticipant.GetParticipants(leTournoi.getIdTournoi()).Count == leTournoi.getnbParticipant())
                    {
                        MessageBox.Show("Le tournoi a déjà commencé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MTournois.desinscrireJoueurTournoi(Int32.Parse(listeTournoi.Rows[rowIndex].Cells[2].Value.ToString()), Int32.Parse(listeTournoi.Rows[rowIndex].Cells[3].Value.ToString()));
                        MessageBox.Show(listeTournoi.CurrentRow.Cells[0].Value.ToString()+"a été désinscrit.");
                    }
                    /*if (leTournoi != null)
                    {
                        dataGridView2.Rows.Clear();
                        Collection<Participant> lesParticipants = MParticipant.GetParticipants(leTournoi.getIdTournoi());
                        foreach (Participant part in lesParticipants)
                        {
                            dataGridView2.Rows.Add(part.getnomParticipant());
                        }
                    }*/
                    // t_prod_entrer.Text = listeTournoi.Rows[rowIndex].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAccueil form = new FormAccueil();
            form.Show();
            this.Hide();
        }
    }
}
