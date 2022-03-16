using Shoe_Project_V2.View.Ayakkabi_Formlar;
using Shoe_Project_V2.View.Ayakkabi_Formlar.Ayakkabi_Detaylari;
using Shoe_Project_V2.View.Musteri_Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Project_V2.View
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        private void SayfaGetir(Form form)
        {
            panel2.Controls.Clear();
            if ((Form)Application.OpenForms[form.Name] == null)
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.None;
                form.TopLevel = false;
                form.BackColor = Color.White;
                form.Show();          
            }
            else
            {
                form =(Form)Application.OpenForms[form.Name];
              
            }
            panel2.Controls.Add(form);      
            this.BackColor = Color.White;
            label1.Text = form.Name;
            controlMenuW();



        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel2.Size = this.Size;

        }
        private void urunler_btn_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Ayakkabi_Form());
        }
  
     

        private void musteriler_btn_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Musteriler_Form());
        }

        private void marka_btn_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Marka_Form());
        }

        private void renk_btn_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Renk_Form());
        }

        private void numara_btn_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Numara_Form());
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            controlMenuW();
        }
        private void controlMenuW()
        {
            if (panel1.Height > 50)
            {
                panel1.Size = button1.Size;
               
                   panel2.Location = new Point(70, 30);
            }
            else
            {
                panel1.Size = new Size(200, 5000);
                    panel2.Location = new Point(panel1.Width + 20, 30);
            }
        }

        private void satislar_btn_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Satis_Formlar.Satislar_Form());
        }
    }
}
