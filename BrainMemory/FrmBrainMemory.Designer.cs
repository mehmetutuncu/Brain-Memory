namespace BrainMemory
{
    partial class BrainMemory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrainMemory));
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbGoruntule = new System.Windows.Forms.RadioButton();
            this.rbEkle = new System.Windows.Forms.RadioButton();
            this.rbDuzenle = new System.Windows.Forms.RadioButton();
            this.btnUgyula = new System.Windows.Forms.Button();
            this.cmbKategori_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(108, 228);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(140, 21);
            this.cmbKategoriler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoriler :";
            // 
            // rbGoruntule
            // 
            this.rbGoruntule.AutoSize = true;
            this.rbGoruntule.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGoruntule.ForeColor = System.Drawing.Color.Red;
            this.rbGoruntule.Location = new System.Drawing.Point(18, 264);
            this.rbGoruntule.Name = "rbGoruntule";
            this.rbGoruntule.Size = new System.Drawing.Size(88, 19);
            this.rbGoruntule.TabIndex = 2;
            this.rbGoruntule.TabStop = true;
            this.rbGoruntule.Text = "Görüntüle";
            this.rbGoruntule.UseVisualStyleBackColor = true;
            this.rbGoruntule.CheckedChanged += new System.EventHandler(this.rbGoruntule_CheckedChanged);
            // 
            // rbEkle
            // 
            this.rbEkle.AutoSize = true;
            this.rbEkle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEkle.ForeColor = System.Drawing.Color.Red;
            this.rbEkle.Location = new System.Drawing.Point(112, 264);
            this.rbEkle.Name = "rbEkle";
            this.rbEkle.Size = new System.Drawing.Size(54, 19);
            this.rbEkle.TabIndex = 3;
            this.rbEkle.TabStop = true;
            this.rbEkle.Text = "Ekle";
            this.rbEkle.UseVisualStyleBackColor = true;
            // 
            // rbDuzenle
            // 
            this.rbDuzenle.AutoSize = true;
            this.rbDuzenle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDuzenle.ForeColor = System.Drawing.Color.Red;
            this.rbDuzenle.Location = new System.Drawing.Point(172, 264);
            this.rbDuzenle.Name = "rbDuzenle";
            this.rbDuzenle.Size = new System.Drawing.Size(74, 19);
            this.rbDuzenle.TabIndex = 4;
            this.rbDuzenle.TabStop = true;
            this.rbDuzenle.Text = "Düzenle";
            this.rbDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnUgyula
            // 
            this.btnUgyula.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUgyula.ForeColor = System.Drawing.Color.Red;
            this.btnUgyula.Location = new System.Drawing.Point(86, 289);
            this.btnUgyula.Name = "btnUgyula";
            this.btnUgyula.Size = new System.Drawing.Size(122, 25);
            this.btnUgyula.TabIndex = 5;
            this.btnUgyula.Text = "UYGULA";
            this.btnUgyula.UseVisualStyleBackColor = true;
            this.btnUgyula.Click += new System.EventHandler(this.btnUgyula_Click);
            // 
            // cmbKategori_id
            // 
            this.cmbKategori_id.FormattingEnabled = true;
            this.cmbKategori_id.Location = new System.Drawing.Point(263, 20);
            this.cmbKategori_id.Name = "cmbKategori_id";
            this.cmbKategori_id.Size = new System.Drawing.Size(10, 21);
            this.cmbKategori_id.TabIndex = 6;
            this.cmbKategori_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Parry Hotter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(46, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 64);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brain Memory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 124);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Teal;
            this.timerLabel.Location = new System.Drawing.Point(25, 348);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 18);
            this.timerLabel.TabIndex = 9;
            // 
            // BrainMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 384);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategori_id);
            this.Controls.Add(this.btnUgyula);
            this.Controls.Add(this.rbDuzenle);
            this.Controls.Add(this.rbEkle);
            this.Controls.Add(this.rbGoruntule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrainMemory";
            this.Text = "BrainMemory";
            this.Load += new System.EventHandler(this.BrainMemory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbGoruntule;
        private System.Windows.Forms.RadioButton rbEkle;
        private System.Windows.Forms.RadioButton rbDuzenle;
        private System.Windows.Forms.Button btnUgyula;
        private System.Windows.Forms.ComboBox cmbKategori_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
    }
}

