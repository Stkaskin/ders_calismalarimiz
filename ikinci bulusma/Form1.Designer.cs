
namespace shoe_project
{
    partial class Form1
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
            this.fiyat_t = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getir_b = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_sil_t = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.id_t = new System.Windows.Forms.TextBox();
            this.ad_t = new System.Windows.Forms.TextBox();
            this.num_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fiyat_t
            // 
            this.fiyat_t.Location = new System.Drawing.Point(159, 103);
            this.fiyat_t.Name = "fiyat_t";
            this.fiyat_t.Size = new System.Drawing.Size(100, 20);
            this.fiyat_t.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 381);
            this.dataGridView1.TabIndex = 99;
            // 
            // getir_b
            // 
            this.getir_b.Location = new System.Drawing.Point(274, 41);
            this.getir_b.Name = "getir_b";
            this.getir_b.Size = new System.Drawing.Size(75, 70);
            this.getir_b.TabIndex = 100;
            this.getir_b.Text = "Getir";
            this.getir_b.UseVisualStyleBackColor = true;
            this.getir_b.Click += new System.EventHandler(this.getir_b_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 101;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_sil_t
            // 
            this.id_sil_t.Location = new System.Drawing.Point(159, 237);
            this.id_sil_t.Name = "id_sil_t";
            this.id_sil_t.Size = new System.Drawing.Size(100, 20);
            this.id_sil_t.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 102;
            this.button3.Text = "Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_t
            // 
            this.id_t.Location = new System.Drawing.Point(159, 25);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(100, 20);
            this.id_t.TabIndex = 0;
            // 
            // ad_t
            // 
            this.ad_t.Location = new System.Drawing.Point(159, 51);
            this.ad_t.Name = "ad_t";
            this.ad_t.Size = new System.Drawing.Size(100, 20);
            this.ad_t.TabIndex = 1;
            // 
            // num_t
            // 
            this.num_t.Location = new System.Drawing.Point(159, 77);
            this.num_t.Name = "num_t";
            this.num_t.Size = new System.Drawing.Size(100, 20);
            this.num_t.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "numara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "fiyat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getir_b);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fiyat_t);
            this.Controls.Add(this.num_t);
            this.Controls.Add(this.ad_t);
            this.Controls.Add(this.id_sil_t);
            this.Controls.Add(this.id_t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fiyat_t;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getir_b;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox id_sil_t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.TextBox ad_t;
        private System.Windows.Forms.TextBox num_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

