namespace Pahamdiri
{
    partial class Diagnosis
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
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblKondisi = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.gbKondisi = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHistori = new System.Windows.Forms.Button();
            this.lblSaran = new System.Windows.Forms.RichTextBox();
            this.tbKeluhan = new System.Windows.Forms.RichTextBox();
            this.lblKeluhan = new System.Windows.Forms.Label();
            this.gbKondisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbldesc.Location = new System.Drawing.Point(75, 31);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(344, 20);
            this.lbldesc.TabIndex = 0;
            this.lbldesc.Text = "Halo, hasil diagnosis menunjukkan kalau Anda :";
            // 
            // lblKondisi
            // 
            this.lblKondisi.AutoEllipsis = true;
            this.lblKondisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKondisi.Location = new System.Drawing.Point(14, 15);
            this.lblKondisi.Name = "lblKondisi";
            this.lblKondisi.Size = new System.Drawing.Size(309, 35);
            this.lblKondisi.TabIndex = 1;
            this.lblKondisi.Text = "Kondisi";
            this.lblKondisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Location = new System.Drawing.Point(40, 237);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(179, 20);
            this.lblDesc2.TabIndex = 2;
            this.lblDesc2.Text = "Saran dari kami adalah :";
            // 
            // gbKondisi
            // 
            this.gbKondisi.Controls.Add(this.lblKondisi);
            this.gbKondisi.Location = new System.Drawing.Point(80, 52);
            this.gbKondisi.Name = "gbKondisi";
            this.gbKondisi.Size = new System.Drawing.Size(334, 58);
            this.gbKondisi.TabIndex = 3;
            this.gbKondisi.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(242, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnHistori
            // 
            this.btnHistori.Location = new System.Drawing.Point(360, 376);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(100, 40);
            this.btnHistori.TabIndex = 6;
            this.btnHistori.Text = "Histori";
            this.btnHistori.UseVisualStyleBackColor = true;
            this.btnHistori.Click += new System.EventHandler(this.BtnHistori_Click);
            // 
            // lblSaran
            // 
            this.lblSaran.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaran.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblSaran.Location = new System.Drawing.Point(44, 260);
            this.lblSaran.Name = "lblSaran";
            this.lblSaran.ReadOnly = true;
            this.lblSaran.Size = new System.Drawing.Size(416, 90);
            this.lblSaran.TabIndex = 7;
            this.lblSaran.Text = "";
            // 
            // tbKeluhan
            // 
            this.tbKeluhan.BackColor = System.Drawing.SystemColors.Menu;
            this.tbKeluhan.Location = new System.Drawing.Point(46, 152);
            this.tbKeluhan.Name = "tbKeluhan";
            this.tbKeluhan.ReadOnly = true;
            this.tbKeluhan.Size = new System.Drawing.Size(416, 62);
            this.tbKeluhan.TabIndex = 8;
            this.tbKeluhan.Text = "";
            // 
            // lblKeluhan
            // 
            this.lblKeluhan.AutoSize = true;
            this.lblKeluhan.Location = new System.Drawing.Point(42, 129);
            this.lblKeluhan.Name = "lblKeluhan";
            this.lblKeluhan.Size = new System.Drawing.Size(117, 20);
            this.lblKeluhan.TabIndex = 9;
            this.lblKeluhan.Text = "Keluhan Anda :";
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 441);
            this.Controls.Add(this.lblKeluhan);
            this.Controls.Add(this.tbKeluhan);
            this.Controls.Add(this.lblSaran);
            this.Controls.Add(this.btnHistori);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbKondisi);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.lbldesc);
            this.Name = "Diagnosis";
            this.Text = "Diagnosis";
            this.gbKondisi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblKondisi;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.GroupBox gbKondisi;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHistori;
        private System.Windows.Forms.RichTextBox lblSaran;
        private System.Windows.Forms.RichTextBox tbKeluhan;
        private System.Windows.Forms.Label lblKeluhan;
    }
}