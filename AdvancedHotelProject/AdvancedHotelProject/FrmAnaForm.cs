using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AycicegiPansiyon
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RE759FF\\SQLEXPRESS;Initial Catalog=OtelRezervasyonu;Integrated Security=SSPI;");


        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrmAdmingiris_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void FrmYenimusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr1 = new FrmYeniMusteri();
            fr1.Show();
            this.Hide();
        }

        private void FrmOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr2 = new FrmOdalar();
            fr2.Show();
            this.Hide();
        }

        private void FrmMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr3 = new FrmMusteriler();
            fr3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otel Rezervasyonu Sistemi kayıt uygulaması / 2016 ERZURUM");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmStoklar2 frm = new FrmStoklar2();
            frm.Show();
           
        }
    }
}
