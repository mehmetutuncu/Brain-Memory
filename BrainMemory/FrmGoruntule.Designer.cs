namespace BrainMemory
{
    partial class FrmGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoruntule));
            this.dgvIcerik = new System.Windows.Forms.DataGridView();
            this.rbEkle = new System.Windows.Forms.RadioButton();
            this.rbSil = new System.Windows.Forms.RadioButton();
            this.rbDuzenle = new System.Windows.Forms.RadioButton();
            this.btnIslem = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcerik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIcerik
            // 
            this.dgvIcerik.AllowUserToAddRows = false;
            this.dgvIcerik.AllowUserToDeleteRows = false;
            this.dgvIcerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcerik.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvIcerik.Location = new System.Drawing.Point(3, 53);
            this.dgvIcerik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvIcerik.Name = "dgvIcerik";
            this.dgvIcerik.ReadOnly = true;
            this.dgvIcerik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvIcerik.Size = new System.Drawing.Size(497, 255);
            this.dgvIcerik.TabIndex = 0;
            // 
            // rbEkle
            // 
            this.rbEkle.AutoSize = true;
            this.rbEkle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEkle.ForeColor = System.Drawing.Color.Red;
            this.rbEkle.Location = new System.Drawing.Point(12, 20);
            this.rbEkle.Name = "rbEkle";
            this.rbEkle.Size = new System.Drawing.Size(60, 22);
            this.rbEkle.TabIndex = 1;
            this.rbEkle.TabStop = true;
            this.rbEkle.Text = "Ekle";
            this.rbEkle.UseVisualStyleBackColor = true;
            this.rbEkle.CheckedChanged += new System.EventHandler(this.rbEkle_CheckedChanged);
            // 
            // rbSil
            // 
            this.rbSil.AutoSize = true;
            this.rbSil.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSil.ForeColor = System.Drawing.Color.Red;
            this.rbSil.Location = new System.Drawing.Point(78, 20);
            this.rbSil.Name = "rbSil";
            this.rbSil.Size = new System.Drawing.Size(47, 22);
            this.rbSil.TabIndex = 2;
            this.rbSil.TabStop = true;
            this.rbSil.Text = "Sil";
            this.rbSil.UseVisualStyleBackColor = true;
            // 
            // rbDuzenle
            // 
            this.rbDuzenle.AutoSize = true;
            this.rbDuzenle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDuzenle.ForeColor = System.Drawing.Color.Red;
            this.rbDuzenle.Location = new System.Drawing.Point(131, 20);
            this.rbDuzenle.Name = "rbDuzenle";
            this.rbDuzenle.Size = new System.Drawing.Size(86, 22);
            this.rbDuzenle.TabIndex = 3;
            this.rbDuzenle.TabStop = true;
            this.rbDuzenle.Text = "Düzenle";
            this.rbDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnIslem
            // 
            this.btnIslem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIslem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIslem.ForeColor = System.Drawing.Color.Red;
            this.btnIslem.Location = new System.Drawing.Point(223, 13);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(75, 34);
            this.btnIslem.TabIndex = 4;
            this.btnIslem.Text = "İŞLEM";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(324, 17);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(167, 25);
            this.txtAranan.TabIndex = 5;
            this.txtAranan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAranan_KeyPress);
            // 
            // FrmGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 311);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.rbDuzenle);
            this.Controls.Add(this.rbSil);
            this.Controls.Add(this.rbEkle);
            this.Controls.Add(this.dgvIcerik);
            this.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrainMemory";
            this.Load += new System.EventHandler(this.FrmGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIcerik;
        private System.Windows.Forms.RadioButton rbEkle;
        private System.Windows.Forms.RadioButton rbSil;
        private System.Windows.Forms.RadioButton rbDuzenle;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.TextBox txtAranan;
    }
}