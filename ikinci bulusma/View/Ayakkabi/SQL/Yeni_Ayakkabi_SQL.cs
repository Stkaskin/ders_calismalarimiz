using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoe_project.View.Ayakkabi.SQL
{
    public partial class Yeni_Ayakkabi_SQL : Form
    {
        int gorev = 0;
        ayakkabi ayakkabi = new ayakkabi();
        public Yeni_Ayakkabi_SQL()
        {
            InitializeComponent();
        }

        private void Yeni_Ayakkabi_Load(object sender, EventArgs e)
        {

        }
        public void ekle_gelen()
        {
            gorev = 1;
        }
        public void sil_gelen(ayakkabi ayakkabi_gelen)
        {
            //
            // var a = Application.OpenForms[Ayakkabi_Anaform.ActiveForm.Name];
            // var a = (Ayakkabi_Anaform)Application.OpenForms["Ayakkabi_Anaform"];//açık forma erişim
            // var a =new Ayakkabi_Anaform(); //İstediğimiz gibi çalışmaz default şeklinde veriler gelir
            //--- yada parametreli erişim  ayakkabi_gelen
            this.ayakkabi = ayakkabi_gelen;
            id_t.Enabled = false;
            fiyat_t.Enabled = false;
            ad_t.Enabled = false;
            num_t.Enabled = false;
            button1.Text = "SİL";
            gorev =2;
            doldur();

        }
        public void duzenle_gelen(ayakkabi ayakkabi_gelen)
        {
            this.ayakkabi = ayakkabi_gelen;
            id_t.Enabled = false;
            button1.Text = "DÜZENLE";
            gorev = 3;
            
            doldur();
            

        }
        private void doldur()
        {
           
            ad_t.Text = this.ayakkabi.adi;
            id_t.Text = this.ayakkabi.ID.ToString();
            num_t.Text = this.ayakkabi.numara.ToString();
            fiyat_t.Text = this.ayakkabi.Fiyat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //application.openforms.count
         /*   int count_form = Application.OpenForms.Count;
            MessageBox.Show("Açık olan form sayısı : "+count_form);*/
            //açık olan formlar içinde gezer
            Ayakkabi_Anaform_SQL anaform = (Ayakkabi_Anaform_SQL)Application.OpenForms["Ayakkabi_Anaform_SQL"];
            if (gorev==1)
            {
                ayakkabi.ID = Convert.ToInt32(id_t.Text);
                ayakkabi.adi = ad_t.Text;
                ayakkabi.numara = Convert.ToInt32(num_t.Text);
                ayakkabi.Fiyat = Convert.ToInt32(fiyat_t.Text);
              //  anaform.yeni_ayakkabi(ayakkabi);
            }
            if (gorev==2)
            {
             //   anaform.sil_ayakkabi(ayakkabi);
            }
            if (gorev==3)
            {
                ayakkabi.adi = ad_t.Text;
                ayakkabi.numara = Convert.ToInt32(num_t.Text);
                ayakkabi.Fiyat = Convert.ToInt32(fiyat_t.Text);
        
              //  anaform.duzenle_ayakkabi(ayakkabi);
            }
            this.Close();
                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yeni_Ayakkabi_SQL ayakkabi = new Yeni_Ayakkabi_SQL();
            ayakkabi.Show();
            ayakkabi.Hide();

        }
    }
}
