namespace Pahamdiri
{
    partial class Nama
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.tbPekerjaan = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(100, 45);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // lblNoTelp
            // 
            this.lblNoTelp.AutoSize = true;
            this.lblNoTelp.Location = new System.Drawing.Point(33, 92);
            this.lblNoTelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(117, 20);
            this.lblNoTelp.TabIndex = 1;
            this.lblNoTelp.Text = "Nomor Telepon";
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(70, 151);
            this.lblPekerjaan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(80, 20);
            this.lblPekerjaan.TabIndex = 2;
            this.lblPekerjaan.Text = "Pekerjaan";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(162, 45);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(202, 26);
            this.tbNama.TabIndex = 3;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.Location = new System.Drawing.Point(162, 92);
            this.tbNoTelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(202, 26);
            this.tbNoTelp.TabIndex = 4;
            // 
            // tbPekerjaan
            // 
            this.tbPekerjaan.Location = new System.Drawing.Point(162, 146);
            this.tbPekerjaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPekerjaan.Name = "tbPekerjaan";
            this.tbPekerjaan.Size = new System.Drawing.Size(202, 26);
            this.tbPekerjaan.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(254, 215);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(38, 215);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Nama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 269);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbPekerjaan);
            this.Controls.Add(this.tbNoTelp);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblPekerjaan);
            this.Controls.Add(this.lblNoTelp);
            this.Controls.Add(this.lblNama);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Nama";
            this.Text = "Nama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.TextBox tbPekerjaan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReset;
    }
}