namespace AycicegiPansiyon
{
    partial class FrmStoklar2
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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtGidalar = new TextBox();
            txtİcecekler = new TextBox();
            txtAtistirmaliklar = new TextBox();
            btnKaydet = new Button();
            listView1 = new ListView();
            Gıdalar = new ColumnHeader();
            İçecekler = new ColumnHeader();
            Atıştırmalıklar = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(61, 48);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 2;
            label1.Text = "Gıda Tutarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(49, 99);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 4;
            label3.Text = "İçecek Tutarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(36, 146);
            label5.Name = "label5";
            label5.Size = new Size(134, 24);
            label5.TabIndex = 6;
            label5.Text = "Atıştırmalıklar:";
            // 
            // txtGidalar
            // 
            txtGidalar.Location = new Point(190, 48);
            txtGidalar.Name = "txtGidalar";
            txtGidalar.Size = new Size(208, 27);
            txtGidalar.TabIndex = 8;
            txtGidalar.TextChanged += txtGidalar_TextChanged;
            // 
            // txtİcecekler
            // 
            txtİcecekler.Location = new Point(190, 99);
            txtİcecekler.Name = "txtİcecekler";
            txtİcecekler.Size = new Size(208, 27);
            txtİcecekler.TabIndex = 9;
            txtİcecekler.TextChanged += txtİcecekler_TextChanged;
            // 
            // txtAtistirmaliklar
            // 
            txtAtistirmaliklar.Location = new Point(190, 146);
            txtAtistirmaliklar.Name = "txtAtistirmaliklar";
            txtAtistirmaliklar.Size = new Size(208, 27);
            txtAtistirmaliklar.TabIndex = 10;
            txtAtistirmaliklar.TextChanged += txtAtistirmaliklar_TextChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnKaydet.Location = new Point(199, 195);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(181, 41);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Gıdalar, İçecekler, Atıştırmalıklar });
            listView1.Location = new Point(3, 312);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 139);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Gıdalar
            // 
            Gıdalar.Text = "Gıdalar";
            Gıdalar.Width = 80;
            // 
            // İçecekler
            // 
            İçecekler.Text = "İçecekler";
            İçecekler.Width = 80;
            // 
            // Atıştırmalıklar
            // 
            Atıştırmalıklar.Text = "Atıştırmalıklar";
            Atıştırmalıklar.Width = 120;
            // 
            // FrmStoklar2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(706, 450);
            Controls.Add(listView1);
            Controls.Add(btnKaydet);
            Controls.Add(txtAtistirmaliklar);
            Controls.Add(txtİcecekler);
            Controls.Add(txtGidalar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmStoklar2";
            Text = "FrmStoklar2";
            Load += FrmStoklar2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox txtGidalar;
        private TextBox txtİcecekler;
        private TextBox txtAtistirmaliklar;
        private Button btnKaydet;
        private ListView listView1;
        private ColumnHeader Gıdalar;
        private ColumnHeader İçecekler;
        private ColumnHeader Atıştırmalıklar;
    }
}