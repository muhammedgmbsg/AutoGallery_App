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
    public partial class BakiyeKontrol : Form
    {
        public BakiyeKontrol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakiyeIslem bi = new BakiyeIslem();
            bi.Show();
            this.Hide();
        }

        private void BakiyeKontrol_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bkbakiye_Click(object sender, EventArgs e)
        {

        }
    }
}
