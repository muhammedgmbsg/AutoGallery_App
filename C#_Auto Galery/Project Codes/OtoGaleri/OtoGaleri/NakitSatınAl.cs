﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoGaleri
{
    public partial class NakitSatınAl : Form
    {
        public static string conStringh = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Galeri_DB.mdf;Integrated Security = True");
        int tutar;
        public NakitSatınAl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracSatınYontem asy = new AracSatınYontem();
            asy.Show();
            this.Hide();
        }

        private void Oadsoyadnakit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Oodemeyapnakit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStringh);
            con.Open();
            SqlCommand sql = new SqlCommand("select bakiye from SirketHesabı", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Henüz Şirket Hesabı oluşturulmadı.", "Bilgi Ekranı");
            }

            else
            {

                String a = dt.Rows[0][0].ToString();
                tutar = Convert.ToInt32(a);

                if (Oadsoyadnakit.Text.Length == 0 || Ofiyatnakit.Text.Length == 0)
                {


                    MessageBox.Show("Eksik bilgiler var tekrar deneyin.", "Bilgi Ekranı");

                }
                else
                {

                    if (Convert.ToInt32(Ofiyatnakit.Text) <= tutar)
                    {
                        {



                            tutar -= Convert.ToInt32(Ofiyatnakit.Text);

                            SqlCommand cmd = new SqlCommand("Update SirketHesabı set bakiye='" + tutar + "'", con);

                            cmd.ExecuteNonQuery();

                            con.Close();
                            string ad = Oadsoyadnakit.Text.ToString();
                            MessageBox.Show("Şirket hesabınızdan " + ad + " kişisine araç ücreti gönderildi.", "Bilgi Ekranı");
                            AracBilgi bi = new AracBilgi();
                            bi.Show();
                            this.Hide();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye tekrar deneyin", "Bilgi Ekranı");
                    }
                }
            }
        }

        private void NakitSatınAl_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Ofiyatnakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
