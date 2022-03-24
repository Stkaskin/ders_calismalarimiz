
namespace Shoe_Project_V2.View.Satis_Formlar
{
    partial class Satislar_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yeni_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 458);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // yeni_btn
            // 
            this.yeni_btn.Location = new System.Drawing.Point(764, 120);
            this.yeni_btn.Name = "yeni_btn";
            this.yeni_btn.Size = new System.Drawing.Size(112, 60);
            this.yeni_btn.TabIndex = 6;
            this.yeni_btn.Text = "Yeni";
            this.yeni_btn.UseVisualStyleBackColor = true;
            this.yeni_btn.Click += new System.EventHandler(this.yeni_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Detaylı Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Satislar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 636);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yeni_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Satislar_Form";
            this.Text = "Satislar_Form";
            this.Load += new System.EventHandler(this.Satislar_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button yeni_btn;
        private System.Windows.Forms.Button button2;
    }
}