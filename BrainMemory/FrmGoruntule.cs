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
    public partial class FrmGoruntule : Form
    {
        db d = new db();
        string gelenDeger;
        string kategori_adi;
        string icerik;
        string sql;
        public FrmGoruntule(string secilen)
        {
            InitializeComponent();
            gelenDeger = secilen;
        }
        public void doldur()
        {
            try
            {
                
                d.myConnection.Open();
                SQLiteCommand komut1 = new SQLiteCommand("SELECT * FROM TBL_Kategoriler WHERE id = '" + gelenDeger + "'", d.myConnection);
                SQLiteDataReader dr;
                dr = komut1.ExecuteReader();
                while (dr.Read())
                {
                    kategori_adi = dr["kategori_adi"].ToString();
                }
                dr.Close();
                //---------------------------
                if(txtAranan.Text != "")
                {
                    icerik = "%"+txtAranan.Text+"%";
                    sql = "SELECT * FROM TBL_Icerik WHERE kategori_id ='" + gelenDeger + "' and icerik LIKE '" + icerik + "' ";
                }
                else
                {
                    sql = "SELECT * FROM TBL_Icerik WHERE kategori_id ='" + gelenDeger + "'";
                }
                SQLiteCommand komut = new SQLiteCommand(sql, d.myConnection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvIcerik.DataSource = dt;
                dgvIcerik.Columns["id"].Visible = false;
                dgvIcerik.Columns["kategori_id"].Visible = false;
                dgvIcerik.Columns["icerik"].HeaderText = kategori_adi;

                dgvIcerik.Columns["icerik"].Width = 454;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Table Doldurma Hatasi ->" + ex.ToString());
            }
            finally
            {
                
                d.myConnection.Close();
            }
        }
        private void FrmGoruntule_Load(object sender, EventArgs e)
        {
            rbEkle.Checked = true;
            doldur();
        }

        private void rbEkle_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEkle.Checked == true)
            {
                rbSil.Checked = false;
                rbDuzenle.Checked = false;
            }
        }

        private void txtAranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            doldur();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            string islem_turu;
            if(rbEkle.Checked == true)
            {
                islem_turu = "ekle";
                FrmEkleDuzenle frm = new FrmEkleDuzenle(gelenDeger,islem_turu);
                frm.ShowDialog();
            }
            else if (rbSil.Checked == true)
            {
               if(dgvIcerik.Rows.Count != 0)
                {

                    DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {

                        string id = dgvIcerik.CurrentRow.Cells["id"].Value.ToString();
                        try
                        {
                            d.myConnection.Open();
                            SQLiteCommand delete = new SQLiteCommand("DELETE FROM TBL_Icerik where id = '" + id + "'", d.myConnection);
                            delete.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            d.myConnection.Close();
                            doldur();
                        }




                    }
                }
                else
                {
                    MessageBox.Show("Kayıt bulunmadığı için silme isteğinizi gerçekleştiremiyoruz.");
                }
            }
            else if(rbDuzenle.Checked == true)
            {
                
                islem_turu = "duzenle";
                try
                {
                    if(dgvIcerik.Rows.Count != 0)
                    {
                        string id = dgvIcerik.CurrentRow.Cells["id"].Value.ToString();
                        FrmEkleDuzenle frm = new FrmEkleDuzenle(id, islem_turu);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt bulunmadığı için düzenleme isteğinizi gerçekleştiremiyoruz.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
              
                
            }
        }
    }
}
