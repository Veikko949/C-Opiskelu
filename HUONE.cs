using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotelli_Sivu
{
    //Huoneet
    class HUONE
    {

        Yhteys yht = new Yhteys();

        //Otaa listan huoneista mysglästä
        public DataTable huneenTyyliLisata()
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `huoneet_katergoria`", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            Sovitin.SelectCommand = kasky;
            Sovitin.Fill(poyta);

            return poyta;
        }

        // ONGELMA JOSSAIN
        //Otaa listan huoneiten tyypeistä
        public DataTable huneenTyyli(int tyyli)
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `huone` WHERE `Tyyli`=@typ and Vapaa='Kyllä'", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            // @typ
            kasky.Parameters.Add("@typ", MySqlDbType.Int32).Value = tyyli;

            Sovitin.SelectCommand = kasky;
            Sovitin.Fill(poyta);

            return poyta;
        }

        //Palautaa huone tyylin id
        public int hankiHuneenTyyli(int numero)
        {
            MySqlCommand kasky = new MySqlCommand("SELECT `Tyyli` FROM `huone` WHERE vapaa='Kyllä' `Numero` =@num", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            // @num
            kasky.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            Sovitin.SelectCommand = kasky;
            Sovitin.Fill(poyta);

            return Convert.ToInt32(poyta.Rows[0][0].ToString());
        }

        //Laitaa huoneen rivin Ei tai kylläksi
        public bool laitaHuneenVapaa(int numero,string Kylla_Tai_Ei)
        {
            MySqlCommand kasky = new MySqlCommand("UPDATE `huone` SET `Vapaa`=@kylla_ei WHERE 'Numero' = @num", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            // @num, kylla_ei
            kasky.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            kasky.Parameters.Add("@kylla_ei", MySqlDbType.VarChar).Value = Kylla_Tai_Ei;

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

        //Lisiää uuden huoneen mysqlään
        public bool lisaaHuone(int numero, int tyyli, String puhelin, String vapaa)
        {
                //Otta tiedot mysql
                MySqlCommand kasky = new MySqlCommand();
                string LisaaKysely = "INSERT INTO `huone`(`Numero`, `Tyyli`, `Puhelin`, `Vapaa`) VALUES (@num,@tp,@phn,@fr)";
                kasky.CommandText = LisaaKysely;
                kasky.Connection = yht.hankiYhdistys();

                //@num,@tp,@phn,@fr
                //Kertoo mitkä tiedot pitää hakea Hallitse_Huoneita 
                kasky.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
                kasky.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyli;
                kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
                kasky.Parameters.Add("@fr", MySqlDbType.VarChar).Value = vapaa;

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

        //Hankii listan kaikista huoneista mysqlästä
        public DataTable hankiHuone()
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `huone`", yht.hankiYhdistys());
            MySqlDataAdapter Sovitin = new MySqlDataAdapter();
            DataTable poyta = new DataTable();

            Sovitin.SelectCommand = kasky;
            Sovitin.Fill(poyta);

            return poyta;
        }

        //Muokaa valittua huone riviä
        public bool muokaaHuoneita(int numero, int tyyli, String puhelin, String vapaa)
        {
            //Otta tiedot mysql
            MySqlCommand kasky = new MySqlCommand();
            string muokaaKysely = "UPDATE `huone` SET `Tyyli`=@tp,` Puhelin`=@phn,` Vapaa`=@fr WHERE `Numero` = @num";
            kasky.CommandText = muokaaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@num,@tp,@phn,@fr
            //Kertoo mitkä tiedot pitää hakea Hallitse_Huoneita 
            kasky.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            kasky.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyli;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            kasky.Parameters.Add("@fr", MySqlDbType.VarChar).Value = vapaa;

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

        //Poistaa mysqllästä huone tiedot huoneen numeroa käytäen
        public bool poistaHuone(int numero)
        {
            MySqlCommand kasky = new MySqlCommand();
            string poistaKysely = "DELETE FROM `huone` WHERE `Numero`=@num";
            kasky.CommandText = poistaKysely;
            kasky.Connection = yht.hankiYhdistys();

            //@mun
            kasky.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

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
