using System;
using InmateTracker.Repozitorij;
using InmateTracker.Modeli;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmateTracker
{
    public partial class FrmPretrazivanje : Form
    {
        OsobniUredaj osobni = new OsobniUredaj();
        public FrmPretrazivanje()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var osobni = OsobniUredajiRep.GetOsobni2();
            dgvOsobniUredaji.DataSource = osobni;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var ImePrez = textBox1.Text;
            var osobni = OsobniUredajiRep.GetOsobni3(ImePrez);
            dgvOsobniUredaji.DataSource = osobni;
        }
    }
}

