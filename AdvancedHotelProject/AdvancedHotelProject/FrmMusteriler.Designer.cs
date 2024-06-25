namespace AycicegiPansiyon
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            button1 = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnAra = new Button();
            CinsiyetBox = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtUcret = new TextBox();
            TxtTelno = new MaskedTextBox();
            TxtOdaNo = new TextBox();
            TxtTC = new TextBox();
            TxtMail = new TextBox();
            TxtSoyadi = new TextBox();
            TxtAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtCıkıstarih = new DateTimePicker();
            TxtGiristarih = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            BtnTemizle = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listView1.Location = new Point(12, 350);
            listView1.Name = "listView1";
            listView1.Size = new Size(960, 148);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adi";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadi";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "TelNo";
            columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "OdaNo";
            columnHeader8.Width = 72;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "G.Tarihi";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Ç.Tarihi";
            columnHeader11.Width = 100;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(816, 15);
            button1.Name = "button1";
            button1.Size = new Size(156, 49);
            button1.TabIndex = 1;
            button1.Text = "Verileri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGuncelle.Location = new Point(816, 70);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(156, 46);
            BtnGuncelle.TabIndex = 2;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += button2_Click;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSil.Location = new Point(816, 128);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(156, 38);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += button3_Click;
            // 
            // BtnAra
            // 
            BtnAra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnAra.Location = new Point(816, 249);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(156, 38);
            BtnAra.TabIndex = 4;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // CinsiyetBox
            // 
            CinsiyetBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            CinsiyetBox.FormattingEnabled = true;
            CinsiyetBox.Items.AddRange(new object[] { "Bay", "Bayan" });
            CinsiyetBox.Location = new Point(175, 96);
            CinsiyetBox.Name = "CinsiyetBox";
            CinsiyetBox.Size = new Size(250, 33);
            CinsiyetBox.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(62, 96);
            label10.Name = "label10";
            label10.Size = new Size(83, 28);
            label10.TabIndex = 54;
            label10.Text = "Cinsiyet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(488, 22);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 53;
            label9.Text = "Ücret:";
            // 
            // txtUcret
            // 
            txtUcret.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtUcret.Location = new Point(571, 18);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(219, 34);
            txtUcret.TabIndex = 52;
            // 
            // TxtTelno
            // 
            TxtTelno.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtTelno.Location = new Point(175, 133);
            TxtTelno.Mask = "(999) 000-0000";
            TxtTelno.Name = "TxtTelno";
            TxtTelno.Size = new Size(250, 31);
            TxtTelno.TabIndex = 51;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtOdaNo.Location = new Point(175, 258);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(250, 34);
            TxtOdaNo.TabIndex = 50;
            // 
            // TxtTC
            // 
            TxtTC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtTC.Location = new Point(175, 211);
            TxtTC.MaxLength = 11;
            TxtTC.Name = "TxtTC";
            TxtTC.Size = new Size(250, 34);
            TxtTC.TabIndex = 49;
            // 
            // TxtMail
            // 
            TxtMail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TxtMail.Location = new Point(175, 173);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(250, 32);
            TxtMail.TabIndex = 48;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TxtSoyadi.Location = new Point(175, 58);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(250, 32);
            TxtSoyadi.TabIndex = 47;
            // 
            // TxtAdi
            // 
            TxtAdi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            TxtAdi.Location = new Point(175, 18);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(250, 32);
            TxtAdi.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(-2, 261);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 45;
            label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 211);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 44;
            label5.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(91, 173);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 43;
            label4.Text = "Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(62, 133);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 42;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(69, 58);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 41;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(99, 18);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 40;
            label1.Text = "Adı:";
            // 
            // TxtCıkıstarih
            // 
            TxtCıkıstarih.Location = new Point(571, 102);
            TxtCıkıstarih.Name = "TxtCıkıstarih";
            TxtCıkıstarih.Size = new Size(219, 27);
            TxtCıkıstarih.TabIndex = 59;
            // 
            // TxtGiristarih
            // 
            TxtGiristarih.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtGiristarih.Location = new Point(571, 62);
            TxtGiristarih.Name = "TxtGiristarih";
            TxtGiristarih.Size = new Size(219, 27);
            TxtGiristarih.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(440, 97);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 57;
            label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(442, 60);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 56;
            label7.Text = "Giriş Tarihi:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(734, 293);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 34);
            textBox1.TabIndex = 60;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(658, 296);
            label11.Name = "label11";
            label11.Size = new Size(55, 28);
            label11.TabIndex = 61;
            label11.Text = "İsim:";
            // 
            // BtnTemizle
            // 
            BtnTemizle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnTemizle.Location = new Point(816, 177);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(156, 39);
            BtnTemizle.TabIndex = 62;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(984, 510);
            Controls.Add(BtnTemizle);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(TxtCıkıstarih);
            Controls.Add(TxtGiristarih);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CinsiyetBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtUcret);
            Controls.Add(TxtTelno);
            Controls.Add(TxtOdaNo);
            Controls.Add(TxtTC);
            Controls.Add(TxtMail);
            Controls.Add(TxtSoyadi);
            Controls.Add(TxtAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAra);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "FrmMusteriler";
            Text = "Müşteri Bilgileri";
            Load += FrmMusteriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button button1;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnAra;
        private ComboBox CinsiyetBox;
        private Label label10;
        private Label label9;
        private TextBox txtUcret;
        private MaskedTextBox TxtTelno;
        private TextBox TxtOdaNo;
        private TextBox TxtTC;
        private TextBox TxtMail;
        private TextBox TxtSoyadi;
        private TextBox TxtAdi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker TxtCıkıstarih;
        private DateTimePicker TxtGiristarih;
        private Label label8;
        private Label label7;
        private TextBox textBox1;
        private Label label11;
        private Button BtnTemizle;
    }
}