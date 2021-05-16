namespace BorsaProjesi
{
    partial class Islemler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.islemzamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemdetayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcanantutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicikalanpara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemzamani,
            this.islemdetayi,
            this.harcanantutar,
            this.alicikalanpara,
            this.birimfiyat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // islemzamani
            // 
            this.islemzamani.HeaderText = "İşlem Zamanı";
            this.islemzamani.Name = "islemzamani";
            // 
            // islemdetayi
            // 
            this.islemdetayi.HeaderText = "Yapılan İşlem Detayı";
            this.islemdetayi.Name = "islemdetayi";
            // 
            // harcanantutar
            // 
            this.harcanantutar.HeaderText = "Harcanan Tutar";
            this.harcanantutar.Name = "harcanantutar";
            // 
            // alicikalanpara
            // 
            this.alicikalanpara.HeaderText = "Alıcının Kalan Parası";
            this.alicikalanpara.Name = "alicikalanpara";
            // 
            // birimfiyat
            // 
            this.birimfiyat.HeaderText = "Satılan Malın Birim Fiyatı";
            this.birimfiyat.Name = "birimfiyat";
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Islemler";
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.Islemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemzamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemdetayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcanantutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicikalanpara;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyat;
    }
}