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
    public partial class Form2 : Form
    {
        OsobniUredaj osobni = new OsobniUredaj();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            this.osobni.Ime_vlasnika = textBox1.Text;
            this.osobni.Radio_signal = textBox2.Text;
            this.osobni.Broj_telefona = textBox3.Text.ToString();
            
            PromjeneOsobni.UnosOsobnog(this.osobni);
            Close();
            }
           
        
    

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOsobniUredaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
