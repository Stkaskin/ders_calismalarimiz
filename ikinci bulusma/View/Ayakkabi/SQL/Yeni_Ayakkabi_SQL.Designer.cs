
namespace shoe_project.View.Ayakkabi.SQL
{
    partial class Yeni_Ayakkabi_SQL
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_t = new System.Windows.Forms.TextBox();
            this.ad_t = new System.Windows.Forms.TextBox();
            this.id_t = new System.Windows.Forms.TextBox();
            this.fiyat_t = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "id";
            // 
            // num_t
            // 
            this.num_t.Location = new System.Drawing.Point(143, 81);
            this.num_t.Name = "num_t";
            this.num_t.Size = new System.Drawing.Size(100, 20);
            this.num_t.TabIndex = 11;
            // 
            // ad_t
            // 
            this.ad_t.Location = new System.Drawing.Point(143, 55);
            this.ad_t.Name = "ad_t";
            this.ad_t.Size = new System.Drawing.Size(100, 20);
            this.ad_t.TabIndex = 10;
            // 
            // id_t
            // 
            this.id_t.Location = new System.Drawing.Point(143, 29);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(100, 20);
            this.id_t.TabIndex = 5;
            // 
            // fiyat_t
            // 
            this.fiyat_t.Location = new System.Drawing.Point(143, 107);
            this.fiyat_t.Name = "fiyat_t";
            this.fiyat_t.Size = new System.Drawing.Size(100, 20);
            this.fiyat_t.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "yeniformac";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Yeni_Ayakkabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fiyat_t);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_t);
            this.Controls.Add(this.ad_t);
            this.Controls.Add(this.id_t);
            this.Name = "Yeni_Ayakkabi";
            this.Text = "Yeni_Ayakkabi";
            this.Load += new System.EventHandler(this.Yeni_Ayakkabi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_t;
        private System.Windows.Forms.TextBox ad_t;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.TextBox fiyat_t;
        private System.Windows.Forms.Button button2;
    }
}