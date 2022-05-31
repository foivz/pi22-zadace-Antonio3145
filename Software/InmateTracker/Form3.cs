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
    public partial class Form3 : Form
    {
        OsobniUredaj osobni = new OsobniUredaj();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

