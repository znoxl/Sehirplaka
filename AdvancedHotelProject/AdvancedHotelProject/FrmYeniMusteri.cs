using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AycicegiPansiyon
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RE759FF\\SQLEXPRESS;Initial Catalog=OtelRezervasyonu;Integrated Security=True;TrustServerCertificate=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Txt101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda101 (Adi,Soyadi) values('"+TxtAdi.Text+"','"+TxtSoyadi.Text+"')",baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda102 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda103 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda104 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda105 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda106 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda107 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda108 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txt109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Oda109 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu odaları gösterir");
        }

        private void BosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş odaları gösterir");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCıkıstarih_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(TxtGiristarih.Text);
            DateTime BuyukTarih = Convert.ToDateTime(TxtCıkıstarih.Text);
            TimeSpan Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "INSERT INTO MusteriEkle(Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CıkısTarihi) " +
                "VALUES(@Adi, @Soyadi, @Cinsiyet, @Telefon, @Mail, @TC, @OdaNo, @Ucret, @GirisTarihi, @CıkısTarihi)", baglanti);

            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CinsiyetBox.Text);
            komut.Parameters.AddWithValue("@Telefon", TxtTelno.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@TC", TxtTC.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", Convert.ToDateTime(TxtGiristarih.Text));
            komut.Parameters.AddWithValue("@CıkısTarihi", Convert.ToDateTime(TxtCıkıstarih.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı");
        }




    }
}
