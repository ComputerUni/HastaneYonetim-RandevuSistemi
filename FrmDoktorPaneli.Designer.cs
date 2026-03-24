namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            label1 = new Label();
            label2 = new Label();
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            label3 = new Label();
            CmbBrans = new ComboBox();
            MskTC = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            TxtSifre = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEkle = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 68);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(93, 31);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(168, 31);
            TxtAd.TabIndex = 2;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(93, 68);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(168, 31);
            TxtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 108);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 4;
            label3.Text = "Branş:";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(93, 108);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(168, 31);
            CmbBrans.TabIndex = 5;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(93, 148);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(168, 31);
            MskTC.TabIndex = 6;
            MskTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 151);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 7;
            label4.Text = "TC No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 191);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 8;
            label5.Text = "Sifre:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(93, 188);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(168, 31);
            TxtSifre.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(934, 264);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.Lime;
            BtnEkle.Location = new Point(93, 225);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(80, 32);
            BtnEkle.TabIndex = 11;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Crimson;
            BtnSil.Location = new Point(179, 225);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(82, 32);
            BtnSil.TabIndex = 12;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.Yellow;
            BtnGuncelle.Location = new Point(93, 263);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(168, 32);
            BtnGuncelle.TabIndex = 13;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1235, 318);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtSifre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(MskTC);
            Controls.Add(CmbBrans);
            Controls.Add(label3);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorPaneli";
            Text = "Doktor Paneli";
            Load += FrmDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private Label label3;
        private ComboBox CmbBrans;
        private MaskedTextBox MskTC;
        private Label label4;
        private Label label5;
        private TextBox TxtSifre;
        private DataGridView dataGridView1;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnGuncelle;
    }
}