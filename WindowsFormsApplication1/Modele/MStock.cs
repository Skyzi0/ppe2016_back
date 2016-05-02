using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Vue;
using WindowsFormsApplication1.Classe;

namespace WindowsFormsApplication1.Modele
{
    class MStock
    {
        public static Collection<Produit> getProduits(){

            Collection<Produit> lesProduits = new Collection<Produit>();

            try
            {
                lesProduits.Clear();
                Model.GestTournamentMaker.Open();
                const string sql = "SELECT * FROM produit";
                var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                var readerArticle = command1.ExecuteReader();
                while (readerArticle.Read())
                {
                    var produit = new Produit(int.Parse(readerArticle[0].ToString()), readerArticle[1].ToString(), readerArticle[2].ToString(), readerArticle[3].ToString(), int.Parse(readerArticle[4].ToString()), int.Parse(readerArticle[5].ToString()), readerArticle[6].ToString());
                    lesProduits.Add(produit);
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

            return lesProduits;
        }

        public static void updateProduit(Collection<Produit> lesNouveauxProduits)
        {
            foreach(Produit produit in lesNouveauxProduits)
            {
                try
                {
                    Model.GestTournamentMaker.Open();
                    string sql = "UPDATE produit SET nomProduit = '" + produit.getName() + "', typeProduit = '" + produit.getType() + "', description = '" + produit.getDesc() + "' , prix = " + produit.getPrix() + ", stock = " + produit.getStock() + ", photo = '" + produit.getPicture() + "' WHERE idProduit = " + produit.getId();
                    var command1 = new MySqlCommand(sql, Model.GestTournamentMaker);
                    var readerArticle = command1.ExecuteReader();
                    
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
            }
            lesNouveauxProduits.Clear();
        }
    }
}
