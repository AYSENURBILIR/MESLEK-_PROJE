using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Otomasyonu
{
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Çıkış yapar.
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa1.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa2.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa3.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa4.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa5.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa6.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa7.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa8.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa9.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();// frmSipariş nesnesi oluşturduk.
            int uzunluk = btnMasa10.Text.Length;//Bastığımız butonun textini aldık. Uzunluğunu hesaplattık.
            cGeneral._ButtonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);//İlk değer başlama. İkinci değer başlangıçtan kaç sonra karakter alması gerektiği
            cGeneral._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }
        cGeneral gnl = new cGeneral();
        private void frmMasalar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select DURUM,ID from Masalar",con);
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();//Eğer veritabanı kapalıysa bağlantıyı aç
            }
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "1")
                        {
                            //Gelen masa ve durumu 1 ise
                            //Gelen masa 2 durum 1 ise olarak düşünülebilinir.


                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2")
                        {
                            cMasalar ms = new cMasalar();
                            DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2)).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;
                            //item.Text = string.Format("{0}{1}}{2}",
                            //    fark.Days > 0 ? string.Format("{0} Gün", fark.Days "",
                            //    fark.Hours > 0 ? string.Format("{0} Gün", fark.Hours "",
                            //    fark.Minutes>0? string.Format("{0} Dakika",fark.Minutes):"").Trim()+""
                        }

                    }
                }
            }
            
        }
    }
}
