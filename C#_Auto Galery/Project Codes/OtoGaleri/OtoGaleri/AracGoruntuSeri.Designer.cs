namespace OtoGaleri
{
    partial class AracGoruntuSeri
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
            this.AGSaracgoster = new System.Windows.Forms.Button();
            this.AGSserino = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AGSaracgoster
            // 
            this.AGSaracgoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.AGSaracgoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AGSaracgoster.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AGSaracgoster.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AGSaracgoster.FlatAppearance.BorderSize = 0;
            this.AGSaracgoster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.AGSaracgoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.AGSaracgoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AGSaracgoster.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGSaracgoster.Location = new System.Drawing.Point(716, 586);
            this.AGSaracgoster.Name = "AGSaracgoster";
            this.AGSaracgoster.Size = new System.Drawing.Size(159, 42);
            this.AGSaracgoster.TabIndex = 13;
            this.AGSaracgoster.Text = "Aracı Göster";
            this.AGSaracgoster.UseVisualStyleBackColor = false;
            this.AGSaracgoster.Click += new System.EventHandler(this.AGSaracgoster_Click);
            // 
            // AGSserino
            // 
            this.AGSserino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.AGSserino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AGSserino.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AGSserino.ForeColor = System.Drawing.Color.Silver;
            this.AGSserino.Location = new System.Drawing.Point(470, 436);
            this.AGSserino.Multiline = true;
            this.AGSserino.Name = "AGSserino";
            this.AGSserino.Size = new System.Drawing.Size(405, 31);
            this.AGSserino.TabIndex = 15;
            this.AGSserino.TextChanged += new System.EventHandler(this.AGSserino_TextChanged);
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
            this.button1.Location = new System.Drawing.Point(1431, 920);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 83);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AracGoruntuSeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OtoGaleri.Properties.Resources.Colorful_Gradient_Memphis_Disruptive_Brainstorming_Online_Whiteboard__23_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AGSserino);
            this.Controls.Add(this.AGSaracgoster);
            this.DoubleBuffered = true;
            this.Name = "AracGoruntuSeri";
            this.Text = "AracGoruntuSeri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AracGoruntuSeri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AGSaracgoster;
        public System.Windows.Forms.TextBox AGSserino;
        private System.Windows.Forms.Button button1;
    }
}