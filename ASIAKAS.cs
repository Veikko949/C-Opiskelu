using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotelli_Sivu
{
    //Lisää uusi käyttäjä ja muokaa niitä
    class ASIAKAS
    {
        Yhteys yht = new Yhteys();

        //Lisää käytäjän mysqlään käytämällä asiakas sivulla olevia text boxseja
        public bool lisaaKayttaja(String eNimi, String sNimi, String puhelin, String maa)
        {
            //Otaa tiedot mysglsästä ja antaa niile lyhenteen
            MySqlCommand kasky = new MySqlCommand();
            string LisaaKysely = "INSERT INTO `kayttajia`(`Etu_Nimi`, `Suku_Nimi`, `Puhelin`, `Maa`) VALUES (@fnm,@lnm,@phn,@cnt)";
            kasky.CommandText = LisaaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@fnm,@lnm,@phn,@cnt
            //Kertoo mitkä tiedot kuuluu mihin lyhenteeseen
            kasky.Parameters.Add("@fnm",MySqlDbType.VarChar).Value = eNimi;
            kasky.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = sNimi;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            kasky.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = maa;

            //Avaaa ja sulkee yhteyden myql
            yht.avaaYhdista();

            if(kasky.ExecuteNonQuery() == 1)
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

        //Functio joka hakee käyttäjä listan
        public DataTable lisaaKayttaja()
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `kayttajia`", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            Sovitin.SelectCommand = kasky;
            Sovitin.Fill(poyta);

            return poyta;
        }

        //Muokaa käytäjän tietoja
        public bool muokaaKayttaja(int id, String eNimi, String sNimi, String puhelin, String maa)
        {
            //Otta tiedot mysql ja niiten lyheenteet
            MySqlCommand kasky = new MySqlCommand();
            string muokaaKysely = "UPDATE `kayttajia` SET `Etu_Nimi`=@fnm,`Suku_Nimi`=@lnm,`Puhelin`=@phn,`Maa`=@cnt WHERE `id`=@cid";
            kasky.CommandText = muokaaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@cid,@fnm,@lnm,@phn,@cnt
            //Kertoo mitkä tiedot kuuluu mihin lyhenteeseen
            kasky.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            kasky.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = eNimi;
            kasky.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = sNimi;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            kasky.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = maa;

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

        //Poistaa mysqllästä käyttäjä tiedot id käyttäen
        public bool poistaKayttaja(int id)
        {
            MySqlCommand kasky = new MySqlCommand();
            string poistaKysely = "DELETE FROM `kayttajia` WHERE `id`=@cid";
            kasky.CommandText = poistaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@cld
            kasky.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

            //Avaa yhteys
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
