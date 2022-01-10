using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Restoran_Otomasyonu
{
    class cUrunCesitleri
    {
        cGeneral gnl = new cGeneral();
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;

        #region Properties
        public int UrunTurNo
        {
            get => _UrunTurNo;
            set => _UrunTurNo = value;
        }
        public string KategoriAd
        {
            get => _KategoriAd;
            set => _KategoriAd = value;
        }
        public string Aciklama
        {
            get => _Aciklama;
            set => _Aciklama = value;
        }
        #endregion
        public void getbyProductTypes(ListView Cesitler, Button btn)
        {
            
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            //SqlCommand comm = new SqlCommand("SELECT URUNAD, FIYAT,urunler.ID FROM urunler INNER JOIN kategoriler ON urunler.ID = kategoriler.ID", conn);
            //SqlCommand comm = new SqlCommand("Select URUNAD, FIYAT, urunler.ID from kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID Where urunler.KATEGORIID = @KATEGORIID", conn);
           SqlCommand comm = new SqlCommand("Select * from urunler ", conn);
            /*Bize ürünün adı fiyatı ve ıd'si lazım.
             Kategoriler tablosu ile Ürünler tablosunu birleştir.
            Kategorilerdeki Id ve Ürünlerdeki Kategori Id */
            string aa = btn.Name;
            int uzunluk = aa.Length;

            //comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);//Uzunluğunu buluyoruz.
            if (conn.State == ConnectionState.Closed)
            {
                
                conn.Open();

            }
            SqlDataReader dr = comm.ExecuteReader();//Bağlantı bilgilerini okuyor.
            int i = 0;
            while (dr.Read())
            {
               
                Cesitler.Items.Add(dr["URUNAD"].ToString());
                 Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                 Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                  
                i++;

            }

            dr.Close();
            conn.Dispose();
            conn.Close();
        }
    }
}
