namespace Pahamdiri
{
    partial class Histori
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosaDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Pahamdiri.Database1DataSet();
            this.diagnosaDBTableAdapter = new Pahamdiri.Database1DataSetTableAdapters.DiagnosaDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosaDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histori";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(471, 202);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Back";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.diagnosaDataGridViewTextBoxColumn,
            this.keluhanDataGridViewTextBoxColumn,
            this.saranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diagnosaDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanggalDataGridViewTextBoxColumn.Width = 82;
            // 
            // diagnosaDataGridViewTextBoxColumn
            // 
            this.diagnosaDataGridViewTextBoxColumn.DataPropertyName = "Diagnosa";
            this.diagnosaDataGridViewTextBoxColumn.HeaderText = "Diagnosa";
            this.diagnosaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diagnosaDataGridViewTextBoxColumn.Name = "diagnosaDataGridViewTextBoxColumn";
            this.diagnosaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diagnosaDataGridViewTextBoxColumn.Width = 88;
            // 
            // keluhanDataGridViewTextBoxColumn
            // 
            this.keluhanDataGridViewTextBoxColumn.DataPropertyName = "Keluhan";
            this.keluhanDataGridViewTextBoxColumn.HeaderText = "Keluhan";
            this.keluhanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keluhanDataGridViewTextBoxColumn.Name = "keluhanDataGridViewTextBoxColumn";
            this.keluhanDataGridViewTextBoxColumn.ReadOnly = true;
            this.keluhanDataGridViewTextBoxColumn.Width = 82;
            // 
            // saranDataGridViewTextBoxColumn
            // 
            this.saranDataGridViewTextBoxColumn.DataPropertyName = "Saran";
            this.saranDataGridViewTextBoxColumn.HeaderText = "Saran";
            this.saranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saranDataGridViewTextBoxColumn.Name = "saranDataGridViewTextBoxColumn";
            this.saranDataGridViewTextBoxColumn.ReadOnly = true;
            this.saranDataGridViewTextBoxColumn.Width = 71;
            // 
            // diagnosaDBBindingSource
            // 
            this.diagnosaDBBindingSource.DataMember = "DiagnosaDB";
            this.diagnosaDBBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosaDBTableAdapter
            // 
            this.diagnosaDBTableAdapter.ClearBeforeFill = true;
            // 
            // Histori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 241);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label1);
            this.Name = "Histori";
            this.Text = "Histori";
            this.Load += new System.EventHandler(this.Histori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosaDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource diagnosaDBBindingSource;
        private Database1DataSetTableAdapters.DiagnosaDBTableAdapter diagnosaDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keluhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saranDataGridViewTextBoxColumn;
    }
}