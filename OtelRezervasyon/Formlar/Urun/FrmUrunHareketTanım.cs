using DevExpress.XtraEditors;
using OtelRezervasyon.Entity;
using OtelRezervasyon.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.Formlar.Urun
{
    public partial class FrmUrunHareketTanım : Form
    {
        public FrmUrunHareketTanım()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();
        Repository<TblUrunHareket> repo = new Repository<TblUrunHareket>();
        public int id;

        private void FrmUrunHareketTanım_Load(object sender, EventArgs e)
        {
            //id degeri
            textEditID.Text = id.ToString();
            textEditID.Enabled = false;


            //urun Liste
            lookUpEditUrun.Properties.DataSource = (from x in db.TblUrun
                                                    select new
                                                    {
                                                        x.UrunID,
                                                        x.UrunAD
                                                    }).ToList();
            //verierin kart alanlarına doldurulması
            if (id!=0)
            {
                var urun = repo.Find(x => x.HareketID == id);
                lookUpEditUrun.EditValue = urun.Urun;
                textEditMiktar.Text = urun.Miktar.ToString();
                memoEditAciklama.Text = urun.Aciklama;
                comboBoxHareket.Text = urun.HareketTuru;
                dateEditTarih.Text = urun.Tarih.ToString();
                   
            }
        }


        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblUrunHareket t = new TblUrunHareket();
            t.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            t.Tarih = DateTime.Parse(dateEditTarih.Text);
            t.HareketTuru = comboBoxHareket.Text;
            t.Miktar = decimal.Parse(textEditMiktar.Text);
            t.Aciklama = memoEditAciklama.Text;
           
            if (comboBoxHareket.Text=="Giriş")
            {
                t.BirimFiyat = decimal.Parse(textEditBirimFiyat.Text);
                t.ToplamFiyat = decimal.Parse(textEditToplam.Text);
            }
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün Hareketi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            var deger = repo.Find(x => x.HareketID == id);
            deger.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            deger.Tarih = DateTime.Parse(dateEditTarih.Text);
            deger.HareketTuru = comboBoxHareket.Text;
            deger.Miktar =decimal.Parse( textEditMiktar.Text);
            deger.Aciklama = memoEditAciklama.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Ürün Hareketi Başarlı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   
        private void textEditMiktar_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxHareket.Text == "Giriş")
            {
                double miktar, birimFiyat, toplam;
                miktar = Convert.ToDouble(textEditMiktar.Value);
                birimFiyat = Convert.ToDouble(textEditBirimFiyat.Text);
                toplam = miktar * birimFiyat;

                textEditToplam.Text = toplam.ToString();
            }
           
        }
    }
}
