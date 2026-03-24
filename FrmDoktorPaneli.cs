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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //Branşları ComboBox'a Aktarmak
            SqlCommand komutAktar = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komutAktar.ExecuteReader();
            while (dr3.Read())
            {
                CmbBrans.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("INSERT INTO Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) VALUES (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@d1", TxtAd.Text);
            komutEkle.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komutEkle.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komutEkle.Parameters.AddWithValue("@d4", MskTC.Text);
            komutEkle.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("DELETE FROM Tbl_Doktorlar WHERE DoktorTC=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", MskTC.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbBrans.Text = "";
            MskTC.Text = "";
            TxtSifre.Text = "";
            TxtSifre.Focus();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutYeni = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3, DoktorTC=@d4, DoktorSifre=@d5 WHERE DoktorTC=@d4", bgl.baglanti());
            komutYeni.Parameters.AddWithValue("@d1", TxtAd.Text);
            komutYeni.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komutYeni.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komutYeni.Parameters.AddWithValue("@d4", MskTC.Text);
            komutYeni.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komutYeni.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
