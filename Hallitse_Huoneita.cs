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
    public partial class Hallitse_Huoneita : Form
    {
        public Hallitse_Huoneita()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();
        private void Hallitse_Huoneita_Load(object sender, EventArgs e)
        {
            //Hakee huone tyyli listan comboboxsiin
            HuoneetCBx.DataSource = huone.huneenTyyliLisata();
            HuoneetCBx.DisplayMember = "etiketti";
            HuoneetCBx.ValueMember = "kategoria_id";

            Huoneet_Data_Grid.DataSource = huone.hankiHuone();

        }

        //Lisää uude uden huoneen
        private void Lisää_Uusi_Huone_Click(object sender, EventArgs e)
        {
            //Hakee huone tyyli listan comboboxsiin
            int tyyppi = Convert.ToInt32(HuoneetCBx.SelectedValue.ToString());
            string puhelin = Puhelin_Huo_TB.Text;
            string vapaa = "";

            try
            {
                int numero = Convert.ToInt32(huoneNum_TB.Text);
                if (Kyllä_RButon.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (Ei_RButon.Checked)
                {
                    vapaa = "Ei";
                }

                //Keroo jos huoneen lisäys onistui ja tarkistaa että kaiki tiedot mitkä pitää olla on täytetty ja lisää sen listaan hankiHuone comandia
                if (huone.lisaaHuone(numero, tyyppi, puhelin, vapaa))
                {
                    Huoneet_Data_Grid.DataSource = huone.hankiHuone();
                    MessageBox.Show("Huoneen lisäys onistui", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen lisäys epäonistui", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Muokaa huoneita
        private void Muokaa_Huo_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HuoneetCBx.SelectedValue.ToString());
            string puhelin = Puhelin_Huo_TB.Text;
            string vapaa = "";

            try
            {
                int numero = Convert.ToInt32(huoneNum_TB.Text);
                if (Kyllä_RButon.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (Ei_RButon.Checked)
                {
                    vapaa = "Ei";
                }


                if (huone.muokaaHuoneita(numero, tyyppi, puhelin, vapaa))
                {
                    Huoneet_Data_Grid.DataSource = huone.hankiHuone();
                    MessageBox.Show("Huoneiten tiedot päivitetty", "Muokaa huoneita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneiten tietoja ei päivitetty", "Muokaa huoneita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Poistaa huoneet
        private void Poista_Huo_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(huoneNum_TB.Text);

                if (huone.poistaHuone(numero))
                {
                    Huoneet_Data_Grid.DataSource = huone.hankiHuone();
                    MessageBox.Show("Huoneiten tiedot poistettu", "Poista huoneita", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Tyhjenä_Huo_Tiedot.PerformClick();
                }
                else
                {
                    MessageBox.Show("Huoneiten tiedot poistettu", "Poista huoneita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tyhjentää huone tiedot
        private void Tyhjenä_Huo_Tiedot_Click(object sender, EventArgs e)
        {
            huoneNum_TB.Text = "";
            HuoneetCBx.SelectedIndex = 0;
            Puhelin_Huo_TB.Text = "";
            Kyllä_RButon.Checked = true;
        }


        // Ei voi painaa listaa
        private void Huoneet_Data_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneNum_TB.Text = Huoneet_Data_Grid.CurrentRow.Cells[0].Value.ToString();
            HuoneetCBx.SelectedValue = Huoneet_Data_Grid.CurrentRow.Cells[1].Value;
            Puhelin_Huo_TB.Text = Huoneet_Data_Grid.CurrentRow.Cells[2].Value.ToString();

            string vapaa = Huoneet_Data_Grid.CurrentRow.Cells[2].Value.ToString();

            if (vapaa.Equals("Kyllä"))
            {
                Kyllä_RButon.Checked = true;
            }
            else if (vapaa.Equals("Ei"))
            {
                Ei_RButon.Checked = true;
            }
        }
    }
}
