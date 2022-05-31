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
    public partial class Form1 : Form
    {
        OsobniUredaj osobni = new OsobniUredaj();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var osobni = OsobniUredajiRep.GetOsobni2();
            dgvOsobniUredaji.DataSource = osobni;
          
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            frmUredi formaZaUredivanje = new frmUredi();
            Form1 trenutnaForma = new Form1();
            OsobniUredaj trenutni = dgvOsobniUredaji.CurrentRow.DataBoundItem as OsobniUredaj;
            string test1;

            PromjeneOsobni.Vracanje(trenutni);

            formaZaUredivanje.Show();
            trenutnaForma.Hide();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void BtnOsvjezi_Click(object sender, EventArgs e)
        {
            var osobni = OsobniUredajiRep.GetOsobni2();
            dgvOsobniUredaji.DataSource = osobni;

        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            OsobniUredaj trenutni = dgvOsobniUredaji.CurrentRow.DataBoundItem as OsobniUredaj;

            
            PromjeneOsobni.BrisanjeOsobnog(trenutni);

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

           // PromjeneOsobni.PretraziOsobnog(this.osobni);
        }
    }
}
