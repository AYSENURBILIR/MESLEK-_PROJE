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
    class cMasalar
    {
        #region Fields

        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        #endregion

        #region Properties
        public int ID
        {
            get => _ID;
            set => _ID = value;
        }
        public int KAPASITE
        {
            get => _KAPASITE;
            set => _KAPASITE = value;
        }
        public int SERVISTURU
        {
            get => _SERVISTURU;
            set => _SERVISTURU = value;
        }
        public int DURUM
        {
            get => _DURUM;
            set => _DURUM = value;
        }
        #endregion
        cGeneral gnl = new cGeneral();
        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaId from adisyon Right Join Masalar on adisyon.MasalarId where Masalar.DURUM=@durum and Adisyon.Durum=0", con);
            //Masalardaki MasaId ve Adisyondaki MasaId arasında ilişki kurdum
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value=state;
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();

                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();//Tarihi string değere çevirdim
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
            return dt;
        }
        /* public int TableGetbyNumber(string TableValue)//String veri tipinde değer gönderdik
         {
             string aa = TableValue;
             int lenght = aa.Length;//a'nın uzunluğunu bulduk ve lenght diye bir değişkene attık
             return Convert.ToInt32(aa.Substring(lenght = -1, 1));//int'e çevirdik. Çünkü döndüreceğimiz değerin tipi int
                                                                  //Substrig ile de  uzunluktan 1 eksik al ve 1. karakteri al.
         }
         */
        public bool TableGetbyState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select durum from masalar where Id=@TableId and DURUM=@state", con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;

        }
    }
}
