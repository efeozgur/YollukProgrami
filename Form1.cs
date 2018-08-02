using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace YollukProgrami
{
    public partial class AnaForm : MetroForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private Hesaplamalar hesap; 
        private void AnaForm_Load(object sender, System.EventArgs e)
        {
          
           
            try
            {
               
               listele();
               


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + " hata hata hata ");
                
            }
        }

        private void btnHesapla_Click(object sender, System.EventArgs e)
        {
            try
            {
                hesap = new Hesaplamalar(chkKendi.Checked, Int32.Parse(gosterge.Text), Int32.Parse(txKacKm.Text), Double.Parse(txTasicUcreti.Text), 1);

                richTextBox1.Text = "Kilometre :" +txKacKm.Text+ "\nYevmiye : " + hesap.Yevmiye() + "\n" + "Yol Mesafe Ücreti : " + hesap.YolMesafeUcreti()
                                    + "\n" + "Süre : " + hesap.SureHesap() + "\n" +
                                    "Toplam : " + hesap.total();
               
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Alanları Kontrol Edin!!!");
                
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Veritabani vt = new  Veritabani();
            vt.ekle(hesap);

            DataTable dataSet = vt.Listele();
            dataGridView1.DataSource = dataSet;

        }

        private void txKacKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }

            
        }

        private void txTasicUcreti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    

        private void listele()
        {
            dataGridView1.DataSource = vt.Listele();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            vt.DeleteAll();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Yazdirfrm yz = new Yazdirfrm();
            yz.ShowDialog();
        }

        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            vt.DeleteAll();
            txKacKm.Text = "";
            txTasicUcreti.Text = "";
            richTextBox1.Text = "";
            gosterge.Text = "";
            listele();
        }
    }
}
