namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            LnkUyeOl = new LinkLabel();
            BtnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 43);
            label1.Name = "label1";
            label1.Size = new Size(430, 61);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 166);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 211);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(335, 208);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(185, 31);
            TxtSifre.TabIndex = 3;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(335, 163);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(185, 31);
            MskTC.TabIndex = 4;
            MskTC.ValidatingType = typeof(int);
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(242, 306);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(244, 23);
            LnkUyeOl.TabIndex = 5;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Hesabınız Yok mu? Üye Olun";
            LnkUyeOl.LinkClicked += LnkUyeOl_LinkClicked;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(208, 257);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(312, 37);
            BtnGirisYap.TabIndex = 6;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // FrmHastaGiris
            // 
            AcceptButton = BtnGirisYap;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(749, 426);
            Controls.Add(BtnGirisYap);
            Controls.Add(LnkUyeOl);
            Controls.Add(MskTC);
            Controls.Add(TxtSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaGiris";
            Text = "Hasta Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private LinkLabel LnkUyeOl;
        private Button BtnGirisYap;
    }
}