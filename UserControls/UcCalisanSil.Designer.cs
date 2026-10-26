using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Teknik_Servis_Yönetim.UserControls
{
    partial class UcCalisanSil
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
            cb_calisan_listesi = new ComboBox();
            btn_calisan_sil = new Button();
            SuspendLayout();
            // 
            // cb_calisan_listesi
            // 
            cb_calisan_listesi.FormattingEnabled = true;
            cb_calisan_listesi.Location = new Point(69, 19);
            cb_calisan_listesi.Name = "cb_calisan_listesi";
            cb_calisan_listesi.Size = new Size(415, 23);
            cb_calisan_listesi.TabIndex = 1;
            // 
            // btn_calisan_sil
            // 
            btn_calisan_sil.Location = new Point(236, 80);
            btn_calisan_sil.Name = "btn_calisan_sil";
            btn_calisan_sil.Size = new Size(75, 23);
            btn_calisan_sil.TabIndex = 2;
            btn_calisan_sil.Text = "Seçilen Çalışanı Sil";
            btn_calisan_sil.UseVisualStyleBackColor = true;
            btn_calisan_sil.Click += btn_calisan_sil_Click;
            // 
            // UcCalisanSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_calisan_sil);
            Controls.Add(cb_calisan_listesi);
            Name = "UcCalisanSil";
            Size = new Size(562, 353);
            Load += UcCalisanSil_Load;
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cb_calisan_listesi;
        private Button btn_calisan_sil;
    }
}
