using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hotelli_Sivu
{
    //Yhdistää mysql
    class Yhteys
    {
        private MySqlConnection yhdistys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_hoteli;");

        //Functio joka palautaa yhteyden
        public MySqlConnection hankiYhdistys()
        {
            return yhdistys;
        }

        //Avaa yhteyden
        public void avaaYhdista()
        {
            if(yhdistys.State == ConnectionState.Closed)
            {
                yhdistys.Open();
            }
        }

        internal MySqlConnection getConnection()
        {
            throw new NotImplementedException();
        }

        //Sulkee yhteyden
        public void suljeYhdista()
        {
            if (yhdistys.State == ConnectionState.Open)
            {
                yhdistys.Close();
            }
        }

    }
}
