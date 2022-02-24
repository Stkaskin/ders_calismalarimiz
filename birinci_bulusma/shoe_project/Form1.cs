using shoe_project.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoe_project
{
    public partial class Form1 : Form
    {
        //Global değişkenlerimiz
        List<ayakkabi> ayakkabilar = new List<ayakkabi>();
        int satir_numarasi = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            ayakkabi ayakkabi = new ayakkabi();
            ayakkabi.adi = ad_t.Text;
            ayakkabi.ID = Convert.ToInt32(id_t.Text);
            ayakkabi.numara = Convert.ToInt32(num_t.Text);
            ayakkabi.Fiyat = Convert.ToInt32(fiyat_t.Text);

            ayakkabilar.Add(ayakkabi);
            //ref sıfırlanacak sonra source ayarlanacak
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabilar;



        }

        private void getir_b_Click(object sender, EventArgs e)
        {
            //class cekmek icin
            ayakkabi ayakkabi_cekilen = (ayakkabi)dataGridView1.CurrentRow.DataBoundItem;
            ad_t.Text = ayakkabi_cekilen.adi;
            id_t.Text = ayakkabi_cekilen.ID.ToString();
            num_t.Text = ayakkabi_cekilen.numara.ToString();
            fiyat_t.Text = ayakkabi_cekilen.Fiyat.ToString();
          
            //sectiğimiz satırdaki veriyi  ad veya index'e gore
            string veri_tek = dataGridView1.CurrentRow.Cells["adi"].Value.ToString();
            //satir numarası ve sutun numara veya adına gore
            string veri_numara = dataGridView1.Rows[0].Cells["adi"].Value.ToString();
          //  id_t.Text = veri_numara;
              


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ayakkabi ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad1";
            ayakkabi.ID = 1;
            ayakkabi.numara = 2;
            ayakkabi.Fiyat = 3;

            ayakkabilar.Add(ayakkabi);
            ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad1";
            ayakkabi.numara = 2;
            ayakkabi.Fiyat = 3;
            ayakkabi.ID = 2;
            ayakkabilar.Add(ayakkabi);
            ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad1";
            ayakkabi.ID = 3;
            ayakkabi.numara = 2;
            ayakkabi.Fiyat = 3;
            ayakkabilar.Add(ayakkabi);
            ayakkabi = new ayakkabi();
            ayakkabi.adi = "ad1";
            ayakkabi.ID = 4;
            ayakkabi.numara = 2;
            ayakkabi.Fiyat = 3;
            ayakkabilar.Add(ayakkabi);
            //ref sıfırlanacak sonra source ayarlanacak
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabilar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //--index'e göre 
            //--indexi getirirme ve silme komutu
            // int index_getir = dataGridView1.CurrentRow.Index;
            // ayakkabilar.RemoveAt(index_getir);

            //idye gore getirme ve silme  foreach kullanımı

            //--1. secenek index tutma > for yöntemi gibi bir değişken tanımlama ve index bulma
            //--2. secenek direk nesneyi diğer classa gönderme

            //-- hatalı yazım foreach için
            List<ayakkabi> tut = ayakkabilar;
            //--doğru yazım foreach için 
         /*   List<ayakkabi> tut = new List<ayakkabi>();
            tut.AddRange(ayakkabilar);*/
            foreach (var item in ayakkabilar)
            {
                if (item.ID.ToString() == id_sil_t.Text)
                { 
                    tut.Remove(item);
                    //--idye göre hatayı çözer, genel çözüm addRange
                    break;
                }
                    
            }
            ayakkabilar = tut;
            //--for ile getirme ve silme
            for (int i = 0; i < ayakkabilar.Count; i++)
            {
                if (ayakkabilar[i].ID.ToString() == id_sil_t.Text)
                {
                    ayakkabilar.Remove(ayakkabilar[i]);
                  //  ayakkabilar.RemoveAt(i);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabilar;
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayakkabi ayakkabi_cekilen = new ayakkabi();
         
             ayakkabi_cekilen = (ayakkabi)dataGridView1.CurrentRow.DataBoundItem;
            ayakkabi_cekilen.adi = "asdasd";

        }
    }
}
