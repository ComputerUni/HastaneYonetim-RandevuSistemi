namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            LblTC = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnDuyuruOlustur = new Button();
            RchDuyuru = new RichTextBox();
            groupBox3 = new GroupBox();
            BtnKaydet = new Button();
            ChkDurum = new CheckBox();
            MskTC = new MaskedTextBox();
            CmbDoktor = new ComboBox();
            CmdBrans = new ComboBox();
            MskSaat = new MaskedTextBox();
            MskTarih = new MaskedTextBox();
            TxtID = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            groupBox6 = new GroupBox();
            dataGridView4 = new DataGridView();
            groupBox7 = new GroupBox();
            BtnRandevuListe = new Button();
            BtnBransPanel = new Button();
            BtnDoktorPanel = new Button();
            BtnDuyurular = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(133, 92);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(82, 23);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(133, 55);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 23);
            LblTC.TabIndex = 2;
            LblTC.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 92);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDuyuruOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Location = new Point(12, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 255);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.Location = new Point(11, 190);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(271, 44);
            BtnDuyuruOlustur.TabIndex = 1;
            BtnDuyuruOlustur.Text = "Oluştur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            BtnDuyuruOlustur.Click += BtnDuyuruOlustur_Click;
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(11, 35);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(271, 149);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(CmbDoktor);
            groupBox3.Controls.Add(CmdBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(TxtID);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(322, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(336, 429);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(23, 353);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(262, 44);
            BtnKaydet.TabIndex = 14;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click_1;
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(103, 281);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(85, 27);
            ChkDurum.TabIndex = 13;
            ChkDurum.Text = "Durum";
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(103, 232);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(182, 31);
            MskTC.TabIndex = 12;
            MskTC.ValidatingType = typeof(int);
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(103, 194);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(182, 31);
            CmbDoktor.TabIndex = 11;
            // 
            // CmdBrans
            // 
            CmdBrans.FormattingEnabled = true;
            CmdBrans.Location = new Point(103, 157);
            CmdBrans.Name = "CmdBrans";
            CmdBrans.Size = new Size(182, 31);
            CmdBrans.TabIndex = 10;
            CmdBrans.SelectedIndexChanged += CmdBrans_SelectedIndexChanged;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(104, 120);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(181, 31);
            MskSaat.TabIndex = 9;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(104, 81);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(181, 31);
            MskTarih.TabIndex = 8;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // TxtID
            // 
            TxtID.Location = new Point(104, 43);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(181, 31);
            TxtID.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 235);
            label10.Name = "label10";
            label10.Size = new Size(38, 23);
            label10.TabIndex = 5;
            label10.Text = "TC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 197);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 4;
            label9.Text = "Doktor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 159);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 3;
            label8.Text = "Branş:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 123);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 2;
            label7.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 83);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 1;
            label6.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 46);
            label5.Name = "label5";
            label5.Size = new Size(34, 23);
            label5.TabIndex = 0;
            label5.Text = "ID:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(664, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(502, 226);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(0, 235);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(502, 236);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(496, 206);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(496, 196);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView4);
            groupBox6.Location = new Point(664, 241);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(502, 315);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Doktorlar";
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 27);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(496, 285);
            dataGridView4.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(BtnDuyurular);
            groupBox7.Controls.Add(BtnRandevuListe);
            groupBox7.Controls.Add(BtnBransPanel);
            groupBox7.Controls.Add(BtnDoktorPanel);
            groupBox7.Location = new Point(12, 447);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(646, 109);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Hızlı Erişim";
            // 
            // BtnRandevuListe
            // 
            BtnRandevuListe.Location = new Point(324, 39);
            BtnRandevuListe.Name = "BtnRandevuListe";
            BtnRandevuListe.Size = new Size(153, 44);
            BtnRandevuListe.TabIndex = 17;
            BtnRandevuListe.Text = "Randevu Liste";
            BtnRandevuListe.UseVisualStyleBackColor = true;
            BtnRandevuListe.Click += BtnRandevuListe_Click;
            // 
            // BtnBransPanel
            // 
            BtnBransPanel.Location = new Point(165, 39);
            BtnBransPanel.Name = "BtnBransPanel";
            BtnBransPanel.Size = new Size(153, 44);
            BtnBransPanel.TabIndex = 16;
            BtnBransPanel.Text = "Branş Paneli";
            BtnBransPanel.UseVisualStyleBackColor = true;
            BtnBransPanel.Click += BtnBransPanel_Click;
            // 
            // BtnDoktorPanel
            // 
            BtnDoktorPanel.Location = new Point(6, 39);
            BtnDoktorPanel.Name = "BtnDoktorPanel";
            BtnDoktorPanel.Size = new Size(153, 44);
            BtnDoktorPanel.TabIndex = 15;
            BtnDoktorPanel.Text = "Doktor Paneli";
            BtnDoktorPanel.UseVisualStyleBackColor = true;
            BtnDoktorPanel.Click += BtnDoktorPanel_Click;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Location = new Point(483, 39);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(153, 44);
            BtnDuyurular.TabIndex = 18;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            BtnDuyurular.Click += BtnDuyurular_Click;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1178, 562);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            Text = "Sekreter Detay";
            Load += FrmSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label LblTC;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnDuyuruOlustur;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox MskSaat;
        private MaskedTextBox MskTarih;
        private TextBox TxtID;
        private Button BtnKaydet;
        private CheckBox ChkDurum;
        private MaskedTextBox MskTC;
        private ComboBox CmbDoktor;
        private ComboBox CmdBrans;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private DataGridView dataGridView4;
        private GroupBox groupBox7;
        private Button BtnRandevuListe;
        private Button BtnBransPanel;
        private Button BtnDoktorPanel;
        private Button BtnDuyurular;
    }
}