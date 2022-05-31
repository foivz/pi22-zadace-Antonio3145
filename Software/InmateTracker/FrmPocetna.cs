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
    public partial class FrmPocetna : Form
    {
        OsobniUredaj osobni = new OsobniUredaj();
        public FrmPocetna()
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
            FrmPocetna trenutnaForma = new FrmPocetna();
            OsobniUredaj trenutni = dgvOsobniUredaji.CurrentRow.DataBoundItem as OsobniUredaj;
            string test1;

            PromjeneOsobni.Vracanje(trenutni);

            formaZaUredivanje.Show();
            trenutnaForma.Hide();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodavanje form2 = new FrmDodavanje();
            form2.ShowDialog();
        }

        private void BtnOsvjezi_Click(object sender, EventArgs e)
        {
            var osobni = OsobniUredajiRep.GetOsobni2();
            dgvOsobniUredaji.DataSource = osobni;

        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvOsobniUredaji.SelectedRows.Count != 0)
            {
                OsobniUredaj trenutni = dgvOsobniUredaji.CurrentRow.DataBoundItem as OsobniUredaj;


                PromjeneOsobni.BrisanjeOsobnog(trenutni);
            }

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            FrmPretrazivanje form3 = new FrmPretrazivanje();
            form3.ShowDialog();

           // PromjeneOsobni.PretraziOsobnog(this.osobni);
        }
    }
}
