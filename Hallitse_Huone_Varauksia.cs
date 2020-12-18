using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//JOSAIN KOHDASSA ON ONGELMA MITÄ EN LÖYDÄ
namespace Hotelli_Sivu
{
    public partial class Hallitse_Huone_Varauksia : Form
    {
        public Hallitse_Huone_Varauksia()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();
        TILAUKSET tilaus = new TILAUKSET();

        // MAHDOLLINEN ONGELMA
        private void Hallitse_Huone_Varauksia_Load(object sender, EventArgs e)
        {
            //Näytää huoneen tyypit
            HuoneTyypiCB.DataSource = huone.huneenTyyliLisata();
            HuoneTyypiCB.DisplayMember = "etiketti";
            HuoneTyypiCB.ValueMember = "kategoria_id";

            //Näytää huoneen numero
            int tyyli = Convert.ToInt32(HuoneTyypiCB.SelectedValue.ToString());
            HuoneNumeroCB.DataSource = huone.huneenTyyli(tyyli);
            HuoneNumeroCB.DisplayMember = "Numero";
            HuoneNumeroCB.ValueMember = "Numero";

            //Näytä kaikki varaukset
            Varaukset_Data_Grid.DataSource = tilaus.haeKakkitialukset();
        }

        //Tyhjentää huone tidot text boxseista
        private void Tyhjenä_Huo_Tiedot_Click(object sender, EventArgs e)
        {
            VarausIDTBx.Text = "";
            AsiakasTBx.Text = "";
            HuoneTyypiCB.SelectedIndex = 0;
            PaivaSisaaDTP.Value = DateTime.Now;
            PaivaUlosDTP.Value = DateTime.Now;
        }

        //Lisää uusi huone
        private void Lisää_Uusi_Huone_Click(object sender, EventArgs e)
        {
            try
            {
                int asiakasID = Convert.ToInt32(AsiakasTBx.Text);
                int huoneetNumerot = Convert.ToInt32(HuoneNumeroCB.SelectedValue);
                DateTime paivaysSisaa = PaivaSisaaDTP.Value;
                DateTime paivaysUlos = PaivaUlosDTP.Value;

                //Päiväys sisään pitää olla aikainaan sinä paivänä kun se tilataaan ja ulos sisääntulo päivän jälkeen
                if(DateTime.Compare(paivaysSisaa.Date,DateTime.Now.Date) > 0)
                {
                    MessageBox.Show("Päiväys pitää olla varattu päivää aikaisemin", "Sopimaton Päivä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(DateTime.Compare(paivaysUlos.Date,paivaysSisaa.Date) < 0)
                {
                    MessageBox.Show(paivaysSisaa.Day + " - " + paivaysSisaa);
                    MessageBox.Show("Päiväys ulos pitää olla vähintään huoneen varaus päivävän jälkeen ", "Sopimaton Päivä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Näytää viestin jos päiväyksen varaus onistui
                    if (tilaus.lisaaTilaus(huoneetNumerot, asiakasID, paivaysSisaa, paivaysUlos))
                    {
                        //Muokaa huone Ei kun se on varattu
                        //Voi lisätä viestin jos huone on muokattu
                        huone.laitaHuneenVapaa(huoneetNumerot, "Ei");
                        Varaukset_Data_Grid.DataSource = tilaus.haeKakkitialukset();
                        MessageBox.Show("Uusi Varaus Lisätty", "Lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uusi lisäys epäonistui", "Lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Varaus Lisäys Epäonistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Muokaa huone varauksia
        private void Muokaa_Huo_Click(object sender, EventArgs e)
        {

                try
                {
                    int tilausID = Convert.ToInt32(AsiakasTBx.Text);
                    int asiakasID = Convert.ToInt32(AsiakasTBx.Text);
                    int huoneetNumerot = Convert.ToInt32(Varaukset_Data_Grid.CurrentRow.Cells[1].Value.ToString());
                    DateTime paivaysSisaa = PaivaSisaaDTP.Value;
                    DateTime paivaysUlos = PaivaUlosDTP.Value;

                    //Päiväy sisään pitää olla aikainaan sinä paivänä kun se tilataaan ja ulos sisääntulo päivän jälkeen
                    if (paivaysSisaa.Day < DateTime.Now.Day)
                    {
                        MessageBox.Show("Päiväys Sisään Saa Olla Vähintään Huoneen Varaus Päivävän Päivän Aikana", "Sopimaton Päivä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (paivaysUlos.Day < paivaysSisaa.Day)
                    {
                        MessageBox.Show("Päiväys Ulos Pitää Olla Vähintään Huoneen Varaus Päivävän Jälkeen ", "Sopimaton Päivä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    //tilauID
                        if (tilaus.muokaaVarauksia(tilausID, huoneetNumerot, asiakasID, paivaysSisaa, paivaysUlos))
                        {
                            //Laitaa huoneen NO
                            //Voi lisätä viestin jos huone on muokattu
                            huone.laitaHuneenVapaa(huoneetNumerot, "Ei");
                        Varaukset_Data_Grid.DataSource = tilaus.haeKakkitialukset();
                            MessageBox.Show("Varaus Muokaus Päivitetty", "Muokka varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Varaus muokaus Epäonistui", "Muokaa varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Varaus Muokaus Epäonistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        //Näytää tiedot harmaala taustalla
        private void Varaukset_Data_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausIDTBx.Text = Varaukset_Data_Grid.CurrentRow.Cells[0].Value.ToString();

            //Hanki huone ID
            int huoneID = Convert.ToInt32(Varaukset_Data_Grid.CurrentRow.Cells[1].Value.ToString());

            //Valitse huoneen tyyli comboboxsista
            HuoneTyypiCB.SelectedValue = huone.hankiHuneenTyyli(huoneID);

            //Valitse huone numero comboboxsista
            HuoneNumeroCB.SelectedValue = huoneID;

            AsiakasTBx.Text = Varaukset_Data_Grid.CurrentRow.Cells[2].Value.ToString();

            PaivaSisaaDTP.Value = Convert.ToDateTime(Varaukset_Data_Grid.CurrentRow.Cells[3].Value);
            PaivaUlosDTP.Value = Convert.ToDateTime(Varaukset_Data_Grid.CurrentRow.Cells[4].Value);
        }

        private void Varaukset_Data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Poistaa huoneen tiedot käytäen varaus ID ja kertoo jos se onistui
        private void Poista_Huo_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = Convert.ToInt32(VarausIDTBx.Text);
                int huoneetNumerot = Convert.ToInt32(Varaukset_Data_Grid.CurrentRow.Cells[1].Value.ToString());
                if (tilaus.poistaTilaus(varausID));
                {
                    Varaukset_Data_Grid.DataSource = tilaus.haeKakkitialukset();

                    huone.laitaHuneenVapaa(huoneetNumerot, "Kyllä");
                    MessageBox.Show("Varaus Poistettu", "Poisto Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Poisto Epäonistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

//	AUTO_INCREMENT

//ALTER TABLE huone ADD CONSTRAINT fk_tyyli_id FOREIGN KEY (Tyyli) REFERENCES huoneet_katergoria (kategoria_id) ON UPDATE CASCADE ON DELETE CASCADE;

//ALTER TABLE varaukset ADD CONSTRAINT fk_huone_numero FOREIGN KEY (huoneeNumero) REFERENCES huone (Numero) ON UPDATE CASCADE ON DELETE CASCADE;

//ALTER TABLE varaukset ADD CONSTRAINT fk_asiakas_id FOREIGN KEY (asiakasID) REFERENCES kayttajia (id) ON UPDATE CASCADE ON DELETE CASCADE;
