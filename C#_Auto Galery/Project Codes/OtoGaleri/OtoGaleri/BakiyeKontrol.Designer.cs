
namespace OtoGaleri
{
    partial class BakiyeKontrol
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
            this.button2 = new System.Windows.Forms.Button();
            this.bkbakiye = new System.Windows.Forms.Label();
            this.bkparabirimi = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(1375, 920);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 83);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bkbakiye
            // 
            this.bkbakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.bkbakiye.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkbakiye.ForeColor = System.Drawing.Color.LightGray;
            this.bkbakiye.Location = new System.Drawing.Point(430, 426);
            this.bkbakiye.Name = "bkbakiye";
            this.bkbakiye.Size = new System.Drawing.Size(416, 39);
            this.bkbakiye.TabIndex = 32;
            this.bkbakiye.Text = "label1";
            this.bkbakiye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bkbakiye.Click += new System.EventHandler(this.bkbakiye_Click);
            // 
            // bkparabirimi
            // 
            this.bkparabirimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.bkparabirimi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkparabirimi.ForeColor = System.Drawing.Color.LightGray;
            this.bkparabirimi.Location = new System.Drawing.Point(430, 617);
            this.bkparabirimi.Name = "bkparabirimi";
            this.bkparabirimi.Size = new System.Drawing.Size(416, 39);
            this.bkparabirimi.TabIndex = 33;
            this.bkparabirimi.Text = "label1";
            this.bkparabirimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BakiyeKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OtoGaleri.Properties.Resources._26;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.bkparabirimi);
            this.Controls.Add(this.bkbakiye);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Name = "BakiyeKontrol";
            this.Text = "BakiyeKontrol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BakiyeKontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label bkbakiye;
        public System.Windows.Forms.Label bkparabirimi;
    }
}