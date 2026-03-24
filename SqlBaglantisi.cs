using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Proje_Hastane
{
    class SqlBaglantisi
    {
        //baglanti metodumuz
        public SqlConnection baglanti()
        {
            //baglan nesnemiz
            SqlConnection baglan = new SqlConnection("Data Source=YOUR_PC; Initial Catalog=HastaneProje; Integrated Security=True; TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
