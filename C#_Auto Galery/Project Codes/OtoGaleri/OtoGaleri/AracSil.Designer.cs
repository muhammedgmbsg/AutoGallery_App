namespace OtoGaleri
{
    partial class AracSil
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
            this.ASsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ASserino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ASsil
            // 
            this.ASsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ASsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ASsil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ASsil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ASsil.FlatAppearance.BorderSize = 0;
            this.ASsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ASsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.ASsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ASsil.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ASsil.Location = new System.Drawing.Point(648, 623);
            this.ASsil.Name = "ASsil";
            this.ASsil.Size = new System.Drawing.Size(159, 42);
            this.ASsil.TabIndex = 12;
            this.ASsil.Text = "Aracı Kaldır";
            this.ASsil.UseVisualStyleBackColor = false;
            this.ASsil.Click += new System.EventHandler(this.ASsil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__13_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1435, 930);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 83);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ASserino
            // 
            this.ASserino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ASserino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ASserino.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ASserino.ForeColor = System.Drawing.Color.Silver;
            this.ASserino.Location = new System.Drawing.Point(402, 479);
            this.ASserino.Multiline = true;
            this.ASserino.Name = "ASserino";
            this.ASserino.Size = new System.Drawing.Size(405, 31);
            this.ASserino.TabIndex = 14;
            this.ASserino.TextChanged += new System.EventHandler(this.ASserino_TextChanged);
            // 
            // AracSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__22_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ASserino);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ASsil);
            this.DoubleBuffered = true;
            this.Name = "AracSil";
            this.Text = "AracSil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AracSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ASsil;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ASserino;
    }
}