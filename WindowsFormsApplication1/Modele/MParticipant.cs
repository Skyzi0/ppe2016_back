using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Vue;

namespace WindowsFormsApplication1.Modele
{
    class MParticipant
    {

        public static Collection<Participant> GetParticipants(int id)
        {
            Collection<Participant> lesParticipants = new Collection<Participant>();
            try
            {
                lesParticipants.Clear();
                Model.GestTournamentMaker.Open();
                string sql = "SELECT u.idUtilisateur, pseudo FROM inscription i inner join utilisateur u on u.idUtilisateur = i.idUtilisateur  WHERE idTournoi ="+ id.ToString() ;
                var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                var readerArticle = command1.ExecuteReader();
                while (readerArticle.Read())
                {
                    var nouveauParticipant = new Participant(int.Parse(readerArticle[0].ToString()), readerArticle[1].ToString());
                    lesParticipants.Add(nouveauParticipant);
                }
                Model.GestTournamentMaker.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Model.GestTournamentMaker.Close();
            }
            return lesParticipants;
        }
    }
}
