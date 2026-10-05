namespace Teknik_Servis_Yönetim
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_calisan_foto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_calisan_kaydet
            // 
            btn_calisan_kaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_calisan_kaydet.Location = new Point(629, 398);
            btn_calisan_kaydet.Name = "btn_calisan_kaydet";
            btn_calisan_kaydet.Size = new Size(75, 23);
            btn_calisan_kaydet.TabIndex = 0;
            btn_calisan_kaydet.Text = "Kaydet";
            btn_calisan_kaydet.UseVisualStyleBackColor = true;
            btn_calisan_kaydet.Click += btn_calisan_kaydet_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // btn_calisan_foto_ekle
            // 
            btn_calisan_foto_ekle.Location = new Point(583, 141);
            btn_calisan_foto_ekle.Name = "btn_calisan_foto_ekle";
            btn_calisan_foto_ekle.Size = new Size(100, 23);
            btn_calisan_foto_ekle.TabIndex = 5;
            btn_calisan_foto_ekle.Text = "Fotoğraf Seç";
            btn_calisan_foto_ekle.UseVisualStyleBackColor = true;
            btn_calisan_foto_ekle.Click += btn_calisan_foto_ekle_Click;
            // 
            // dtp_calisan_d_tarihi
            // 
            dtp_calisan_d_tarihi.Format = DateTimePickerFormat.Short;
            dtp_calisan_d_tarihi.Location = new Point(92, 119);
            dtp_calisan_d_tarihi.Name = "dtp_calisan_d_tarihi";
            dtp_calisan_d_tarihi.Size = new Size(99, 23);
            dtp_calisan_d_tarihi.TabIndex = 4;
            // 
            // radio_calisan_cinsiyet_kadin
            // 
            radio_calisan_cinsiyet_kadin.AutoSize = true;
            radio_calisan_cinsiyet_kadin.Location = new Point(152, 94);
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
            radio_calisan_cinsiyet_erkek.Location = new Point(93, 94);
            radio_calisan_cinsiyet_erkek.Name = "radio_calisan_cinsiyet_erkek";
            radio_calisan_cinsiyet_erkek.Size = new Size(53, 19);
            radio_calisan_cinsiyet_erkek.TabIndex = 3;
            radio_calisan_cinsiyet_erkek.TabStop = true;
            radio_calisan_cinsiyet_erkek.Text = "Erkek";
            radio_calisan_cinsiyet_erkek.UseVisualStyleBackColor = true;
            // 
            // pcb_calisan_foto
            // 
            pcb_calisan_foto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcb_calisan_foto.Location = new Point(583, 22);
            pcb_calisan_foto.Name = "pcb_calisan_foto";
            pcb_calisan_foto.Size = new Size(100, 113);
            pcb_calisan_foto.SizeMode = PictureBoxSizeMode.Zoom;
            pcb_calisan_foto.TabIndex = 2;
            pcb_calisan_foto.TabStop = false;
            // 
            // txt_calisan_tc
            // 
            txt_calisan_tc.Location = new Point(91, 146);
            txt_calisan_tc.MaxLength = 11;
            txt_calisan_tc.Name = "txt_calisan_tc";
            txt_calisan_tc.Size = new Size(100, 23);
            txt_calisan_tc.TabIndex = 1;
            // 
            // lbl_calisan_tc
            // 
            lbl_calisan_tc.AutoSize = true;
            lbl_calisan_tc.Location = new Point(6, 149);
            lbl_calisan_tc.Name = "lbl_calisan_tc";
            lbl_calisan_tc.Size = new Size(21, 15);
            lbl_calisan_tc.TabIndex = 0;
            lbl_calisan_tc.Text = "TC";
            // 
            // lbl_calisan_d_tarihi
            // 
            lbl_calisan_d_tarihi.AutoSize = true;
            lbl_calisan_d_tarihi.Location = new Point(6, 120);
            lbl_calisan_d_tarihi.Name = "lbl_calisan_d_tarihi";
            lbl_calisan_d_tarihi.Size = new Size(79, 15);
            lbl_calisan_d_tarihi.TabIndex = 0;
            lbl_calisan_d_tarihi.Text = "Doğum Tarihi";
            // 
            // lbl_calisan_cinsiyet
            // 
            lbl_calisan_cinsiyet.AutoSize = true;
            lbl_calisan_cinsiyet.Location = new Point(6, 91);
            lbl_calisan_cinsiyet.Name = "lbl_calisan_cinsiyet";
            lbl_calisan_cinsiyet.Size = new Size(49, 15);
            lbl_calisan_cinsiyet.TabIndex = 0;
            lbl_calisan_cinsiyet.Text = "Cinsiyet";
            // 
            // txt_calisan_soyadi
            // 
            txt_calisan_soyadi.Location = new Point(91, 59);
            txt_calisan_soyadi.Name = "txt_calisan_soyadi";
            txt_calisan_soyadi.Size = new Size(100, 23);
            txt_calisan_soyadi.TabIndex = 1;
            // 
            // lbl_calisan_soyadi
            // 
            lbl_calisan_soyadi.AutoSize = true;
            lbl_calisan_soyadi.Location = new Point(6, 62);
            lbl_calisan_soyadi.Name = "lbl_calisan_soyadi";
            lbl_calisan_soyadi.Size = new Size(45, 15);
            lbl_calisan_soyadi.TabIndex = 0;
            lbl_calisan_soyadi.Text = "Soyadı:";
            // 
            // txt_calisan_adi
            // 
            txt_calisan_adi.Location = new Point(91, 30);
            txt_calisan_adi.Name = "txt_calisan_adi";
            txt_calisan_adi.Size = new Size(100, 23);
            txt_calisan_adi.TabIndex = 1;
            // 
            // lbl_calisan_adi
            // 
            lbl_calisan_adi.AutoSize = true;
            lbl_calisan_adi.Location = new Point(6, 33);
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
            groupBox2.Controls.Add(mtxt_calisan_gsm);
            groupBox2.Controls.Add(txt_calisan_adres);
            groupBox2.Controls.Add(lbl_calisan_adres);
            groupBox2.Controls.Add(txt_calisan_email);
            groupBox2.Controls.Add(lbl_calisan_email);
            groupBox2.Controls.Add(lbl_calisan_gsm);
            groupBox2.Location = new Point(3, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(712, 156);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "İletişim Bilgileri ";
            // 
            // mtxt_calisan_gsm
            // 
            mtxt_calisan_gsm.Location = new Point(92, 30);
            mtxt_calisan_gsm.Mask = "(999) 000 00  00";
            mtxt_calisan_gsm.Name = "mtxt_calisan_gsm";
            mtxt_calisan_gsm.Size = new Size(100, 23);
            mtxt_calisan_gsm.TabIndex = 2;
            // 
            // txt_calisan_adres
            // 
            txt_calisan_adres.Location = new Point(91, 88);
            txt_calisan_adres.Multiline = true;
            txt_calisan_adres.Name = "txt_calisan_adres";
            txt_calisan_adres.Size = new Size(383, 62);
            txt_calisan_adres.TabIndex = 1;
            // 
            // lbl_calisan_adres
            // 
            lbl_calisan_adres.AutoSize = true;
            lbl_calisan_adres.Location = new Point(6, 91);
            lbl_calisan_adres.Name = "lbl_calisan_adres";
            lbl_calisan_adres.Size = new Size(37, 15);
            lbl_calisan_adres.TabIndex = 0;
            lbl_calisan_adres.Text = "Adres";
            // 
            // txt_calisan_email
            // 
            txt_calisan_email.Location = new Point(91, 59);
            txt_calisan_email.Name = "txt_calisan_email";
            txt_calisan_email.Size = new Size(235, 23);
            txt_calisan_email.TabIndex = 1;
            // 
            // lbl_calisan_email
            // 
            lbl_calisan_email.AutoSize = true;
            lbl_calisan_email.Location = new Point(6, 62);
            lbl_calisan_email.Name = "lbl_calisan_email";
            lbl_calisan_email.Size = new Size(41, 15);
            lbl_calisan_email.TabIndex = 0;
            lbl_calisan_email.Text = "E-mail";
            // 
            // lbl_calisan_gsm
            // 
            lbl_calisan_gsm.AutoSize = true;
            lbl_calisan_gsm.Location = new Point(6, 33);
            lbl_calisan_gsm.Name = "lbl_calisan_gsm";
            lbl_calisan_gsm.Size = new Size(49, 15);
            lbl_calisan_gsm.TabIndex = 0;
            lbl_calisan_gsm.Text = "Cep Tel:";
            // 
            // UcCalisanEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_calisan_kaydet);
            Name = "UcCalisanEkle";
            Size = new Size(715, 432);
            Load += UcCalisanEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_calisan_foto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}
