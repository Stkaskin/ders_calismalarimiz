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
         class ayakkabi_old
        {
            public int ID { get; set; }

            public int Fiyat { get; set; }
            public int numara { get; set; }
            public string adi { get; set; }
        }
        //Global değişkenlerimiz
        List<ayakkabi_old> ayakkabi_oldlar = new List<ayakkabi_old>();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {



            ayakkabi_old ayakkabi_old = new ayakkabi_old();
            ayakkabi_old.adi = ad_t.Text;
            ayakkabi_old.ID = Convert.ToInt32(id_t.Text);
            ayakkabi_old.numara = Convert.ToInt32(num_t.Text);
            ayakkabi_old.Fiyat = Convert.ToInt32(fiyat_t.Text);

            ayakkabi_oldlar.Add(ayakkabi_old);
            //ref sıfırlanacak sonra source ayarlanacak
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabi_oldlar;



        }

        private void getir_b_Click(object sender, EventArgs e)
        {
            //class cekmek icin
            ayakkabi_old ayakkabi_old_cekilen = (ayakkabi_old)dataGridView1.CurrentRow.DataBoundItem;
            ad_t.Text = ayakkabi_old_cekilen.adi;
            id_t.Text = ayakkabi_old_cekilen.ID.ToString();
            num_t.Text = ayakkabi_old_cekilen.numara.ToString();
            fiyat_t.Text = ayakkabi_old_cekilen.Fiyat.ToString();
          
            //sectiğimiz satırdaki veriyi  ad veya index'e gore
            string veri_tek = dataGridView1.CurrentRow.Cells["adi"].Value.ToString();
            //satir numarası ve sutun numara veya adına gore
            string veri_numara = dataGridView1.Rows[0].Cells["adi"].Value.ToString();
          //  id_t.Text = veri_numara;
              


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ayakkabi_old ayakkabi_old = new ayakkabi_old();
            ayakkabi_old.adi = "ad1";
            ayakkabi_old.ID = 1;
            ayakkabi_old.numara = 2;
            ayakkabi_old.Fiyat = 3;

            ayakkabi_oldlar.Add(ayakkabi_old);
            ayakkabi_old = new ayakkabi_old();
            ayakkabi_old.adi = "ad1";
            ayakkabi_old.numara = 2;
            ayakkabi_old.Fiyat = 3;
            ayakkabi_old.ID = 2;
            ayakkabi_oldlar.Add(ayakkabi_old);
            ayakkabi_old = new ayakkabi_old();
            ayakkabi_old.adi = "ad1";
            ayakkabi_old.ID = 3;
            ayakkabi_old.numara = 2;
            ayakkabi_old.Fiyat = 3;
            ayakkabi_oldlar.Add(ayakkabi_old);
            ayakkabi_old = new ayakkabi_old();
            ayakkabi_old.adi = "ad1";
            ayakkabi_old.ID = 4;
            ayakkabi_old.numara = 2;
            ayakkabi_old.Fiyat = 3;
            ayakkabi_oldlar.Add(ayakkabi_old);
            //ref sıfırlanacak sonra source ayarlanacak
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabi_oldlar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //--index'e göre 
            //--indexi getirirme ve silme komutu
            // int index_getir = dataGridView1.CurrentRow.Index;
            // ayakkabi_oldlar.RemoveAt(index_getir);

            //idye gore getirme ve silme  foreach kullanımı

            //--1. secenek index tutma > for yöntemi gibi bir değişken tanımlama ve index bulma
            //--2. secenek direk nesneyi diğer classa gönderme

            //-- hatalı yazım foreach için
            List<ayakkabi_old> tut = ayakkabi_oldlar;
            //--doğru yazım foreach için 
         /*   List<ayakkabi_old> tut = new List<ayakkabi_old>();
            tut.AddRange(ayakkabi_oldlar);*/
            foreach (var item in ayakkabi_oldlar)
            {
                if (item.ID.ToString() == id_sil_t.Text)
                { 
                    tut.Remove(item);
                    //--idye göre hatayı çözer, genel çözüm addRange
                    break;
                }
                    
            }
            ayakkabi_oldlar = tut;
            //--for ile getirme ve silme
            for (int i = 0; i < ayakkabi_oldlar.Count; i++)
            {
                if (ayakkabi_oldlar[i].ID.ToString() == id_sil_t.Text)
                {
                    ayakkabi_oldlar.Remove(ayakkabi_oldlar[i]);
                  //  ayakkabi_oldlar.RemoveAt(i);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ayakkabi_oldlar;
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayakkabi_old ayakkabi_old_cekilen = new ayakkabi_old();
         
             ayakkabi_old_cekilen = (ayakkabi_old)dataGridView1.CurrentRow.DataBoundItem;
            ayakkabi_old_cekilen.adi = "asdasd";

        }
    }
}
