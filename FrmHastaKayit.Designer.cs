namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            MskTel = new MaskedTextBox();
            label6 = new Label();
            CmbCinsiyet = new ComboBox();
            BtnKayit = new Button();
            SuspendLayout();
            // 
            // MskTC
            // 
            MskTC.Location = new Point(235, 158);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(185, 31);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(235, 237);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(185, 31);
            TxtSifre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 240);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 6;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 161);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 5;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 82);
            label1.Name = "label1";
            label1.Size = new Size(37, 23);
            label1.TabIndex = 9;
            label1.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 120);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 10;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 201);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 11;
            label5.Text = "Telefon:";
            label5.Click += label5_Click;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(235, 74);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(185, 31);
            TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(235, 117);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(185, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // MskTel
            // 
            MskTel.Location = new Point(235, 195);
            MskTel.Mask = "(999) 000-0000";
            MskTel.Name = "MskTel";
            MskTel.Size = new Size(185, 31);
            MskTel.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 282);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 15;
            label6.Text = "Cinsiyet:";
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek\t", "Kadın" });
            CmbCinsiyet.Location = new Point(235, 282);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(185, 31);
            CmbCinsiyet.TabIndex = 6;
            CmbCinsiyet.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BtnKayit
            // 
            BtnKayit.BackColor = Color.Thistle;
            BtnKayit.Location = new Point(235, 335);
            BtnKayit.Name = "BtnKayit";
            BtnKayit.Size = new Size(185, 41);
            BtnKayit.TabIndex = 17;
            BtnKayit.Text = "Kayıt Yap";
            BtnKayit.UseVisualStyleBackColor = false;
            BtnKayit.Click += BtnKayit_Click;
            // 
            // FrmHastaKayit
            // 
            AcceptButton = BtnKayit;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(645, 482);
            Controls.Add(BtnKayit);
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
            Name = "FrmHastaKayit";
            Text = "Hasta Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private MaskedTextBox MskTel;
        private Label label6;
        private ComboBox CmbCinsiyet;
        private Button BtnKayit;
    }
}