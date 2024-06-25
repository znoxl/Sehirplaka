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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RE759FF\\SQLEXPRESS;Initial Catalog=OtelRezervasyonu;Integrated Security=SSPI;");


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblPersonelMaas.Text = (personel * 1500).ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            

            //Kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();
            //Gıda giderleri

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanUrunler1.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();

            //İçecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanUrunler2.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();

            //Çerezler

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlinanUrunler1.Text = oku4["toplam3"].ToString();

            }
            baglanti.Close();

           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
