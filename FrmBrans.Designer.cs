namespace Proje_Hastane
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnEkle = new Button();
            dataGridView1 = new DataGridView();
            TxtBrans = new TextBox();
            TxtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.Yellow;
            BtnGuncelle.Location = new Point(97, 171);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(168, 32);
            BtnGuncelle.TabIndex = 27;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Crimson;
            BtnSil.Location = new Point(183, 133);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(82, 32);
            BtnSil.TabIndex = 26;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.Lime;
            BtnEkle.Location = new Point(97, 133);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(80, 32);
            BtnEkle.TabIndex = 25;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 165);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TxtBrans
            // 
            TxtBrans.Location = new Point(97, 75);
            TxtBrans.Name = "TxtBrans";
            TxtBrans.Size = new Size(168, 31);
            TxtBrans.TabIndex = 17;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(97, 38);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(168, 31);
            TxtID.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 78);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 15;
            label2.Text = "Branş Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 14;
            label1.Text = "Branş ID:";
            // 
            // FrmBrans
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(636, 240);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtBrans);
            Controls.Add(TxtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "FrmBrans";
            Text = "Branş Paneli";
            Load += FrmBrans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnEkle;
        private DataGridView dataGridView1;
        private TextBox TxtBrans;
        private TextBox TxtID;
        private Label label2;
        private Label label1;
    }
}