


using System.Data.SqlClient;

namespace AycicegiPansiyon
{
    partial class FrmYeniMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Kaydet = new GroupBox();
            CinsiyetBox = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtUcret = new TextBox();
            kaydetButton = new Button();
            TxtCıkıstarih = new DateTimePicker();
            TxtGiristarih = new DateTimePicker();
            TxtTelno = new MaskedTextBox();
            TxtOdaNo = new TextBox();
            TxtTC = new TextBox();
            TxtMail = new TextBox();
            TxtSoyadi = new TextBox();
            TxtAdi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Txt109 = new Button();
            Txt108 = new Button();
            Txt107 = new Button();
            Txt106 = new Button();
            Txt104 = new Button();
            Txt103 = new Button();
            Txt102 = new Button();
            Txt105 = new Button();
            Txt101 = new Button();
            DoluOda = new Button();
            BosOda = new Button();
            label11 = new Label();
            Kaydet.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Kaydet
            // 
            Kaydet.Controls.Add(CinsiyetBox);
            Kaydet.Controls.Add(label10);
            Kaydet.Controls.Add(label9);
            Kaydet.Controls.Add(txtUcret);
            Kaydet.Controls.Add(kaydetButton);
            Kaydet.Controls.Add(TxtCıkıstarih);
            Kaydet.Controls.Add(TxtGiristarih);
            Kaydet.Controls.Add(TxtTelno);
            Kaydet.Controls.Add(TxtOdaNo);
            Kaydet.Controls.Add(TxtTC);
            Kaydet.Controls.Add(TxtMail);
            Kaydet.Controls.Add(TxtSoyadi);
            Kaydet.Controls.Add(TxtAdi);
            Kaydet.Controls.Add(label8);
            Kaydet.Controls.Add(label7);
            Kaydet.Controls.Add(label6);
            Kaydet.Controls.Add(label5);
            Kaydet.Controls.Add(label4);
            Kaydet.Controls.Add(label3);
            Kaydet.Controls.Add(label2);
            Kaydet.Controls.Add(label1);
            Kaydet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Kaydet.Location = new Point(31, 31);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(482, 514);
            Kaydet.TabIndex = 0;
            Kaydet.TabStop = false;
            Kaydet.Text = "Müşteri Bilgileri";
            // 
            // CinsiyetBox
            // 
            CinsiyetBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            CinsiyetBox.FormattingEnabled = true;
            CinsiyetBox.Items.AddRange(new object[] { "Bay", "Bayan" });
            CinsiyetBox.Location = new Point(220, 107);
            CinsiyetBox.Name = "CinsiyetBox";
            CinsiyetBox.Size = new Size(250, 33);
            CinsiyetBox.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(107, 107);
            label10.Name = "label10";
            label10.Size = new Size(83, 28);
            label10.TabIndex = 38;
            label10.Text = "Cinsiyet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(122, 312);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 36;
            label9.Text = "Ücret:";
            label9.Click += label9_Click;
            // 
            // txtUcret
            // 
            txtUcret.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtUcret.Location = new Point(220, 309);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(250, 34);
            txtUcret.TabIndex = 35;
            // 
            // kaydetButton
            // 
            kaydetButton.BackColor = Color.FromArgb(255, 255, 192);
            kaydetButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kaydetButton.Location = new Point(220, 445);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(151, 54);
            kaydetButton.TabIndex = 34;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = false;
            kaydetButton.Click += button1_Click;
            // 
            // TxtCıkıstarih
            // 
            TxtCıkıstarih.Location = new Point(220, 400);
            TxtCıkıstarih.Name = "TxtCıkıstarih";
            TxtCıkıstarih.Size = new Size(250, 30);
            TxtCıkıstarih.TabIndex = 33;
            TxtCıkıstarih.ValueChanged += TxtCıkıstarih_ValueChanged;
            // 
            // TxtGiristarih
            // 
            TxtGiristarih.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtGiristarih.Location = new Point(220, 353);
            TxtGiristarih.Name = "TxtGiristarih";
            TxtGiristarih.Size = new Size(250, 30);
            TxtGiristarih.TabIndex = 32;
            // 
            // TxtTelno
            // 
            TxtTelno.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtTelno.Location = new Point(220, 144);
            TxtTelno.Mask = "(999) 000-0000";
            TxtTelno.Name = "TxtTelno";
            TxtTelno.Size = new Size(250, 31);
            TxtTelno.TabIndex = 31;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtOdaNo.Location = new Point(220, 269);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(250, 34);
            TxtOdaNo.TabIndex = 30;
            // 
            // TxtTC
            // 
            TxtTC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtTC.Location = new Point(220, 222);
            TxtTC.MaxLength = 11;
            TxtTC.Name = "TxtTC";
            TxtTC.Size = new Size(250, 34);
            TxtTC.TabIndex = 29;
            // 
            // TxtMail
            // 
            TxtMail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TxtMail.Location = new Point(220, 184);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(250, 32);
            TxtMail.TabIndex = 28;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TxtSoyadi.Location = new Point(220, 69);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(250, 32);
            TxtSoyadi.TabIndex = 27;
            // 
            // TxtAdi
            // 
            TxtAdi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TxtAdi.Location = new Point(220, 29);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(250, 32);
            TxtAdi.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(76, 388);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 25;
            label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(76, 355);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 24;
            label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(43, 272);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 23;
            label6.Text = "Oda Numarası:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(48, 222);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 22;
            label5.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(136, 184);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 21;
            label4.Text = "Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(107, 144);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 20;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(114, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 19;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(144, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 18;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Txt109);
            groupBox2.Controls.Add(Txt108);
            groupBox2.Controls.Add(Txt107);
            groupBox2.Controls.Add(Txt106);
            groupBox2.Controls.Add(Txt104);
            groupBox2.Controls.Add(Txt103);
            groupBox2.Controls.Add(Txt102);
            groupBox2.Controls.Add(Txt105);
            groupBox2.Controls.Add(Txt101);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(519, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 449);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Txt109
            // 
            Txt109.BackColor = Color.SpringGreen;
            Txt109.Location = new Point(310, 254);
            Txt109.Name = "Txt109";
            Txt109.Size = new Size(80, 59);
            Txt109.TabIndex = 7;
            Txt109.Text = "109";
            Txt109.UseVisualStyleBackColor = false;
            Txt109.Click += Txt109_Click;
            // 
            // Txt108
            // 
            Txt108.BackColor = Color.SpringGreen;
            Txt108.Location = new Point(168, 254);
            Txt108.Name = "Txt108";
            Txt108.Size = new Size(80, 59);
            Txt108.TabIndex = 6;
            Txt108.Text = "108";
            Txt108.UseVisualStyleBackColor = false;
            Txt108.Click += Txt108_Click;
            // 
            // Txt107
            // 
            Txt107.BackColor = Color.SpringGreen;
            Txt107.Location = new Point(28, 254);
            Txt107.Name = "Txt107";
            Txt107.Size = new Size(80, 59);
            Txt107.TabIndex = 5;
            Txt107.Text = "107";
            Txt107.UseVisualStyleBackColor = false;
            Txt107.Click += Txt107_Click;
            // 
            // Txt106
            // 
            Txt106.BackColor = Color.SpringGreen;
            Txt106.Location = new Point(310, 151);
            Txt106.Name = "Txt106";
            Txt106.Size = new Size(80, 59);
            Txt106.TabIndex = 4;
            Txt106.Text = "106";
            Txt106.UseVisualStyleBackColor = false;
            Txt106.Click += Txt106_Click;
            // 
            // Txt104
            // 
            Txt104.BackColor = Color.SpringGreen;
            Txt104.Location = new Point(28, 151);
            Txt104.Name = "Txt104";
            Txt104.Size = new Size(80, 59);
            Txt104.TabIndex = 3;
            Txt104.Text = "104";
            Txt104.UseVisualStyleBackColor = false;
            Txt104.Click += Txt104_Click;
            // 
            // Txt103
            // 
            Txt103.BackColor = Color.SpringGreen;
            Txt103.Location = new Point(310, 50);
            Txt103.Name = "Txt103";
            Txt103.Size = new Size(80, 59);
            Txt103.TabIndex = 2;
            Txt103.Text = "103";
            Txt103.UseVisualStyleBackColor = false;
            Txt103.Click += Txt103_Click;
            // 
            // Txt102
            // 
            Txt102.BackColor = Color.SpringGreen;
            Txt102.Location = new Point(168, 50);
            Txt102.Name = "Txt102";
            Txt102.Size = new Size(80, 59);
            Txt102.TabIndex = 1;
            Txt102.Text = "102";
            Txt102.UseVisualStyleBackColor = false;
            Txt102.Click += Txt102_Click;
            // 
            // Txt105
            // 
            Txt105.BackColor = Color.SpringGreen;
            Txt105.Location = new Point(168, 151);
            Txt105.Name = "Txt105";
            Txt105.Size = new Size(80, 59);
            Txt105.TabIndex = 1;
            Txt105.Text = "105";
            Txt105.UseVisualStyleBackColor = false;
            Txt105.Click += Txt105_Click;
            // 
            // Txt101
            // 
            Txt101.BackColor = Color.SpringGreen;
            Txt101.Location = new Point(28, 50);
            Txt101.Name = "Txt101";
            Txt101.Size = new Size(80, 59);
            Txt101.TabIndex = 0;
            Txt101.Text = "101";
            Txt101.UseVisualStyleBackColor = false;
            Txt101.Click += Txt101_Click;
            // 
            // DoluOda
            // 
            DoluOda.BackColor = Color.Red;
            DoluOda.Location = new Point(838, 486);
            DoluOda.Name = "DoluOda";
            DoluOda.Size = new Size(80, 59);
            DoluOda.TabIndex = 8;
            DoluOda.Text = "Dolu";
            DoluOda.UseVisualStyleBackColor = false;
            DoluOda.Click += DoluOda_Click;
            // 
            // BosOda
            // 
            BosOda.BackColor = Color.SpringGreen;
            BosOda.Location = new Point(727, 486);
            BosOda.Name = "BosOda";
            BosOda.Size = new Size(80, 59);
            BosOda.TabIndex = 9;
            BosOda.Text = "Boş";
            BosOda.UseVisualStyleBackColor = false;
            BosOda.Click += BosOda_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(560, 502);
            label11.Name = "label11";
            label11.Size = new Size(23, 28);
            label11.TabIndex = 19;
            label11.Text = "0";
            // 
            // FrmYeniMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(947, 596);
            Controls.Add(label11);
            Controls.Add(BosOda);
            Controls.Add(groupBox2);
            Controls.Add(DoluOda);
            Controls.Add(Kaydet);
            Name = "FrmYeniMusteri";
            Text = "Yeni Müşteri Ekle";
            Load += FrmYeniMusteri_Load;
            Kaydet.ResumeLayout(false);
            Kaydet.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        public void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Txt101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString(); // Buradaki hata giderildi.
            }
            baglanti.Close();
            if (Txt101.Text != "101")
            {
                Txt101.BackColor = Color.Red;
                Txt101.Enabled = false;
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
                Txt102.Enabled = false;
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
                Txt103.Enabled = false;
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
                Txt104.Enabled = false;
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
                Txt105.Enabled = false;
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
                Txt106.Enabled = false;
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
                Txt107.Enabled = false;
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
                Txt108.Enabled = false;
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
                Txt109.Enabled = false;
            }
        }
        


        #endregion

        private GroupBox Kaydet;
        private Button kaydetButton;
        private DateTimePicker TxtCıkıstarih;
        private DateTimePicker TxtGiristarih;
        private MaskedTextBox TxtTelno;
        private TextBox TxtOdaNo;
        private TextBox TxtTC;
        private TextBox TxtMail;
        private TextBox TxtSoyadi;
        private TextBox TxtAdi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button Txt101;
        private Button Txt109;
        private Button Txt108;
        private Button Txt107;
        private Button Txt106;
        private Button Txt104;
        private Button Txt103;
        private Button Txt102;
        private Button Txt105;
        private Button DoluOda;
        private Button BosOda;
        private TextBox txtUcret;
        private Label label9;
        private Label label10;
        private ComboBox CinsiyetBox;
        private Label label11;
    }
}