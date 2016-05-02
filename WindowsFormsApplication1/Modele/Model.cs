using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Model
    {
        public const string DataConnection = "server=btsinfo-rousseau53.fr;port=33017;user=2014-tm;password=123456;database=2014-tm_ppe;";
        public static MySqlConnection GestTournamentMaker = new MySqlConnection(DataConnection);
    }
}
