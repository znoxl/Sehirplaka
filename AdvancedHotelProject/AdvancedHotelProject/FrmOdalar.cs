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
    public partial class FrmOdalar : Form
    {

        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RE759FF\\SQLEXPRESS;Initial Catalog=OtelRezervasyonu;Integrated Security=True;TrustServerCertificate=True");

        private void Txt106_Click(object sender, EventArgs e)
        {

        }

        private void Txt106_Click_1(object sender, EventArgs e)
        {

        }

        private void Txt106_Click_2(object sender, EventArgs e)
        {

        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Txt101.Text = oku1["Adi"].ToString() +" "+ oku1["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if(Txt101.Text!="101")
            {
                Txt101.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Txt102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt102.Text != "102")
            {
                Txt102.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Txt103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt103.Text != "103")
            {
                Txt103.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Txt104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt104.Text != "104")
            {
                Txt104.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                Txt105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt105.Text != "105")
            {
                Txt105.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Txt106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt106.Text != "106")
            {
                Txt106.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                Txt107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt107.Text != "107")
            {
                Txt107.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                Txt108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt108.Text != "108")
            {
                Txt108.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                Txt109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt109.Text != "109")
            {
                Txt109.BackColor = Color.Red;
            }
        }

    }
}
