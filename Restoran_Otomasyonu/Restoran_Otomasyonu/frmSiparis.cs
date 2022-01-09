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
        //Hesap İşlemi
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Yazdığımız sayıların ekranda gözükmesi
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı giriniz:");
                    break;

            }
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

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
           
        }

        private void btnAnaYemek1_Click(object sender, EventArgs e)
        {
            cUrunCesitleri Uc = new cUrunCesitleri();
            Uc.getbyProductTypes(lvMenu, btnAnaYemek1);

            //17.video 6.dkde kaldım
        }
    }
}
