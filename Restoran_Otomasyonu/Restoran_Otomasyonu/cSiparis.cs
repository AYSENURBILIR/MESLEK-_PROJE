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
    class cSiparis
    {
        cGeneral gnl = new cGeneral();
        #region Fields
        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion

        #region Properties
        public int Id
        {
            get => _Id;
            set => _Id = value;
        }
        public int AdisyonID
        {
            get => _adisyonID;
            set => _adisyonID = value;
        }
        public int UrunId
        {
            get => _urunId;
            set => _urunId = value;
        }
        public int Adet
        {
            get => _adet;
            set => _adet = value;
        }
        public int MasaId
        {
            get => _masaId;
            set => _masaId = value;
        } 
        #endregion

        public void getByOrder(ListView lv,int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD, FIYAT,Satislar.ID,URUNID,satisler, ADET from satisler Inner join urunler on Satisler.URUNID=Urunler.ID" +
                "Where ADISYONID= @AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();

                }
                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;

                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }


        }
    }
}
