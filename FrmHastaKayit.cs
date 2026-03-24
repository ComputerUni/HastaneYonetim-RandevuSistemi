using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("INSERT INTO Tbl_Hastalar(HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", TxtAd.Text);
            ekle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", MskTC.Text);
            ekle.Parameters.AddWithValue("@p4", MskTel.Text);
            ekle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            ekle.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hasta Kaydı Başarıyla Yapıldı Şifreniz: " + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
