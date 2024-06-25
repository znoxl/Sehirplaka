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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RE759FF\\SQLEXPRESS;Initial Catalog=OtelRezervasyonu;Integrated Security=SSPI;");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(TxtOdaNo.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CinsiyetBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtTelno.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            TxtGiristarih.Text = listView1.SelectedItems[0].SubItems[9].Text;
            TxtCıkıstarih.Text = listView1.SelectedItems[0].SubItems[10].Text;

            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE MusteriEkle SET Adi = @Adi, Soyadi = @Soyadi, Cinsiyet = @Cinsiyet, Telefon = @Telefon, Mail = @Mail, TC = @TC, OdaNo = @OdaNo, Ucret = @Ucret, GirisTarihi = @GirisTarihi, CıkısTarihi = @CıkısTarihi WHERE Musteriid = @id", baglanti);
            komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CinsiyetBox.Text);
            komut.Parameters.AddWithValue("@Telefon", TxtTelno.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@TC", TxtTC.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", TxtGiristarih.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@CıkısTarihi", TxtCıkıstarih.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CinsiyetBox.Text = "";
            TxtTelno.Text = "";
            TxtMail.Clear();
            TxtTC.Clear();
            TxtOdaNo.Clear();
            txtUcret.Clear();
            TxtGiristarih.Text = "";
            TxtCıkıstarih.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
// SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);

