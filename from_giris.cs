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

            if(kullaniciAdi=="samet" && parola == "1234")
            {
                MessageBox.Show("Giriş Başarılı");
                form_baslangic form_baslangic = new form_baslangic();
                this.Close();
                form_baslangic.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı");
                this.Close();
                
            }

        }
    }
}
