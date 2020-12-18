using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli_Sivu
{
    public partial class Hallitse_Asiakaita : Form
    {
        ASIAKAS aSIAKAS = new ASIAKAS();

        public Hallitse_Asiakaita()
        {
            InitializeComponent();
        }


        //Tyhjentää tiedot
        private void Tyhjenä_Tiedot_Click(object sender, EventArgs e)
        {
            ID_TB.Text = "";
            ENimi_TB.Text = "";
            SNimi_TB.Text = "";
            Puhelin_TB.Text = "";
            Maa_TB.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Lisää uuden käyttäjän
        private void Uusi_Asiakas_Click(object sender, EventArgs e)
        {
            string eNimi = ENimi_TB.Text;
            string sNimi = SNimi_TB.Text;
            string puhelin = Puhelin_TB.Text;
            string maa = Maa_TB.Text;

            //Lisää uden asiakaan ja tarkistaa onko se sopiva
            if (eNimi.Trim().Equals("") || sNimi.Trim().Equals("") || puhelin.Trim().Equals(""))
            {
                MessageBox.Show("Tarvitavia tietoja - Etu ja Suku nimi sekä puhelin numero", "Tyhjät tiedot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Boolean lisaaKayttaja = aSIAKAS.lisaaKayttaja(eNimi, sNimi, puhelin, maa);

                if (lisaaKayttaja)
                {
                    Kayttaja_Data_Grid.DataSource = aSIAKAS.lisaaKayttaja();
                    MessageBox.Show("Uuden asiakaan teko onnistui", "Asiakas lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Asiakasta ei lisätty", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Näytää asiakaat asikas sivun
        private void Hallitse_Asiakaita_Load(object sender, EventArgs e)
        {
            Kayttaja_Data_Grid.DataSource = aSIAKAS.lisaaKayttaja();
        }

        //Muokaus nappi
        private void Muokaa_Click(object sender, EventArgs e)
        {
            int id;
            string eNimi = ENimi_TB.Text;
            string sNimi = SNimi_TB.Text;
            string puhelin = Puhelin_TB.Text;
            string maa = Maa_TB.Text;

            //Näytää virheen jos tulee ID ongelma
            try
            {
                id = Convert.ToInt32(ID_TB.Text);

                //Hakee tiedot mitä muokatan ja poistaa väli lyönit
                if (eNimi.Trim().Equals("") || sNimi.Trim().Equals("") || puhelin.Trim().Equals(""))
                {
                    MessageBox.Show("Tarvitavia tietoja - Etu ja Suku nimi sekä puhelin numero", "Tyhjät tiedot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Boolean lisaaKayttaja = aSIAKAS.muokaaKayttaja(id, eNimi, sNimi, puhelin, maa);

                    if (lisaaKayttaja)
                    {
                        Kayttaja_Data_Grid.DataSource = aSIAKAS.lisaaKayttaja();
                        MessageBox.Show("Uuden asiakaan teko päivitetty", "Asiakas muokattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Asiakasta ei päivitetty", "Asiakas päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Saat tiedot näkymään text boxseihin kun painat niitä
        private void Kayttaja_Data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[0].Value.ToString();
            ENimi_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[1].Value.ToString();
            SNimi_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[2].Value.ToString();
            Puhelin_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[3].Value.ToString();
            Maa_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[4].Value.ToString();

        }

        //Saat tiedot näkymään text boxseihin kun painat niitä
        private void Kayttaja_Data_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[0].Value.ToString();
            ENimi_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[1].Value.ToString();
            SNimi_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[2].Value.ToString();
            Puhelin_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[3].Value.ToString();
            Maa_TB.Text = Kayttaja_Data_Grid.CurrentRow.Cells[4].Value.ToString();
        }

        //Poistaa tiedot
        private void Poista_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ID_TB.Text);

                //Poistaa asiakaan tiedot hakemalla sen ASIAKAS sivusta
                if (aSIAKAS.poistaKayttaja(id))
                {
                    Kayttaja_Data_Grid.DataSource = aSIAKAS.lisaaKayttaja();
                    MessageBox.Show("Asiakas poistettu ", "Asiakas poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Poistaa text boxsit
                    Tyhjenä_Tiedot.PerformClick();

                }
                else
                {
                    MessageBox.Show("ERROR - Asiakasta ei voitu poistaa", "Asiakas poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
