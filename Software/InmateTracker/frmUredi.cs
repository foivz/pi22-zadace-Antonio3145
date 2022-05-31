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
    public partial class frmUredi : Form
    {
        public frmUredi()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string signal = txtSignal.Text;
            string telefon = txtTelefon.Text;

            PromjeneOsobni.UrediOsobnog(ime, signal, telefon);

            Close();
        }
    }
}
