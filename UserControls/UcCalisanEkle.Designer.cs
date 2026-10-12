namespace Teknik_Servis_Yönetim.UserControls
{
    partial class UcCalisanEkle
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
            btn_calisan_kaydet = new Button();
            groupBox1 = new GroupBox();
            btn_calisan_foto_ekle = new Button();
            dtp_calisan_d_tarihi = new DateTimePicker();
            radio_calisan_cinsiyet_kadin = new RadioButton();
            radio_calisan_cinsiyet_erkek = new RadioButton();
            pcb_calisan_foto = new PictureBox();
            txt_calisan_tc = new TextBox();
            lbl_calisan_tc = new Label();
            lbl_calisan_d_tarihi = new Label();
            lbl_calisan_cinsiyet = new Label();
            txt_calisan_soyadi = new TextBox();
            lbl_calisan_soyadi = new Label();
            txt_calisan_adi = new TextBox();
            lbl_calisan_adi = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox2 = new GroupBox();
            mtxt_calisan_gsm = new MaskedTextBox();
            txt_calisan_adres = new TextBox();
            lbl_calisan_adres = new Label();
            txt_calisan_email = new TextBox();
            lbl_calisan_email = new Label();
            lbl_calisan_gsm = new Label();
            groupBox3 = new GroupBox();
            dtp_calisan_baslama_tarihi = new DateTimePicker();
            lbl_calisan_baslama_tarihi = new Label();
            nud_calisan_maas = new NumericUpDown();
            lbl_calisan_maas = new Label();
            cmb_calisan_yetki = new ComboBox();
            lbl_calisan_yetki = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_calisan_foto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_calisan_maas).BeginInit();
            SuspendLayout();
            // 
            // btn_calisan_kaydet
            // 
            btn_calisan_kaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_calisan_kaydet.Location = new Point(622, 401);
            btn_calisan_kaydet.Name = "btn_calisan_kaydet";
            btn_calisan_kaydet.Size = new Size(96, 28);
            btn_calisan_kaydet.TabIndex = 4;
            btn_calisan_kaydet.Text = "Kaydet";
            btn_calisan_kaydet.UseVisualStyleBackColor = true;
            btn_calisan_kaydet.Click += btn_calisan_kaydet_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_calisan_foto_ekle);
            groupBox1.Controls.Add(dtp_calisan_d_tarihi);
            groupBox1.Controls.Add(radio_calisan_cinsiyet_kadin);
            groupBox1.Controls.Add(radio_calisan_cinsiyet_erkek);
            groupBox1.Controls.Add(pcb_calisan_foto);
            groupBox1.Controls.Add(txt_calisan_tc);
            groupBox1.Controls.Add(lbl_calisan_tc);
            groupBox1.Controls.Add(lbl_calisan_d_tarihi);
            groupBox1.Controls.Add(lbl_calisan_cinsiyet);
            groupBox1.Controls.Add(txt_calisan_soyadi);
            groupBox1.Controls.Add(lbl_calisan_soyadi);
            groupBox1.Controls.Add(txt_calisan_adi);
            groupBox1.Controls.Add(lbl_calisan_adi);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // btn_calisan_foto_ekle
            // 
            btn_calisan_foto_ekle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_calisan_foto_ekle.Location = new Point(585, 141);
            btn_calisan_foto_ekle.Name = "btn_calisan_foto_ekle";
            btn_calisan_foto_ekle.Size = new Size(100, 25);
            btn_calisan_foto_ekle.TabIndex = 6;
            btn_calisan_foto_ekle.Text = "Fotoğraf Seç";
            btn_calisan_foto_ekle.UseVisualStyleBackColor = true;
            btn_calisan_foto_ekle.Click += btn_calisan_foto_ekle_Click;
            // 
            // dtp_calisan_d_tarihi
            // 
            dtp_calisan_d_tarihi.Format = DateTimePickerFormat.Short;
            dtp_calisan_d_tarihi.Location = new Point(96, 114);
            dtp_calisan_d_tarihi.Name = "dtp_calisan_d_tarihi";
            dtp_calisan_d_tarihi.Size = new Size(118, 23);
            dtp_calisan_d_tarihi.TabIndex = 4;
            // 
            // radio_calisan_cinsiyet_kadin
            // 
            radio_calisan_cinsiyet_kadin.AutoSize = true;
            radio_calisan_cinsiyet_kadin.Location = new Point(155, 86);
            radio_calisan_cinsiyet_kadin.Name = "radio_calisan_cinsiyet_kadin";
            radio_calisan_cinsiyet_kadin.Size = new Size(55, 19);
            radio_calisan_cinsiyet_kadin.TabIndex = 3;
            radio_calisan_cinsiyet_kadin.TabStop = true;
            radio_calisan_cinsiyet_kadin.Text = "Kadın";
            radio_calisan_cinsiyet_kadin.UseVisualStyleBackColor = true;
            // 
            // radio_calisan_cinsiyet_erkek
            // 
            radio_calisan_cinsiyet_erkek.AutoSize = true;
            radio_calisan_cinsiyet_erkek.Location = new Point(96, 86);
            radio_calisan_cinsiyet_erkek.Name = "radio_calisan_cinsiyet_erkek";
            radio_calisan_cinsiyet_erkek.Size = new Size(53, 19);
            radio_calisan_cinsiyet_erkek.TabIndex = 2;
            radio_calisan_cinsiyet_erkek.TabStop = true;
            radio_calisan_cinsiyet_erkek.Text = "Erkek";
            radio_calisan_cinsiyet_erkek.UseVisualStyleBackColor = true;
            // 
            // pcb_calisan_foto
            // 
            pcb_calisan_foto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcb_calisan_foto.BorderStyle = BorderStyle.FixedSingle;
            pcb_calisan_foto.Location = new Point(585, 22);
            pcb_calisan_foto.Name = "pcb_calisan_foto";
            pcb_calisan_foto.Size = new Size(100, 113);
            pcb_calisan_foto.SizeMode = PictureBoxSizeMode.Zoom;
            pcb_calisan_foto.TabIndex = 2;
            pcb_calisan_foto.TabStop = false;
            // 
            // txt_calisan_tc
            // 
            txt_calisan_tc.Location = new Point(96, 143);
            txt_calisan_tc.MaxLength = 11;
            txt_calisan_tc.Name = "txt_calisan_tc";
            txt_calisan_tc.Size = new Size(118, 23);
            txt_calisan_tc.TabIndex = 5;
            // 
            // lbl_calisan_tc
            // 
            lbl_calisan_tc.AutoSize = true;
            lbl_calisan_tc.Location = new Point(14, 146);
            lbl_calisan_tc.Name = "lbl_calisan_tc";
            lbl_calisan_tc.Size = new Size(23, 15);
            lbl_calisan_tc.TabIndex = 0;
            lbl_calisan_tc.Text = "TC:";
            // 
            // lbl_calisan_d_tarihi
            // 
            lbl_calisan_d_tarihi.AutoSize = true;
            lbl_calisan_d_tarihi.Location = new Point(14, 117);
            lbl_calisan_d_tarihi.Name = "lbl_calisan_d_tarihi";
            lbl_calisan_d_tarihi.Size = new Size(81, 15);
            lbl_calisan_d_tarihi.TabIndex = 0;
            lbl_calisan_d_tarihi.Text = "Doğum Tarihi:";
            // 
            // lbl_calisan_cinsiyet
            // 
            lbl_calisan_cinsiyet.AutoSize = true;
            lbl_calisan_cinsiyet.Location = new Point(14, 88);
            lbl_calisan_cinsiyet.Name = "lbl_calisan_cinsiyet";
            lbl_calisan_cinsiyet.Size = new Size(52, 15);
            lbl_calisan_cinsiyet.TabIndex = 0;
            lbl_calisan_cinsiyet.Text = "Cinsiyet:";
            // 
            // txt_calisan_soyadi
            // 
            txt_calisan_soyadi.Location = new Point(96, 56);
            txt_calisan_soyadi.Name = "txt_calisan_soyadi";
            txt_calisan_soyadi.Size = new Size(155, 23);
            txt_calisan_soyadi.TabIndex = 1;
            // 
            // lbl_calisan_soyadi
            // 
            lbl_calisan_soyadi.AutoSize = true;
            lbl_calisan_soyadi.Location = new Point(14, 59);
            lbl_calisan_soyadi.Name = "lbl_calisan_soyadi";
            lbl_calisan_soyadi.Size = new Size(45, 15);
            lbl_calisan_soyadi.TabIndex = 0;
            lbl_calisan_soyadi.Text = "Soyadı:";
            // 
            // txt_calisan_adi
            // 
            txt_calisan_adi.Location = new Point(96, 27);
            txt_calisan_adi.Name = "txt_calisan_adi";
            txt_calisan_adi.Size = new Size(155, 23);
            txt_calisan_adi.TabIndex = 0;
            // 
            // lbl_calisan_adi
            // 
            lbl_calisan_adi.AutoSize = true;
            lbl_calisan_adi.Location = new Point(14, 30);
            lbl_calisan_adi.Name = "lbl_calisan_adi";
            lbl_calisan_adi.Size = new Size(28, 15);
            lbl_calisan_adi.TabIndex = 0;
            lbl_calisan_adi.Text = "Adı:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(mtxt_calisan_gsm);
            groupBox2.Controls.Add(txt_calisan_adres);
            groupBox2.Controls.Add(lbl_calisan_adres);
            groupBox2.Controls.Add(txt_calisan_email);
            groupBox2.Controls.Add(lbl_calisan_email);
            groupBox2.Controls.Add(lbl_calisan_gsm);
            groupBox2.Location = new Point(8, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(710, 118);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "İletişim Bilgileri";
            // 
            // mtxt_calisan_gsm
            // 
            mtxt_calisan_gsm.Location = new Point(96, 25);
            mtxt_calisan_gsm.Mask = "(999) 000-0000";
            mtxt_calisan_gsm.Name = "mtxt_calisan_gsm";
            mtxt_calisan_gsm.Size = new Size(118, 23);
            mtxt_calisan_gsm.TabIndex = 0;
            // 
            // txt_calisan_adres
            // 
            txt_calisan_adres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_calisan_adres.Location = new Point(96, 57);
            txt_calisan_adres.Multiline = true;
            txt_calisan_adres.Name = "txt_calisan_adres";
            txt_calisan_adres.Size = new Size(589, 48);
            txt_calisan_adres.TabIndex = 2;
            // 
            // lbl_calisan_adres
            // 
            lbl_calisan_adres.AutoSize = true;
            lbl_calisan_adres.Location = new Point(14, 60);
            lbl_calisan_adres.Name = "lbl_calisan_adres";
            lbl_calisan_adres.Size = new Size(40, 15);
            lbl_calisan_adres.TabIndex = 0;
            lbl_calisan_adres.Text = "Adres:";
            // 
            // txt_calisan_email
            // 
            txt_calisan_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_calisan_email.Location = new Point(307, 25);
            txt_calisan_email.Name = "txt_calisan_email";
            txt_calisan_email.Size = new Size(248, 23);
            txt_calisan_email.TabIndex = 1;
            // 
            // lbl_calisan_email
            // 
            lbl_calisan_email.AutoSize = true;
            lbl_calisan_email.Location = new Point(255, 28);
            lbl_calisan_email.Name = "lbl_calisan_email";
            lbl_calisan_email.Size = new Size(44, 15);
            lbl_calisan_email.TabIndex = 0;
            lbl_calisan_email.Text = "E-mail:";
            // 
            // lbl_calisan_gsm
            // 
            lbl_calisan_gsm.AutoSize = true;
            lbl_calisan_gsm.Location = new Point(14, 28);
            lbl_calisan_gsm.Name = "lbl_calisan_gsm";
            lbl_calisan_gsm.Size = new Size(49, 15);
            lbl_calisan_gsm.TabIndex = 0;
            lbl_calisan_gsm.Text = "Cep Tel:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dtp_calisan_baslama_tarihi);
            groupBox3.Controls.Add(lbl_calisan_baslama_tarihi);
            groupBox3.Controls.Add(nud_calisan_maas);
            groupBox3.Controls.Add(lbl_calisan_maas);
            groupBox3.Controls.Add(cmb_calisan_yetki);
            groupBox3.Controls.Add(lbl_calisan_yetki);
            groupBox3.Location = new Point(8, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(710, 72);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "İş ve Yetki Bilgileri";
            // 
            // dtp_calisan_baslama_tarihi
            // 
            dtp_calisan_baslama_tarihi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_calisan_baslama_tarihi.Format = DateTimePickerFormat.Short;
            dtp_calisan_baslama_tarihi.Location = new Point(568, 25);
            dtp_calisan_baslama_tarihi.Name = "dtp_calisan_baslama_tarihi";
            dtp_calisan_baslama_tarihi.Size = new Size(117, 23);
            dtp_calisan_baslama_tarihi.TabIndex = 2;
            // 
            // lbl_calisan_baslama_tarihi
            // 
            lbl_calisan_baslama_tarihi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_calisan_baslama_tarihi.AutoSize = true;
            lbl_calisan_baslama_tarihi.Location = new Point(477, 28);
            lbl_calisan_baslama_tarihi.Name = "lbl_calisan_baslama_tarihi";
            lbl_calisan_baslama_tarihi.Size = new Size(87, 15);
            lbl_calisan_baslama_tarihi.TabIndex = 0;
            lbl_calisan_baslama_tarihi.Text = "Başlama Tarihi:";
            // 
            // nud_calisan_maas
            // 
            nud_calisan_maas.DecimalPlaces = 2;
            nud_calisan_maas.Location = new Point(328, 25);
            nud_calisan_maas.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_calisan_maas.Name = "nud_calisan_maas";
            nud_calisan_maas.Size = new Size(118, 23);
            nud_calisan_maas.TabIndex = 1;
            nud_calisan_maas.ThousandsSeparator = true;
            // 
            // lbl_calisan_maas
            // 
            lbl_calisan_maas.AutoSize = true;
            lbl_calisan_maas.Location = new Point(285, 28);
            lbl_calisan_maas.Name = "lbl_calisan_maas";
            lbl_calisan_maas.Size = new Size(38, 15);
            lbl_calisan_maas.TabIndex = 0;
            lbl_calisan_maas.Text = "Maaş:";
            // 
            // cmb_calisan_yetki
            // 
            cmb_calisan_yetki.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_calisan_yetki.FormattingEnabled = true;
            cmb_calisan_yetki.Location = new Point(96, 25);
            cmb_calisan_yetki.Name = "cmb_calisan_yetki";
            cmb_calisan_yetki.Size = new Size(149, 23);
            cmb_calisan_yetki.TabIndex = 0;
            // 
            // lbl_calisan_yetki
            // 
            lbl_calisan_yetki.AutoSize = true;
            lbl_calisan_yetki.Location = new Point(14, 28);
            lbl_calisan_yetki.Name = "lbl_calisan_yetki";
            lbl_calisan_yetki.Size = new Size(36, 15);
            lbl_calisan_yetki.TabIndex = 0;
            lbl_calisan_yetki.Text = "Yetki:";
            // 
            // UcCalisanEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_calisan_kaydet);
            Name = "UcCalisanEkle";
            Size = new Size(726, 442);
            Load += UcCalisanEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_calisan_foto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_calisan_maas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_calisan_kaydet;
        private GroupBox groupBox1;
        private PictureBox pcb_calisan_foto;
        private TextBox txt_calisan_tc;
        private Label lbl_calisan_tc;
        private Label lbl_calisan_d_tarihi;
        private Label lbl_calisan_cinsiyet;
        private TextBox txt_calisan_soyadi;
        private Label lbl_calisan_soyadi;
        private TextBox txt_calisan_adi;
        private Label lbl_calisan_adi;
        private RadioButton radio_calisan_cinsiyet_kadin;
        private RadioButton radio_calisan_cinsiyet_erkek;
        private DateTimePicker dtp_calisan_d_tarihi;
        private OpenFileDialog openFileDialog1;
        private Button btn_calisan_foto_ekle;
        private GroupBox groupBox2;
        private MaskedTextBox mtxt_calisan_gsm;
        private TextBox txt_calisan_adres;
        private Label lbl_calisan_adres;
        private TextBox txt_calisan_email;
        private Label lbl_calisan_email;
        private Label lbl_calisan_gsm;
        private GroupBox groupBox3;
        private DateTimePicker dtp_calisan_baslama_tarihi;
        private Label lbl_calisan_baslama_tarihi;
        private NumericUpDown nud_calisan_maas;
        private Label lbl_calisan_maas;
        private ComboBox cmb_calisan_yetki;
        private Label lbl_calisan_yetki;
    }
}
