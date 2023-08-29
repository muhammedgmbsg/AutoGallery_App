namespace OtoGaleri
{
    partial class EkleSil
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
            this.aracekle = new System.Windows.Forms.Button();
            this.aracsil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aracekle
            // 
            this.aracekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.aracekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aracekle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aracekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aracekle.FlatAppearance.BorderSize = 0;
            this.aracekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.aracekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.aracekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracekle.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracekle.Location = new System.Drawing.Point(399, 583);
            this.aracekle.Name = "aracekle";
            this.aracekle.Size = new System.Drawing.Size(251, 143);
            this.aracekle.TabIndex = 10;
            this.aracekle.Text = "Araç Ekle";
            this.aracekle.UseVisualStyleBackColor = false;
            this.aracekle.Click += new System.EventHandler(this.buttonAracalsat_Click);
            // 
            // aracsil
            // 
            this.aracsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.aracsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aracsil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aracsil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aracsil.FlatAppearance.BorderSize = 0;
            this.aracsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.aracsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.aracsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracsil.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracsil.Location = new System.Drawing.Point(843, 583);
            this.aracsil.Name = "aracsil";
            this.aracsil.Size = new System.Drawing.Size(251, 143);
            this.aracsil.TabIndex = 11;
            this.aracsil.Text = "Araç Sil";
            this.aracsil.UseVisualStyleBackColor = false;
            this.aracsil.Click += new System.EventHandler(this.aracsil_Click);
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
            this.button2.Location = new System.Drawing.Point(1356, 920);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 83);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__21_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aracsil);
            this.Controls.Add(this.aracekle);
            this.DoubleBuffered = true;
            this.Name = "EkleSil";
            this.Text = "EkleSil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EkleSil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aracekle;
        private System.Windows.Forms.Button aracsil;
        private System.Windows.Forms.Button button2;
    }
}