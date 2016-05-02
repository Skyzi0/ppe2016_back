using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MTournois
    {
        public static Collection<Tournoi> GetTournois()
        {
            Collection<Tournoi> lesTournois = new Collection<Tournoi>();
            try
            {
                lesTournois.Clear();
                Model.GestTournamentMaker.Open();
                const string sql = "SELECT * FROM tournoi";
                var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                var readerArticle = command1.ExecuteReader();
                while (readerArticle.Read())
                {
                    var nouveauTournoi = new Tournoi(int.Parse(readerArticle[0].ToString()), int.Parse(readerArticle[2].ToString()),
                        readerArticle[1].ToString(), readerArticle[3].ToString());
                    lesTournois.Add(nouveauTournoi);
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
            return lesTournois;
        }

        public static Tournoi GetUnTournoi(int id)
        {
            Tournoi leTournoi = null;
            try
            {
                Model.GestTournamentMaker.Open();
                string sql = "SELECT * FROM tournoi WHERE idTournoi ="+ id.ToString();
                var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                var readerArticle = command1.ExecuteReader();
                while (readerArticle.Read())
                {
                    leTournoi = new Tournoi(int.Parse(readerArticle[0].ToString()), int.Parse(readerArticle[2].ToString()),
                        readerArticle[1].ToString(), readerArticle[3].ToString());
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
            return leTournoi;
        }

        public static bool ajouterTournoi(String nom, int nbPart, String desc)
        {
            bool retour = false;
            try
            {
                Model.GestTournamentMaker.Open();
                string sql = "INSERT INTO tournoi(idTournoi, nomTournoi, nombreParticipantMax, description) VALUES ('', '" + nom+"',"+ nbPart.ToString()+", '"+ desc.ToString() +"')";
                var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                var readerArticle = command1.ExecuteReader();
                readerArticle.Read();
                Model.GestTournamentMaker.Close();

                Model.GestTournamentMaker.Open();
                const string sql2 = "SELECT * FROM `tournoi` where idTournoi = (Select max(idTournoi) from tournoi)";
                command1 = new MySqlCommand(sql2, Model.GestTournamentMaker);
                readerArticle = command1.ExecuteReader();
                readerArticle.Read();
                Tournoi dernierTournoi;
                dernierTournoi = new Tournoi(int.Parse(readerArticle[0].ToString()), int.Parse(readerArticle[2].ToString()),
                readerArticle[1].ToString(), readerArticle[3].ToString());
                createFights(dernierTournoi.getIdTournoi(), nbPart);


                Model.GestTournamentMaker.Close();

                retour = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Model.GestTournamentMaker.Close();
            }
            return retour;
        }

        public static bool createFights(int idTournoi, int nbPart)
        {
            bool retour = false;
            int nbMatch = nbPart - 1;
            int compt = nbPart;
            int joueurRestant = nbPart;
            try
            {
                for(int i = 0; i < nbMatch; i++)
                {
                    if(joueurRestant == compt / 2)
                    {
                        compt = compt / 2;
                    }
                    int y = 1;
                    int boucle = compt;
                    for (int j = 1; boucle / 2 !=1 ; j++)
                    {
                        boucle = boucle / 2;
                        y++;
                    }
                    if(joueurRestant == 2)
                    {
                        y = 1;
                    }

                    Model.GestTournamentMaker.Close();
                    Model.GestTournamentMaker.Open();
                    string sql3 = "INSERT INTO `fight`(`idMatch`, `idTournoi`, `typeMatch`, `idJoueurUn`, `idJoueurDeux`, `idGagnant`) VALUES ('',"+ idTournoi.ToString()+","+y+",null ,null ,null)";
                    var command3 = new MySqlCommand(sql3, Model.GestTournamentMaker);
                    var readerArticle3 = command3.ExecuteReader();
                    readerArticle3.Read();
                    joueurRestant = joueurRestant - 1;
                }
                retour = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Model.GestTournamentMaker.Close();
            }
            return retour;
        }
        public static bool desinscrireJoueurTournoi(int idJ, int idT)
        {
            bool retour = false;
            try
            {
                Model.GestTournamentMaker.Open();
                string sql = "DELETE FROM `2014-tm_ppe`.`inscription` WHERE `inscription`.`idUtilisateur` = "+idJ.ToString()+ " AND `inscription`.`idTournoi` = " + idT.ToString();
                var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                var readerArticle = command1.ExecuteReader();
                readerArticle.Read();
                Model.GestTournamentMaker.Close();

                retour = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                Model.GestTournamentMaker.Close();
            }
            return retour;
        }
    }
}
