namespace Teknik_Servis_Yönetim.UserControls
{
    partial class UcCalisanListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            dgw_calisan_listesi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgw_calisan_listesi).BeginInit();
            SuspendLayout();
            // 
            // dgw_calisan_listesi
            // 
            dgw_calisan_listesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_calisan_listesi.Dock = DockStyle.Top;
            dgw_calisan_listesi.Location = new Point(0, 0);
            dgw_calisan_listesi.Name = "dgw_calisan_listesi";
            dgw_calisan_listesi.Size = new Size(842, 320);
            dgw_calisan_listesi.TabIndex = 0;
            // 
            // UcCalisanListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgw_calisan_listesi);
            Name = "UcCalisanListesi";
            Size = new Size(842, 405);
            Load += UcCalisanListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_calisan_listesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgw_calisan_listesi;
    }
}
