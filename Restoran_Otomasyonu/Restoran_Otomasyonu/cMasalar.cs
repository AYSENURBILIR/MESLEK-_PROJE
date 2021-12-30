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
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaId from Adisyon Right Join Masalar on Adisyon.MasalarId where Masalar.DURUM=@durum and Adisyon.Durum=0", con);
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

    }
}
