using Teknik_Servis_Yönetim.Data;
using MySql.Data.MySqlClient;
using Teknik_Servis_Yönetim.Models;
namespace Teknik_Servis_Yönetim
{
    public partial class form_giris : Form
    {
        public form_giris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txt_kullanici_adi.Text;
            var parola = txt_parola.Text;

            using (var baglanti= Database.GetConnection())
            {
                baglanti.Open();
                string sql = "SELECT * FROM calisanlar WHERE kullanici_adi=@kullaniciAdi AND sifre=@sifre";
                var komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", parola);

                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Kullanıcı bulundu, giriş başarılı
                    Calisan kullanici = new Calisan();
                    kullanici.Fill(reader);
                    Oturum.GirisYap(kullanici);

                    MessageBox.Show(Oturum.AktifKullnici?.KarsilamaMesaji, Oturum.AktifKullnici?.Yetki);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Kullanıcı bulunamadı, giriş başarısız
                    MessageBox.Show("Kullanıcı adı veya parola hatalı");
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void btn_vacgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
