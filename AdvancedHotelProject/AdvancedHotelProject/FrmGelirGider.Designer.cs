namespace AycicegiPansiyon
{
    partial class FrmGelirGider
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
            lblKasaToplam = new Label();
            label3 = new Label();
            lblPersonelMaas = new Label();
            lblAlinanUrunler1 = new Label();
            label6 = new Label();
            lblFaturalar = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblAlinanUrunler2 = new Label();
            lblAlinanUrunler3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(60, 56);
            label1.Name = "label1";
            label1.Size = new Size(206, 24);
            label1.TabIndex = 0;
            label1.Text = "Kasadaki Toplam Tutar:";
            // 
            // lblKasaToplam
            // 
            lblKasaToplam.AutoSize = true;
            lblKasaToplam.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKasaToplam.Location = new Point(292, 56);
            lblKasaToplam.Name = "lblKasaToplam";
            lblKasaToplam.Size = new Size(30, 24);
            lblKasaToplam.TabIndex = 1;
            lblKasaToplam.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(100, 96);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 2;
            label3.Text = "Personel Maaşları:";
            // 
            // lblPersonelMaas
            // 
            lblPersonelMaas.AutoSize = true;
            lblPersonelMaas.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonelMaas.Location = new Point(292, 96);
            lblPersonelMaas.Name = "lblPersonelMaas";
            lblPersonelMaas.Size = new Size(30, 24);
            lblPersonelMaas.TabIndex = 3;
            lblPersonelMaas.Text = "00";
            // 
            // lblAlinanUrunler1
            // 
            lblAlinanUrunler1.AutoSize = true;
            lblAlinanUrunler1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlinanUrunler1.Location = new Point(292, 132);
            lblAlinanUrunler1.Name = "lblAlinanUrunler1";
            lblAlinanUrunler1.Size = new Size(30, 24);
            lblAlinanUrunler1.TabIndex = 5;
            lblAlinanUrunler1.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(57, 132);
            label6.Name = "label6";
            label6.Size = new Size(209, 24);
            label6.TabIndex = 4;
            label6.Text = "Alınan Ürünlerin Tutarı:";
            label6.Click += label6_Click;
            // 
            // lblFaturalar
            // 
            lblFaturalar.AutoSize = true;
            lblFaturalar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFaturalar.Location = new Point(292, 169);
            lblFaturalar.Name = "lblFaturalar";
            lblFaturalar.Size = new Size(30, 24);
            lblFaturalar.TabIndex = 7;
            lblFaturalar.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(175, 169);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 6;
            label8.Text = "Faturalar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(620, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(458, 56);
            label10.Name = "label10";
            label10.Size = new Size(140, 24);
            label10.TabIndex = 9;
            label10.Text = "Personel Sayısı:";
            label10.Click += label10_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(540, 169);
            button1.Name = "button1";
            button1.Size = new Size(181, 62);
            button1.TabIndex = 10;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(200, 260);
            label9.Name = "label9";
            label9.Size = new Size(66, 24);
            label9.TabIndex = 11;
            label9.Text = "Sonuç:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(292, 260);
            label11.Name = "label11";
            label11.Size = new Size(30, 24);
            label11.TabIndex = 12;
            label11.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(60, 229);
            label12.Name = "label12";
            label12.Size = new Size(802, 24);
            label12.TabIndex = 13;
            label12.Text = "------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // lblAlinanUrunler2
            // 
            lblAlinanUrunler2.AutoSize = true;
            lblAlinanUrunler2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlinanUrunler2.Location = new Point(344, 132);
            lblAlinanUrunler2.Name = "lblAlinanUrunler2";
            lblAlinanUrunler2.Size = new Size(30, 24);
            lblAlinanUrunler2.TabIndex = 14;
            lblAlinanUrunler2.Text = "00";
            // 
            // lblAlinanUrunler3
            // 
            lblAlinanUrunler3.AutoSize = true;
            lblAlinanUrunler3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAlinanUrunler3.Location = new Point(395, 132);
            lblAlinanUrunler3.Name = "lblAlinanUrunler3";
            lblAlinanUrunler3.Size = new Size(30, 24);
            lblAlinanUrunler3.TabIndex = 15;
            lblAlinanUrunler3.Text = "00";
            lblAlinanUrunler3.Click += label4_Click;
            // 
            // FrmGelirGider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(873, 533);
            Controls.Add(lblAlinanUrunler3);
            Controls.Add(lblAlinanUrunler2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(lblFaturalar);
            Controls.Add(label8);
            Controls.Add(lblAlinanUrunler1);
            Controls.Add(label6);
            Controls.Add(lblPersonelMaas);
            Controls.Add(label3);
            Controls.Add(lblKasaToplam);
            Controls.Add(label1);
            Name = "FrmGelirGider";
            Text = "FrmGelirGider";
            Load += FrmGelirGider_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKasaToplam;
        private Label label3;
        private Label lblPersonelMaas;
        private Label lblAlinanUrunler1;
        private Label label6;
        private Label lblFaturalar;
        private Label label8;
        private TextBox textBox1;
        private Label label10;
        private Button button1;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label lblAlinanUrunler2;
        private Label lblAlinanUrunler3;
    }
}