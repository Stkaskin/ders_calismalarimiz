
namespace shoe_project.View.Ayakkabi
{
    partial class Ayakkabi_Anaform
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
            this.ekle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.duzenle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 686);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(867, 96);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(118, 64);
            this.ekle_btn.TabIndex = 1;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(867, 166);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(118, 72);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // duzenle_btn
            // 
            this.duzenle_btn.Location = new System.Drawing.Point(867, 244);
            this.duzenle_btn.Name = "duzenle_btn";
            this.duzenle_btn.Size = new System.Drawing.Size(118, 63);
            this.duzenle_btn.TabIndex = 3;
            this.duzenle_btn.Text = "DÜZENLE";
            this.duzenle_btn.UseVisualStyleBackColor = true;
            this.duzenle_btn.Click += new System.EventHandler(this.duzenle_btn_Click);
            // 
            // Ayakkabi_Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.duzenle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ayakkabi_Anaform";
            this.Text = "Ayakkabi_Anaform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ayakkabi_Anaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button duzenle_btn;
    }
}