namespace Pahamdiri
{
    partial class mainMenu
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnKuesioner = new System.Windows.Forms.Button();
            this.btnHistori = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gbBesar1 = new System.Windows.Forms.GroupBox();
            this.gbBesar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(6, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(204, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Halo, Selamat Datang";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKuesioner
            // 
            this.btnKuesioner.Location = new System.Drawing.Point(150, 96);
            this.btnKuesioner.Name = "btnKuesioner";
            this.btnKuesioner.Size = new System.Drawing.Size(104, 42);
            this.btnKuesioner.TabIndex = 1;
            this.btnKuesioner.Text = "Isi Kuesioner";
            this.btnKuesioner.UseVisualStyleBackColor = true;
            this.btnKuesioner.Click += new System.EventHandler(this.btnKuesioner_Click);
            // 
            // btnHistori
            // 
            this.btnHistori.Location = new System.Drawing.Point(22, 184);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(75, 23);
            this.btnHistori.TabIndex = 2;
            this.btnHistori.Text = "Histori";
            this.btnHistori.UseVisualStyleBackColor = true;
            this.btnHistori.Click += new System.EventHandler(this.btnHistori_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(315, 184);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbBesar1
            // 
            this.gbBesar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbBesar1.BackColor = System.Drawing.Color.Transparent;
            this.gbBesar1.Controls.Add(this.lblWelcome);
            this.gbBesar1.Location = new System.Drawing.Point(95, 24);
            this.gbBesar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBesar1.MinimumSize = new System.Drawing.Size(218, 40);
            this.gbBesar1.Name = "gbBesar1";
            this.gbBesar1.Padding = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.gbBesar1.Size = new System.Drawing.Size(218, 57);
            this.gbBesar1.TabIndex = 7;
            this.gbBesar1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 219);
            this.Controls.Add(this.gbBesar1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHistori);
            this.Controls.Add(this.btnKuesioner);
            this.Name = "mainMenu";
            this.Text = "PahamDiri";
            this.gbBesar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnKuesioner;
        private System.Windows.Forms.Button btnHistori;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox gbBesar1;
    }
}

