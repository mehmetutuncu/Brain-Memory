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
    public partial class FrmKategoriEkleDuzenle : Form
    {
        string id;
        string islem_turu;
        db d = new db();
        public FrmKategoriEkleDuzenle(string gelen_id , string islem)
        {
            InitializeComponent();
            this.id = gelen_id;
            this.islem_turu = islem;
        }
        public void doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "SELECT * FROM TBL_Kategoriler WHERE id = '" + id + "'";
                SQLiteCommand komut = new SQLiteCommand(sql,d.myConnection);
                SQLiteDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtKategoriAdi.Text = dr["kategori_adi"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
            }
            
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if(islem_turu == "ekle")
            {
                if(txtKategoriAdi.Text == "")
                {
                    MessageBox.Show("Kategori Adı boş bırakılamaz lütfen kontrol ediniz.");
                }
                else
                {
                    try
                    {
                        d.myConnection.Open();
                        string sql = "INSERT INTO TBL_Kategoriler(kategori_adi) VALUES(@ad)";
                        SQLiteCommand komut = new SQLiteCommand(sql, d.myConnection);
                        komut.Parameters.AddWithValue("@ad", txtKategoriAdi.Text);
                        komut.ExecuteNonQuery();



                        BrainMemory frm = (BrainMemory)Application.OpenForms["BrainMemory"];
                        frm.kategori_doldur();
                        frm.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        this.Close();
                    }
                }
            }
            else if(islem_turu == "duzenle")
            {
                try
                {
                    d.myConnection.Open();
                    string sql = "UPDATE TBL_Kategoriler SET kategori_adi = @ad WHERE id = '"+id+"'";
                    SQLiteCommand komut = new SQLiteCommand(sql, d.myConnection);
                    komut.Parameters.AddWithValue("@ad", txtKategoriAdi.Text);
                    komut.ExecuteNonQuery();



                    BrainMemory frm = (BrainMemory)Application.OpenForms["BrainMemory"];
                    frm.kategori_doldur();
                    frm.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    d.myConnection.Close();
                    this.Close();
                }
            }
        }

        private void FrmKategoriEkleDuzenle_Load(object sender, EventArgs e)
        {
            
            if (islem_turu == "ekle")
            {
                btnIslem.Text = "Kaydet";
            }
            else if(islem_turu == "duzenle")
            {
                doldur();
                btnIslem.Text = "Güncelle";
            }
        }
    }
}
