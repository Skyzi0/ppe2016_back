using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tournoi
    {
        private int idTournoi;
        private int nbParticipant;
        private String nomTournoi;
        private String descTournoi;

        public Tournoi(int id, int participants, String nom, String descTournoi)
        {
            this.idTournoi = id;
            this.nbParticipant = participants;
            this.nomTournoi = nom;
            this.descTournoi = descTournoi;
        }
        
        public int getIdTournoi()
        {
            return this.idTournoi;
        }

        public int getnbParticipant()
        {
            return this.nbParticipant;
        }

        public String getnomTournoi()
        {
            return this.nomTournoi;
        }

        public String getDescTournoi()
        {
            return this.descTournoi;
        }
    }
}
