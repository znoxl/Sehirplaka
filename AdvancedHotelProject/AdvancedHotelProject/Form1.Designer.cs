namespace AycicegiPansiyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            TxtKullaniciadi = new TextBox();
            TxtSifre = new TextBox();
            txtGiris = new Button();
            label3 = new Label();
            images = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)images).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(130, 203);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(197, 255);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            label2.Click += label2_Click;
            // 
            // TxtKullaniciadi
            // 
            TxtKullaniciadi.BackColor = Color.FromArgb(192, 255, 192);
            TxtKullaniciadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtKullaniciadi.Location = new Point(301, 203);
            TxtKullaniciadi.Name = "TxtKullaniciadi";
            TxtKullaniciadi.Size = new Size(237, 34);
            TxtKullaniciadi.TabIndex = 2;
            TxtKullaniciadi.TextChanged += textBox1_TextChanged;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = Color.FromArgb(192, 255, 192);
            TxtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtSifre.Location = new Point(301, 255);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(237, 34);
            TxtSifre.TabIndex = 4;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // txtGiris
            // 
            txtGiris.BackColor = Color.White;
            txtGiris.Font = new Font("Segoe UI", 12F);
            txtGiris.Location = new Point(335, 330);
            txtGiris.Name = "txtGiris";
            txtGiris.Size = new Size(152, 40);
            txtGiris.TabIndex = 5;
            txtGiris.Text = "Giriş";
            txtGiris.UseVisualStyleBackColor = false;
            txtGiris.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 255);
            label3.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(130, 96);
            label3.Name = "label3";
            label3.Size = new Size(432, 29);
            label3.TabIndex = 7;
            label3.Text = "Otel Rezervasyonu Sistemimize Hoşgeldiiz";
            // 
            // images
            // 
            images.Image = (Image)resources.GetObject("images.Image");
            images.Location = new Point(713, 112);
            images.Name = "images";
            images.Size = new Size(232, 227);
            images.TabIndex = 6;
            images.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1060, 644);
            Controls.Add(label3);
            Controls.Add(images);
            Controls.Add(txtGiris);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciadi);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 9F);
            Name = "Form1";
            Text = "Admin Giriş";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)images).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtKullaniciadi;
        private TextBox TxtSifre;
        private Button txtGiris;
        private Label label3;
        private PictureBox images;
    }
}
