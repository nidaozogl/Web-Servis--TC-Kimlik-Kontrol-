using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCKontrolWebServisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Long veri tipindeki değişkene,txt_TC textboxuna yazılan değerleri parse metodu ile atadım.
            long kimlikNo = long.Parse(txt_TC.Text);
            //int veri tipindeki değşkene, txt_DogumTarihi textboxunda yazılan değeri parse metodu ile atadım.
            int yil = int.Parse(txt_DogumTarihi.Text);
            bool durum;


            //Burada try-catch kullanılmasının sebebi; kullanıcı ne kadar yanlış veri girerse girsin ne kadar çok hata durumu olursa olsun. Sınırsız giriş hakkı tanımak için kullandık.
            try
            {

                //Bu işlem tamamen türetmedir:TCDdoğrulamaWebServisi'nden yeni bir nesne türetiyoruz.)
                using (TCDoğrulamaWebServisi.KPSPublicSoapClient servis = new TCDoğrulamaWebServisi.KPSPublicSoapClient { }) 
                {
                    durum = servis.TCKimlikNoDogrula(kimlikNo, txt_Ad.Text, txt_Soyad.Text, yil);
                }
            }
            catch (Exception)
            {

                throw;
            }

            if (durum == true)
            {
                MessageBox.Show("Kayıt işlemini başarıyla gerçekleştirdiniz.");
            }
            else
            {
                MessageBox.Show("Kayıt işleminiz başarısız.");
            }
        }


    }
}
