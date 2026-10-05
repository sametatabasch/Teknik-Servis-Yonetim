namespace Teknik_Servis_Yönetim
{
    partial class form_baslangic
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
            menuStrip1 = new MenuStrip();
            tsmi_dosya = new ToolStripMenuItem();
            tsmi_profif = new ToolStripMenuItem();
            tsmi_ayarlar = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmi_cikis = new ToolStripMenuItem();
            tsmi_calisan_islemleri = new ToolStripMenuItem();
            tsmi_calisan_listesi = new ToolStripMenuItem();
            tsmi_calisan_ekle = new ToolStripMenuItem();
            tsmi_calisan_duzenle = new ToolStripMenuItem();
            tsmi_calisan_sil = new ToolStripMenuItem();
            pnl_ana_panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmi_dosya, tsmi_calisan_islemleri });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1027, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_dosya
            // 
            tsmi_dosya.DropDownItems.AddRange(new ToolStripItem[] { tsmi_profif, tsmi_ayarlar, toolStripSeparator1, tsmi_cikis });
            tsmi_dosya.Name = "tsmi_dosya";
            tsmi_dosya.Size = new Size(51, 20);
            tsmi_dosya.Text = "Dosya";
            // 
            // tsmi_profif
            // 
            tsmi_profif.Name = "tsmi_profif";
            tsmi_profif.Size = new Size(141, 22);
            tsmi_profif.Text = "Profil";
            // 
            // tsmi_ayarlar
            // 
            tsmi_ayarlar.Name = "tsmi_ayarlar";
            tsmi_ayarlar.Size = new Size(141, 22);
            tsmi_ayarlar.Text = "Ayarlar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            // 
            // tsmi_cikis
            // 
            tsmi_cikis.Name = "tsmi_cikis";
            tsmi_cikis.ShortcutKeyDisplayString = "Alt+F4";
            tsmi_cikis.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmi_cikis.Size = new Size(141, 22);
            tsmi_cikis.Tag = "";
            tsmi_cikis.Text = "Çıkış";
            tsmi_cikis.Click += tsmi_cikis_Click;
            // 
            // tsmi_calisan_islemleri
            // 
            tsmi_calisan_islemleri.DropDownItems.AddRange(new ToolStripItem[] { tsmi_calisan_listesi, tsmi_calisan_ekle, tsmi_calisan_duzenle, tsmi_calisan_sil });
            tsmi_calisan_islemleri.Name = "tsmi_calisan_islemleri";
            tsmi_calisan_islemleri.Size = new Size(104, 20);
            tsmi_calisan_islemleri.Text = "Çalışan İşlemleri";
            // 
            // tsmi_calisan_listesi
            // 
            tsmi_calisan_listesi.Name = "tsmi_calisan_listesi";
            tsmi_calisan_listesi.Size = new Size(180, 22);
            tsmi_calisan_listesi.Text = "Çalışan Listesi";
            tsmi_calisan_listesi.Click += tsmi_calisan_listesi_Click;
            // 
            // tsmi_calisan_ekle
            // 
            tsmi_calisan_ekle.Name = "tsmi_calisan_ekle";
            tsmi_calisan_ekle.Size = new Size(180, 22);
            tsmi_calisan_ekle.Text = "Çalışan Ekle";
            tsmi_calisan_ekle.Click += tsmi_calisan_ekle_Click;
            // 
            // tsmi_calisan_duzenle
            // 
            tsmi_calisan_duzenle.Name = "tsmi_calisan_duzenle";
            tsmi_calisan_duzenle.Size = new Size(180, 22);
            tsmi_calisan_duzenle.Text = "Çalışan Düzenle";
            tsmi_calisan_duzenle.Click += tsmi_calisan_duzenle_Click;
            // 
            // tsmi_calisan_sil
            // 
            tsmi_calisan_sil.Name = "tsmi_calisan_sil";
            tsmi_calisan_sil.Size = new Size(180, 22);
            tsmi_calisan_sil.Text = "Çalışan Sil";
            tsmi_calisan_sil.Click += tsmi_calisan_sil_Click;
            // 
            // pnl_ana_panel
            // 
            pnl_ana_panel.Dock = DockStyle.Fill;
            pnl_ana_panel.Location = new Point(0, 24);
            pnl_ana_panel.Name = "pnl_ana_panel";
            pnl_ana_panel.Size = new Size(1027, 522);
            pnl_ana_panel.TabIndex = 1;
            // 
            // form_baslangic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 546);
            Controls.Add(pnl_ana_panel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "form_baslangic";
            ShowIcon = false;
            Text = "TMYO Teknik Servis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmi_dosya;
        private ToolStripMenuItem tsmi_profif;
        private ToolStripMenuItem tsmi_ayarlar;
        private ToolStripMenuItem tsmi_cikis;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmi_calisan_islemleri;
        private ToolStripMenuItem tsmi_calisan_listesi;
        private ToolStripMenuItem tsmi_calisan_ekle;
        private ToolStripMenuItem tsmi_calisan_duzenle;
        private ToolStripMenuItem tsmi_calisan_sil;
        private Panel pnl_ana_panel;
    }
}