
using System.Drawing;

namespace OtoGaleri

{
    partial class KullaniciGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.boxEposta = new System.Windows.Forms.TextBox();
            this.boxSifre = new System.Windows.Forms.TextBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.linkKayitOl = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Cıkıs = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // boxKullaniciAdi
            // 
            this.boxKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.boxKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxKullaniciAdi.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxKullaniciAdi.ForeColor = System.Drawing.Color.Silver;
            this.boxKullaniciAdi.Location = new System.Drawing.Point(1428, 544);
            this.boxKullaniciAdi.Multiline = true;
            this.boxKullaniciAdi.Name = "boxKullaniciAdi";
            this.boxKullaniciAdi.Size = new System.Drawing.Size(273, 31);
            this.boxKullaniciAdi.TabIndex = 0;
            this.boxKullaniciAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // boxEposta
            // 
            this.boxEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.boxEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxEposta.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxEposta.ForeColor = System.Drawing.Color.Silver;
            this.boxEposta.Location = new System.Drawing.Point(1428, 658);
            this.boxEposta.Multiline = true;
            this.boxEposta.Name = "boxEposta";
            this.boxEposta.Size = new System.Drawing.Size(273, 31);
            this.boxEposta.TabIndex = 1;
            this.boxEposta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // boxSifre
            // 
            this.boxSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.boxSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxSifre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxSifre.ForeColor = System.Drawing.Color.Silver;
            this.boxSifre.Location = new System.Drawing.Point(1428, 786);
            this.boxSifre.Multiline = true;
            this.boxSifre.Name = "boxSifre";
            this.boxSifre.PasswordChar = '*';
            this.boxSifre.Size = new System.Drawing.Size(251, 31);
            this.boxSifre.TabIndex = 2;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.buttonGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGirisYap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGirisYap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonGirisYap.FlatAppearance.BorderSize = 0;
            this.buttonGirisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.buttonGirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.buttonGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGirisYap.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGirisYap.ForeColor = System.Drawing.Color.Black;
            this.buttonGirisYap.Location = new System.Drawing.Point(1437, 867);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(251, 40);
            this.buttonGirisYap.TabIndex = 3;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = false;
            this.buttonGirisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkKayitOl
            // 
            this.linkKayitOl.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkKayitOl.AutoSize = true;
            this.linkKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.linkKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.linkKayitOl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.linkKayitOl.Location = new System.Drawing.Point(1425, 936);
            this.linkKayitOl.Name = "linkKayitOl";
            this.linkKayitOl.Size = new System.Drawing.Size(237, 16);
            this.linkKayitOl.TabIndex = 8;
            this.linkKayitOl.TabStop = true;
            this.linkKayitOl.Text = "Hesabın yok mu ? Kayıt olmak için tıkla";
            this.linkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.linkLabel1.Location = new System.Drawing.Point(1425, 971);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " Şifremi unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Cıkıs
            // 
            this.Cıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.Cıkıs.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__39_;
            this.Cıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cıkıs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cıkıs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cıkıs.FlatAppearance.BorderSize = 0;
            this.Cıkıs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cıkıs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cıkıs.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cıkıs.Location = new System.Drawing.Point(1751, 909);
            this.Cıkıs.Name = "Cıkıs";
            this.Cıkıs.Size = new System.Drawing.Size(175, 101);
            this.Cıkıs.TabIndex = 10;
            this.Cıkıs.UseVisualStyleBackColor = false;
            this.Cıkıs.Click += new System.EventHandler(this.button1_Click_2);
            this.Cıkıs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cıkıs_MouseClick);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OtoGaleri.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Cıkıs);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkKayitOl);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.boxSifre);
            this.Controls.Add(this.boxEposta);
            this.Controls.Add(this.boxKullaniciAdi);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "KullaniciGiris";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxEposta;
        private System.Windows.Forms.TextBox boxSifre;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.LinkLabel linkKayitOl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Cıkıs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox boxKullaniciAdi;
    }
}

