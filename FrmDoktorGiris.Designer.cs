namespace Proje_Hastane
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            BtnGirisYap = new Button();
            LnkUyeOl = new LinkLabel();
            MskTC = new MaskedTextBox();
            TxtSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(139, 319);
            BtnGirisYap.Margin = new Padding(5);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(459, 49);
            BtnGirisYap.TabIndex = 13;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(438, 535);
            LnkUyeOl.Margin = new Padding(5, 0, 5, 0);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(244, 23);
            LnkUyeOl.TabIndex = 12;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Hesabınız Yok mu? Üye Olun";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(310, 202);
            MskTC.Margin = new Padding(5);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(288, 31);
            MskTC.TabIndex = 11;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(310, 259);
            TxtSifre.Margin = new Padding(5);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(288, 31);
            TxtSifre.TabIndex = 10;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 259);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 9;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 210);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 8;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 105);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(445, 61);
            label1.TabIndex = 7;
            label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(757, 502);
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
            Name = "FrmDoktorGiris";
            Text = "FrmDoktorGiris";
            Load += FrmDoktorGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGirisYap;
        private LinkLabel LnkUyeOl;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}