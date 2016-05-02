using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classe
{
    class Produit
    {
        private int id;
        private String name;
        private String type;
        private String desc;
        private int prix;
        private int stock;
        private String picture;
        
        public Produit(int id, String name, String type, String desc, int prix, int stock, String picture)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.desc = desc;
            this.prix = prix;
            this.stock = stock;
            this.picture = picture;
        }

        public int getId()
        {
            return this.id;
        }

        public String getName()
        {
            return this.name;
        }

        public String getType()
        {
            return this.type;
        }

        public String getDesc()
        {
            return this.desc;
        }

        public int getPrix()
        {
            return this.prix;
        }

        public int getStock()
        {
            return this.stock;
        }

        public String getPicture()
        {
            return this.picture;
        }
    }
}
