namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxtID = new TextBox();
            label2 = new Label();
            LnkBilgiDuzenle = new LinkLabel();
            BtnRandevu = new Button();
            label7 = new Label();
            CmbDoktor = new ComboBox();
            RichTextSikayet = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            CmbBrans = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(121, 77);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(76, 23);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 77);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(121, 44);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 23);
            LblTC.TabIndex = 1;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(LnkBilgiDuzenle);
            groupBox2.Controls.Add(BtnRandevu);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(RichTextSikayet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Location = new Point(12, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 368);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(113, 36);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(178, 31);
            TxtID.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 8;
            label2.Text = "RandevuID:";
            // 
            // LnkBilgiDuzenle
            // 
            LnkBilgiDuzenle.AutoSize = true;
            LnkBilgiDuzenle.Location = new Point(121, 331);
            LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            LnkBilgiDuzenle.Size = new Size(147, 23);
            LnkBilgiDuzenle.TabIndex = 7;
            LnkBilgiDuzenle.TabStop = true;
            LnkBilgiDuzenle.Text = "Bilgilerini Düzenle";
            LnkBilgiDuzenle.LinkClicked += LnkBilgiDuzenle_LinkClicked;
            // 
            // BtnRandevu
            // 
            BtnRandevu.Location = new Point(114, 282);
            BtnRandevu.Name = "BtnRandevu";
            BtnRandevu.Size = new Size(178, 37);
            BtnRandevu.TabIndex = 5;
            BtnRandevu.Text = "Randevu Al";
            BtnRandevu.UseVisualStyleBackColor = true;
            BtnRandevu.Click += BtnRandevu_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 149);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 6;
            label7.Text = "Şikayet:";
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(113, 110);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(178, 31);
            CmbDoktor.TabIndex = 5;
            CmbDoktor.SelectedIndexChanged += CmbDoktor_SelectedIndexChanged;
            // 
            // RichTextSikayet
            // 
            RichTextSikayet.Location = new Point(114, 147);
            RichTextSikayet.Name = "RichTextSikayet";
            RichTextSikayet.Size = new Size(177, 129);
            RichTextSikayet.TabIndex = 4;
            RichTextSikayet.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 113);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 4;
            label6.Text = "Doktor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 76);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 3;
            label5.Text = "Branş:";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(113, 73);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(178, 31);
            CmbBrans.TabIndex = 2;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(323, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(619, 272);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 242);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(323, 290);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(622, 249);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(616, 219);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(957, 560);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmHastaDetay";
            Text = "HastaDetay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTC;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox CmbDoktor;
        private RichTextBox RichTextSikayet;
        private Label label6;
        private Label label5;
        private ComboBox CmbBrans;
        private Button BtnRandevu;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel LnkBilgiDuzenle;
        private Label label2;
        private TextBox TxtID;
    }
}