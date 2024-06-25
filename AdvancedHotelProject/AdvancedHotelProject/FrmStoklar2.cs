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
    public partial class FrmStoklar2 : Form
    {
        public FrmStoklar2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RE759FF\\SQLEXPRESS;Initial Catalog=OtelRezervasyonu;Integrated Security=SSPI;");
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values('"+txtGidalar.Text+"','"+txtİcecekler.Text+"','"+txtAtistirmaliklar.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void txtGidalar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtİcecekler_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAtistirmaliklar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmStoklar2_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
