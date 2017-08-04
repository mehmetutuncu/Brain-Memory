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
    public partial class FrmEkleDuzenle : Form
    {
        string id;
        db d = new db();
        string islemTuru;
        public FrmEkleDuzenle(string gelen,string islem_turu)
        {
            InitializeComponent();
            id = gelen;
            islemTuru = islem_turu;
        }
        public void doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "SELECT icerik FROM TBL_Icerik WHERE id = '" + id + "'";
                SQLiteCommand komut = new SQLiteCommand(sql, d.myConnection);
                SQLiteDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtIcerik.Text = dr["icerik"].ToString();
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(islemTuru == "ekle")
            {
                if (txtIcerik.Text == "")
                {
                    MessageBox.Show("İçerik boş bırakılamaz lütfen kontrol ediniz!");
                }
                else
                {
                    try
                    {
                        d.myConnection.Open();
                        string sql = "INSERT INTO TBL_Icerik(kategori_id,icerik) VALUES(@id,@icerik)";
                        SQLiteCommand komut = new SQLiteCommand(sql, d.myConnection);
                        komut.Parameters.AddWithValue("@id", id);
                        komut.Parameters.AddWithValue("@icerik", txtIcerik.Text);
                        komut.ExecuteNonQuery();
                        txtIcerik.Text = "";
                        FrmGoruntule frm = (FrmGoruntule)Application.OpenForms["FrmGoruntule"];
                        frm.doldur();
                        frm.Refresh();
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
            }
            else if(islemTuru == "duzenle")
            {
                try
                {
                    d.myConnection.Open();
                    string sql = "UPDATE TBL_Icerik SET icerik = @icerik where id ='"+id+"'";
                    SQLiteCommand komut = new SQLiteCommand(sql,d.myConnection);
                    komut.Parameters.AddWithValue("@icerik", txtIcerik.Text);
                    komut.ExecuteNonQuery();
                    FrmGoruntule frm = (FrmGoruntule)Application.OpenForms["FrmGoruntule"];
                    frm.doldur();
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

        private void FrmEkleDuzenle_Load(object sender, EventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            if (islemTuru == "duzenle")
            {
                btnKaydet.Text = "Duzenle";
                doldur();
            }
            
        }
    }
}
