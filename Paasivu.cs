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
    public partial class Paasivu : Form
    {
        public Paasivu()
        {
            InitializeComponent();
        }

        //Kun samutat sivun se samuttaa kaiken
        private void Paasivu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Avaa asiakas sivu ja sivu pitää sulkea jos haluaa lopetaa
        private void hallitseAsiakaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hallitse_Asiakaita HalAsiak = new Hallitse_Asiakaita();
            HalAsiak.ShowDialog();
        }

        //Avaa Varaukset sivu ja sivu pitää sulkea
        private void hallitseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hallitse_Huone_Varauksia HalTilau = new Hallitse_Huone_Varauksia();
            HalTilau.ShowDialog();
        }

        //Avaa huone sivut
        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hallitse_Huoneita HalHuone = new Hallitse_Huoneita();
            HalHuone.ShowDialog();
        }

        private void Paasivu_Load(object sender, EventArgs e)
        {

        }
    }
}
