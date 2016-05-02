using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Vue
{
    class Participant
    {
        private int idParticipant;
        private String nomParticipant;

        public Participant(int id, String nom)
        {
            this.idParticipant = id;
            this.nomParticipant = nom;
        }

        public int getIdParticipant()
        {
            return this.idParticipant;
        }

        public String getnomParticipant()
        {
            return this.nomParticipant;
        }
    }
}
