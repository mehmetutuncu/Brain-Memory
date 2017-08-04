using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BrainMemory
{
    public partial class BrainMemory : Form
    {
        db d = new db();
        
        public BrainMemory()
        {
            InitializeComponent();
            
        }
        public void kategori_doldur()
        {
            cmbKategoriler.Items.Clear();
            cmbKategori_id.Items.Clear();
            try {


                d.myConnection.Open();
                String sorgu = "SELECT * FROM TBL_Kategoriler";
                SQLiteCommand cmd_select = new SQLiteCommand(sorgu,d.myConnection);
                SQLiteDataReader sdr;
                sdr = cmd_select.ExecuteReader();
                while (sdr.Read())
                {
                    cmbKategori_id.Items.Add(sdr["id"]);
                    cmbKategoriler.Items.Add(sdr["kategori_adi"]);
                }
                cmbKategoriler.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Doldurma Hatasi -> "+ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
            }
            
        }
        private void rbGoruntule_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton'ların aynı anda seçili olması engelleniyor.
            if( rbGoruntule.Checked == true)
            {
                rbDuzenle.Checked = false;
                rbEkle.Checked = false;
            }
        }

        private void BrainMemory_Load(object sender, EventArgs e)
        {
            
            rbGoruntule.Checked = true;
            kategori_doldur();
            timer1.Enabled = true;
            timerLabel.Text = "- Mehmet Yusuf Tütüncü -";
            
            

        }

        private void btnUgyula_Click(object sender, EventArgs e)
        {
            string islem_turu;
            cmbKategori_id.SelectedIndex = cmbKategoriler.SelectedIndex;
            if (rbGoruntule.Checked == true)
            {
                String secilen = cmbKategori_id.SelectedItem.ToString();
                FrmGoruntule frm = new FrmGoruntule(secilen);
                frm.ShowDialog();
            }
            else if (rbEkle.Checked == true)
            {
                islem_turu = "ekle";
                string secilen = cmbKategori_id.SelectedItem.ToString();
                FrmKategoriEkleDuzenle frm = new FrmKategoriEkleDuzenle(secilen,islem_turu);
                frm.ShowDialog();
            }
            else if (rbDuzenle.Checked == true)
            {
                islem_turu = "duzenle";
                string secilen = cmbKategori_id.SelectedItem.ToString();
                FrmKategoriEkleDuzenle frm = new FrmKategoriEkleDuzenle(secilen, islem_turu);
                frm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = timerLabel.Text.Substring(1) + timerLabel.Text.Substring(0, 1);

        }
    }
}
