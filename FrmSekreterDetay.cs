using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public string TCnumara;

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;

            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("SELECT SekreterAdSoyad FROM Tbl_Sekreter WHERE SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGrid'e aktarmak
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktor Bilgilerini DataGrid'e aktarmak
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans FROM Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;

            //Branşı ComboBox'a aktarma
            SqlCommand komutAktar = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komutAktar.ExecuteReader();
            while (dr3.Read())
            {
                CmdBrans.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {

            SqlCommand komutKaydet = new SqlCommand("INSERT INTO Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) VALUES (@r1, @r2, @r3, @r4)", bgl.baglanti());

            komutKaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", CmdBrans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);

            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void CmdBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komutGetir = new SqlCommand("SELECT DoktorAd, DoktorSoyad FROM Tbl_Doktorlar WHERE DoktorBrans = @p1", bgl.baglanti());
            komutGetir.Parameters.AddWithValue("@p1", CmdBrans.Text);
            SqlDataReader dr3 = komutGetir.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();

        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet2 = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) VALUES (@p1)", bgl.baglanti());
            komutKaydet2.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komutKaydet2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans = new FrmBrans();
            frmBrans.Show();

        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmRandevu = new FrmRandevuListesi();
            frmRandevu.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyuru = new FrmDuyurular();
            frmDuyuru.Show();
        }
    }
}
