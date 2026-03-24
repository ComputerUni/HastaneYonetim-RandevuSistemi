namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            RchSikayet = new RichTextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            BtnCikis = new Button();
            BtnDuyurular = new Button();
            BtnGuncelle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(153, 96);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(82, 23);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 96);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 2;
            label3.Text = "Ad-Soyad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(153, 57);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 23);
            LblTC.TabIndex = 1;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 57);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Location = new Point(3, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detayı";
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(9, 30);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(337, 150);
            RchSikayet.TabIndex = 0;
            RchSikayet.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(371, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(499, 524);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 494);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnCikis);
            groupBox4.Controls.Add(BtnDuyurular);
            groupBox4.Controls.Add(BtnGuncelle);
            groupBox4.Location = new Point(3, 392);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(362, 141);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // BtnCikis
            // 
            BtnCikis.Location = new Point(6, 81);
            BtnCikis.Name = "BtnCikis";
            BtnCikis.Size = new Size(350, 37);
            BtnCikis.TabIndex = 2;
            BtnCikis.Text = "Çıkış";
            BtnCikis.UseVisualStyleBackColor = true;
            BtnCikis.Click += BtnCikis_Click;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Location = new Point(182, 37);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(174, 37);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            BtnDuyurular.Click += BtnDuyurular_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(6, 37);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(174, 37);
            BtnGuncelle.TabIndex = 0;
            BtnGuncelle.Text = "Bilgi Düzenle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(884, 539);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MinimizeBox = false;
            Name = "FrmDoktorDetay";
            Text = "Doktor Detay";
            Load += FrmDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTC;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox RchSikayet;
        private GroupBox groupBox4;
        private Button BtnDuyurular;
        private Button BtnGuncelle;
        private Button BtnCikis;
    }
}