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
    public partial class frmGiris : Form
    {
        //private object cb_kullanici;
        //private object txt_sifre;
        
        public frmGiris()
        {
            InitializeComponent();
            
           
        }
        
        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cbKullanici);

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            cGeneral gnl = new cGeneral();
            cPersoneller p = new cPersoneller();//Nesne oluşturdum
            bool result = p.personelEntryControl(txtSifre.Text, cGeneral._personelId);
            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGeneral._personelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);//Veritabanına ekler. Fonksiyona gider

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
        }
       

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Çıkış yapar.
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGeneral._personelId = p.PersonelId;
            cGeneral._gorevId = p.PersonelGorevId;
            /*Kullanııc adı ve şifreyi yazınca diğer forma geçiş yapıyor.*/

        }

       
    }
}
