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
    public partial class AracSatısYontem : Form
    {
        public AracSatısYontem()
        {
            InitializeComponent();
        }

        private void satısNakit_Click(object sender, EventArgs e)
        {
            NakitSatısYap nky = new NakitSatısYap();
            nky.Show();
            this.Hide();
        }

        private void SatısHavaleile_Click(object sender, EventArgs e)
        {
            HavaleSatısYap hsy = new HavaleSatısYap();
            hsy.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlSat al = new AlSat();
            al.Show();
            this.Hide();
        }

        private void AracSatısYontem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
