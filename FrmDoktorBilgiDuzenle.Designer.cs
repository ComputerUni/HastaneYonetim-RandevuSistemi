namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            TxtSoyad = new TextBox();
            TxtAd = new TextBox();
            label4 = new Label();
            label1 = new Label();
            MskTC = new MaskedTextBox();
            label2 = new Label();
            TxtSifre = new TextBox();
            label3 = new Label();
            label5 = new Label();
            CmbBrans = new ComboBox();
            BtnBilgiGuncelle = new Button();
            SuspendLayout();
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(135, 87);
            TxtSoyad.Margin = new Padding(5);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(208, 31);
            TxtSoyad.TabIndex = 32;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(135, 44);
            TxtAd.Margin = new Padding(5);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(208, 31);
            TxtAd.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 90);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 30;
            label4.Text = "Soyad:";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 29;
            label1.Text = "Ad:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(135, 127);
            MskTC.Margin = new Padding(5);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(208, 31);
            MskTC.TabIndex = 28;
            MskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 130);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 27;
            label2.Text = "TC Kimlik No:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(135, 210);
            TxtSifre.Margin = new Padding(5);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(208, 31);
            TxtSifre.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 215);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 33;
            label3.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 170);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 35;
            label5.Text = "Branş:";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(135, 167);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(208, 31);
            CmbBrans.TabIndex = 36;
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.BackColor = Color.Thistle;
            BtnBilgiGuncelle.Location = new Point(135, 255);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(208, 41);
            BtnBilgiGuncelle.TabIndex = 37;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            BtnBilgiGuncelle.Click += BtnBilgiGuncelle_Click;
            // 
            // FrmDoktorBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(384, 351);
            Controls.Add(BtnBilgiGuncelle);
            Controls.Add(CmbBrans);
            Controls.Add(label5);
            Controls.Add(TxtSifre);
            Controls.Add(label3);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(MskTC);
            Controls.Add(label2);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorBilgiDuzenle";
            Text = "Doktor Bilgi Güncelle";
            Load += FrmDoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSoyad;
        private TextBox TxtAd;
        private Label label4;
        private Label label1;
        private MaskedTextBox MskTC;
        private Label label2;
        private TextBox TxtSifre;
        private Label label3;
        private Label label5;
        private ComboBox CmbBrans;
        private Button BtnBilgiGuncelle;
    }
}