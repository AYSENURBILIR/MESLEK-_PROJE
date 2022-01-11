using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Otomasyonu
{
    public partial class frmSiparis : Form
    {
        private char _islem;
        private bool _ekranTemizle;
        private int _ilkSayi;
        public frmSiparis()
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
      
   




        private void frmSiparis_Load(object sender, EventArgs e)
        {
            /*    lblMasaNo.Text = cGeneral._ButtonValue;
                 cMasalar ms = new cMasalar();
                 int tableId = ms.TableGetbyNumber(cGeneral._ButtonName);

                 if (ms.TableGetbyState(tableId,2)==true||ms.TableGetbyState(tableId,4)==true)
                 {
                    cAdisyon Ad = new cAdisyon();
                    int AdditionId = Ad.getByAddition(tableId);
                    cSiparis orders = new cSiparis();
                     orders.getByOrder(lvSiparisler, AdditionId);

                 }
               */

            /* btn1.Click += new EventHandler(islem);
             btn2.Click += new EventHandler(islem);
             btn3.Click += new EventHandler(islem);
             btn4.Click += new EventHandler(islem);
             btn5.Click += new EventHandler(islem);
             btn6.Click += new EventHandler(islem);
             btn7.Click += new EventHandler(islem);
             btn8.Click += new EventHandler(islem);
             btn9.Click += new EventHandler(islem);
             btn0.Click += new EventHandler(islem);
          */
        }
        cUrunCesitleri Uc = new cUrunCesitleri();

        private void btnYemekler_Click(object sender, EventArgs e)
        {
            
            Uc.getbyProductTypes(lvMenu, btnYemekler);
        }
        //Hesap Makinesi
        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle) 
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                lblEkran.Text = "";
                _ekranTemizle = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle) lblEkran.Text = "";
            if (lblEkran.Text == "0") lblEkran.Text = "";//Ekrandaki 0'ı siler.
            lblEkran.Text += "0";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizle = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(lblEkran.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilkSayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            lblEkran.Text = Convert.ToString(sonuc);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizle = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);

        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizle = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizle = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";
        }
    }
}
