
namespace OtoGaleri
{
    partial class shcvc
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
            this.shkartno = new System.Windows.Forms.TextBox();
            this.shkartsifre = new System.Windows.Forms.TextBox();
            this.shadsoyad = new System.Windows.Forms.TextBox();
            this.shkartcvc = new System.Windows.Forms.TextBox();
            this.shdevamet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shkartno
            // 
            this.shkartno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.shkartno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shkartno.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shkartno.ForeColor = System.Drawing.Color.Silver;
            this.shkartno.Location = new System.Drawing.Point(425, 332);
            this.shkartno.Multiline = true;
            this.shkartno.Name = "shkartno";
            this.shkartno.Size = new System.Drawing.Size(405, 33);
            this.shkartno.TabIndex = 20;
            this.shkartno.TextChanged += new System.EventHandler(this.shkartno_TextChanged);
            this.shkartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shkartno_KeyPress);
            // 
            // shkartsifre
            // 
            this.shkartsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.shkartsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shkartsifre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shkartsifre.ForeColor = System.Drawing.Color.Silver;
            this.shkartsifre.Location = new System.Drawing.Point(425, 453);
            this.shkartsifre.Multiline = true;
            this.shkartsifre.Name = "shkartsifre";
            this.shkartsifre.Size = new System.Drawing.Size(405, 32);
            this.shkartsifre.TabIndex = 21;
            this.shkartsifre.TextChanged += new System.EventHandler(this.shkartsifre_TextChanged);
            this.shkartsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shkartsifre_KeyPress);
            // 
            // shadsoyad
            // 
            this.shadsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.shadsoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shadsoyad.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shadsoyad.ForeColor = System.Drawing.Color.Silver;
            this.shadsoyad.Location = new System.Drawing.Point(425, 573);
            this.shadsoyad.Multiline = true;
            this.shadsoyad.Name = "shadsoyad";
            this.shadsoyad.Size = new System.Drawing.Size(405, 35);
            this.shadsoyad.TabIndex = 22;
            this.shadsoyad.TextChanged += new System.EventHandler(this.shadsoyad_TextChanged);
            // 
            // shkartcvc
            // 
            this.shkartcvc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.shkartcvc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shkartcvc.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shkartcvc.ForeColor = System.Drawing.Color.Silver;
            this.shkartcvc.Location = new System.Drawing.Point(1094, 329);
            this.shkartcvc.Multiline = true;
            this.shkartcvc.Name = "shkartcvc";
            this.shkartcvc.Size = new System.Drawing.Size(76, 39);
            this.shkartcvc.TabIndex = 23;
            this.shkartcvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shkartcvc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // shdevamet
            // 
            this.shdevamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.shdevamet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shdevamet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shdevamet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shdevamet.FlatAppearance.BorderSize = 0;
            this.shdevamet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.shdevamet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.shdevamet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shdevamet.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shdevamet.Location = new System.Drawing.Point(670, 692);
            this.shdevamet.Name = "shdevamet";
            this.shdevamet.Size = new System.Drawing.Size(160, 41);
            this.shdevamet.TabIndex = 24;
            this.shdevamet.Text = "Oluştur";
            this.shdevamet.UseVisualStyleBackColor = false;
            this.shdevamet.Click += new System.EventHandler(this.shdevamet_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button2.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__13_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1372, 922);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 83);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shcvc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shdevamet);
            this.Controls.Add(this.shkartcvc);
            this.Controls.Add(this.shadsoyad);
            this.Controls.Add(this.shkartsifre);
            this.Controls.Add(this.shkartno);
            this.DoubleBuffered = true;
            this.Name = "shcvc";
            this.Text = "SirketHesap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.shcvc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox shkartno;
        public System.Windows.Forms.TextBox shkartsifre;
        public System.Windows.Forms.TextBox shadsoyad;
        public System.Windows.Forms.TextBox shkartcvc;
        private System.Windows.Forms.Button shdevamet;
        private System.Windows.Forms.Button button2;
    }
}