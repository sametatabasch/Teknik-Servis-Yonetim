using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
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
            lbl_secilen_ad_soyad = new Label();
            btn_secilen_duzenle = new Button();
            btn_secilen_sil = new Button();
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
            dgw_calisan_listesi.CellClick += dgw_calisan_listesi_CellClick;
            // 
            // lbl_secilen_ad_soyad
            // 
            lbl_secilen_ad_soyad.AutoSize = true;
            lbl_secilen_ad_soyad.Location = new Point(392, 360);
            lbl_secilen_ad_soyad.Name = "lbl_secilen_ad_soyad";
            lbl_secilen_ad_soyad.Size = new Size(76, 15);
            lbl_secilen_ad_soyad.TabIndex = 1;
            lbl_secilen_ad_soyad.Text = "Çalışan Seçin";
            // 
            // btn_secilen_duzenle
            // 
            btn_secilen_duzenle.AutoSize = true;
            btn_secilen_duzenle.Location = new Point(100, 411);
            btn_secilen_duzenle.Name = "btn_secilen_duzenle";
            btn_secilen_duzenle.Size = new Size(75, 25);
            btn_secilen_duzenle.TabIndex = 2;
            btn_secilen_duzenle.Text = "Düzenle";
            btn_secilen_duzenle.UseVisualStyleBackColor = true;
            btn_secilen_duzenle.Click += btn_secilen_duzenle_Click;
            // 
            // btn_secilen_sil
            // 
            btn_secilen_sil.AutoSize = true;
            btn_secilen_sil.Location = new Point(661, 411);
            btn_secilen_sil.Name = "btn_secilen_sil";
            btn_secilen_sil.Size = new Size(75, 25);
            btn_secilen_sil.TabIndex = 2;
            btn_secilen_sil.Text = "Sil";
            btn_secilen_sil.UseVisualStyleBackColor = true;
            btn_secilen_sil.Click += btn_secilen_sil_Click;
            // 
            // UcCalisanListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_secilen_sil);
            Controls.Add(btn_secilen_duzenle);
            Controls.Add(lbl_secilen_ad_soyad);
            Controls.Add(dgw_calisan_listesi);
            Name = "UcCalisanListesi";
            Size = new Size(842, 462);
            Load += UcCalisanListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_calisan_listesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_calisan_listesi;
        private Label lbl_secilen_ad_soyad;
        private Button btn_secilen_duzenle;
        private Button btn_secilen_sil;
    }
}
