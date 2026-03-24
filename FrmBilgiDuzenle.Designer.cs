namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            BtnBilgiGuncelle = new Button();
            CmbCinsiyet = new ComboBox();
            label6 = new Label();
            MskTel = new MaskedTextBox();
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.AccessibleRole = AccessibleRole.ScrollBar;
            BtnBilgiGuncelle.BackColor = Color.Thistle;
            BtnBilgiGuncelle.Location = new Point(167, 343);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(185, 41);
            BtnBilgiGuncelle.TabIndex = 30;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            BtnBilgiGuncelle.Click += BtnBilgiGuncelle_Click;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek\t", "Kadın" });
            CmbCinsiyet.Location = new Point(167, 290);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(185, 31);
            CmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 290);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 28;
            label6.Text = "Cinsiyet:";
            // 
            // MskTel
            // 
            MskTel.Location = new Point(167, 203);
            MskTel.Mask = "(999) 000-0000";
            MskTel.Name = "MskTel";
            MskTel.Size = new Size(185, 31);
            MskTel.TabIndex = 4;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(167, 125);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(185, 31);
            TxtSoyad.TabIndex = 2;
            TxtSoyad.TextChanged += TxtSoyad_TextChanged;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(167, 82);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(185, 31);
            TxtAd.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 209);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 24;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 128);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 23;
            label4.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 90);
            label1.Name = "label1";
            label1.Size = new Size(37, 23);
            label1.TabIndex = 22;
            label1.Text = "Ad:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(167, 166);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(185, 31);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(167, 245);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(185, 31);
            TxtSifre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 248);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 19;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 169);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 18;
            label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(488, 499);
            Controls.Add(BtnBilgiGuncelle);
            Controls.Add(CmbCinsiyet);
            Controls.Add(label6);
            Controls.Add(MskTel);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(MskTC);
            Controls.Add(TxtSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Corbel", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmBilgiDuzenle";
            Text = "Bilgi Güncelleme";
            Load += FrmBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBilgiGuncelle;
        private ComboBox CmbCinsiyet;
        private Label label6;
        private MaskedTextBox MskTel;
        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label label5;
        private Label label4;
        private Label label1;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private Label label3;
        private Label label2;
    }
}