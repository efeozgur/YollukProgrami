namespace YollukProgrami
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkKendi = new System.Windows.Forms.CheckBox();
            this.gosterge = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txKacKm = new MetroFramework.Controls.MetroTextBox();
            this.lblKacKm = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txTasicUcreti = new MetroFramework.Controls.MetroTextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gosterge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 231);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 57);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // chkKendi
            // 
            this.chkKendi.AutoSize = true;
            this.chkKendi.Location = new System.Drawing.Point(23, 91);
            this.chkKendi.Name = "chkKendi";
            this.chkKendi.Size = new System.Drawing.Size(76, 17);
            this.chkKendi.TabIndex = 1;
            this.chkKendi.Text = "Kendisimi?";
            this.chkKendi.UseVisualStyleBackColor = true;
            // 
            // gosterge
            // 
            this.gosterge.Location = new System.Drawing.Point(157, 90);
            this.gosterge.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gosterge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gosterge.Name = "gosterge";
            this.gosterge.Size = new System.Drawing.Size(120, 20);
            this.gosterge.TabIndex = 2;
            this.gosterge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(157, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Gösterge ";
            // 
            // txKacKm
            // 
            this.txKacKm.Location = new System.Drawing.Point(157, 118);
            this.txKacKm.Name = "txKacKm";
            this.txKacKm.Size = new System.Drawing.Size(120, 23);
            this.txKacKm.TabIndex = 4;
            this.txKacKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txKacKm_KeyPress);
            // 
            // lblKacKm
            // 
            this.lblKacKm.AutoSize = true;
            this.lblKacKm.Location = new System.Drawing.Point(23, 118);
            this.lblKacKm.Name = "lblKacKm";
            this.lblKacKm.Size = new System.Drawing.Size(89, 19);
            this.lblKacKm.TabIndex = 5;
            this.lblKacKm.Text = "Kaç Kilometre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Taşıt Ücreti";
            // 
            // txTasicUcreti
            // 
            this.txTasicUcreti.Location = new System.Drawing.Point(157, 147);
            this.txTasicUcreti.Name = "txTasicUcreti";
            this.txTasicUcreti.Size = new System.Drawing.Size(120, 23);
            this.txTasicUcreti.TabIndex = 6;
            this.txTasicUcreti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTasicUcreti_KeyPress);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(157, 176);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(120, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 237);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(201, 206);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = ">";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // AnaForm
            // 
            this.AcceptButton = this.btnHesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 300);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txTasicUcreti);
            this.Controls.Add(this.lblKacKm);
            this.Controls.Add(this.txKacKm);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gosterge);
            this.Controls.Add(this.chkKendi);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AnaForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gosterge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkKendi;
        private System.Windows.Forms.NumericUpDown gosterge;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txKacKm;
        private MetroFramework.Controls.MetroLabel lblKacKm;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txTasicUcreti;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnEkle;
    }
}

