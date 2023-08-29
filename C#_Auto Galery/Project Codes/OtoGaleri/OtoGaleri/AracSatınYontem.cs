using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleri
{
    public partial class AracSatınYontem : Form
    {
        public AracSatınYontem()
        {
            InitializeComponent();
        }

        private void buttonHavaleile_Click(object sender, EventArgs e)
        {
            HavaleSatınAl hs = new HavaleSatınAl();
            hs.Show();
            this.Hide();
        }

        private void buttonNakit_Click(object sender, EventArgs e)
        {
            NakitSatınAl ns = new NakitSatınAl();
            ns.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlSat al = new AlSat();
            al.Show();
            this.Hide();
        }

        private void AracSatınYontem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
