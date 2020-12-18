using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

//JOSAIN KOHDASSA ON ONGELMA MITÄ EN LÖYDÄ
namespace Hotelli_Sivu
{
    class TILAUKSET
    {
        Yhteys yht = new Yhteys();

        //Hae kaikki Huone tilaukset
        public DataTable haeKakkitialukset()
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `varaukset`", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            Sovitin.SelectCommand = kasky;
            Sovitin.Fill(poyta);

            return poyta;
        }

        //Functio joka lisää uuden varauksen
        public bool lisaaTilaus(int numero, int asiakasID, DateTime paivaysSisaa, DateTime paivaysUlos)
        {
            //Otta tiedot mysql
            MySqlCommand kasky = new MySqlCommand();
            string LisaaKysely = "INSERT INTO `varaukset`(`huoneeNumero`, `asiakasID`, `paivaysSisaa`, `paivaysUlos`) VALUES (@rnm,@cid,@din,@dout)";
            kasky.CommandText = LisaaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@rnm,@cid,@din,@dout
            //Kertoo mitkä tiedot pitää hakea Tilauksia
            kasky.Parameters.Add("@rnm", MySqlDbType.Int32).Value = numero;
            kasky.Parameters.Add("@cid", MySqlDbType.Int32).Value = asiakasID;
            kasky.Parameters.Add("@din", MySqlDbType.Date).Value = paivaysSisaa;
            kasky.Parameters.Add("@dout", MySqlDbType.Date).Value = paivaysUlos;

            //Avaaa ja sulkee yhteyden myql
            yht.avaaYhdista();

            if (kasky.ExecuteNonQuery() == 1)
            {
                yht.suljeYhdista();
                return true;
            }
            else
            {
                yht.suljeYhdista();
                return false;
            }
        }

        //Muokaa valittua varaus riviä
        public bool muokaaVarauksia(int varausID, int numero, int asiakasID, DateTime paivaysSisaa, DateTime paivaysUlos)
        {
            //Otta tiedot mysql
            MySqlCommand kasky = new MySqlCommand();
            string muokaaKysely = "UPDATE `varaukset` SET `huoneeNumero`=@rnm, `asiakasID`=@cid, `paivaysSisaa`=@din, `paivaysUlos`=@dout WHERE `varausID`=@rvid";
            kasky.CommandText = muokaaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@rnm,@cid,@din,@dout,@rvid
            //Kertoo mitkä tiedot pitää hakea Tilauksia
            kasky.Parameters.Add("@rvid", MySqlDbType.Int32).Value = varausID;
            kasky.Parameters.Add("@rnm", MySqlDbType.Int32).Value = numero;
            kasky.Parameters.Add("@cid", MySqlDbType.Int32).Value = asiakasID;
            kasky.Parameters.Add("@din", MySqlDbType.Date).Value = paivaysSisaa;
            kasky.Parameters.Add("@dout", MySqlDbType.Date).Value = paivaysUlos;

            //Avaaa ja sulkee yhteyden myql
            yht.avaaYhdista();

            if (kasky.ExecuteNonQuery() == 1)
            {
                yht.suljeYhdista();
                return true;
            }
            else
            {
                yht.suljeYhdista();
                return false;
            }
        }

        //Poistaa tilauksen, varausID numeroa käytäen
        public bool poistaTilaus(int varaus_ID)
        {
            MySqlCommand kasky = new MySqlCommand();
            string poistaKysely = "DELETE FROM `varaukset` WHERE `varausID`=@rvid";
            kasky.CommandText = poistaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@mun
            kasky.Parameters.Add("@rvid", MySqlDbType.Int32).Value = varaus_ID;

            //Avaa yhteys ja sulje
            yht.avaaYhdista();

            if (kasky.ExecuteNonQuery() == 1)
            {
                yht.suljeYhdista();
                return true;
            }
            else
            {
                yht.suljeYhdista();
                return false;
            }
        }

    }
}
