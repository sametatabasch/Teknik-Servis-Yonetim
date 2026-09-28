namespace Teknik_Servis_Yönetim
{
    partial class form_giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_kullanici_adi = new Label();
            lbl_parola = new Label();
            txt_kullanici_adi = new TextBox();
            txt_parola = new TextBox();
            btn_vacgec = new Button();
            btn_giris = new Button();
            SuspendLayout();
            // 
            // lbl_kullanici_adi
            // 
            lbl_kullanici_adi.AutoSize = true;
            lbl_kullanici_adi.Location = new Point(45, 46);
            lbl_kullanici_adi.Name = "lbl_kullanici_adi";
            lbl_kullanici_adi.Size = new Size(76, 15);
            lbl_kullanici_adi.TabIndex = 0;
            lbl_kullanici_adi.Text = "Kullanıcı Adı:";
            // 
            // lbl_parola
            // 
            lbl_parola.AutoSize = true;
            lbl_parola.Location = new Point(78, 73);
            lbl_parola.Name = "lbl_parola";
            lbl_parola.Size = new Size(43, 15);
            lbl_parola.TabIndex = 0;
            lbl_parola.Text = "Parola:";
            // 
            // txt_kullanici_adi
            // 
            txt_kullanici_adi.Location = new Point(127, 43);
            txt_kullanici_adi.Name = "txt_kullanici_adi";
            txt_kullanici_adi.Size = new Size(176, 23);
            txt_kullanici_adi.TabIndex = 0;
            // 
            // txt_parola
            // 
            txt_parola.Location = new Point(127, 70);
            txt_parola.Name = "txt_parola";
            txt_parola.PasswordChar = '*';
            txt_parola.Size = new Size(176, 23);
            txt_parola.TabIndex = 1;
            // 
            // btn_vacgec
            // 
            btn_vacgec.Location = new Point(188, 125);
            btn_vacgec.Name = "btn_vacgec";
            btn_vacgec.Size = new Size(94, 41);
            btn_vacgec.TabIndex = 3;
            btn_vacgec.Text = "Vazgeç";
            btn_vacgec.UseVisualStyleBackColor = true;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(288, 125);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(94, 41);
            btn_giris.TabIndex = 2;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // form_giris
            // 
            AcceptButton = btn_giris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_vacgec;
            ClientSize = new Size(394, 178);
            Controls.Add(btn_giris);
            Controls.Add(btn_vacgec);
            Controls.Add(txt_parola);
            Controls.Add(txt_kullanici_adi);
            Controls.Add(lbl_parola);
            Controls.Add(lbl_kullanici_adi);
            Name = "form_giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teknik Serrvis Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_kullanici_adi;
        private Label lbl_parola;
        private TextBox txt_kullanici_adi;
        private TextBox txt_parola;
        private Button btn_vacgec;
        private Button btn_giris;
    }
}
