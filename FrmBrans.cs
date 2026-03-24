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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("INSERT INTO Tbl_Branslar (BransAd) VALUES (@b1)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@b1", TxtBrans.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBrans.Text = "";
            TxtID.Text = "";
            TxtBrans.Focus();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("DELETE FROM Tbl_Branslar WHERE BransID=@b1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@b1", TxtID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBrans.Text = "";
            TxtID.Text = "";
            TxtBrans.Focus();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutYeni = new SqlCommand("UPDATE Tbl_Branslar SET BransAd=@b1 WHERE BransID=@b2", bgl.baglanti());
            komutYeni.Parameters.AddWithValue("@b1", TxtBrans.Text);
            komutYeni.Parameters.AddWithValue("@b2", TxtID.Text);
            komutYeni.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBrans.Text = "";
            TxtID.Text = "";
            TxtBrans.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }
    }
}
