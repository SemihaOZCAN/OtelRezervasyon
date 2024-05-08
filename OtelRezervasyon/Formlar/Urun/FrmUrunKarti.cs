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
    public partial class FrmUrunKarti : Form
    {
        public FrmUrunKarti()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();
        
        public int id;
        Repository<TblUrun> repo = new Repository<TblUrun>();
        TblUrun t = new TblUrun();

        private void FrmUrunKarti_Load(object sender, EventArgs e)
        {
            //urun grup liste
            lookUpEditUrunGrup.Properties.DataSource = (from x in db.TblUrunGrup
                                                        select new
                                                        {
                                                            x.UrunGrupID,
                                                            x.UrunGrupAD
                                                        }).ToList();
            //birim liste
            lookUpEditBirim.Properties.DataSource = (from x in db.TblBirim
                                                     select new
                                                     {
                                                         x.BirimID,
                                                         x.BirimAD
                                                     }).ToList();
            //durum lıste
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                     select new
                                                     {
                                                         x.DurumID,
                                                         x.DurumAD
                                                     }).ToList();
            ///urun guncelleme alanı
            if (id!=0)
            {
                var urun = repo.Find(x => x.UrunID == id);
                textEditUrunAd.Text = urun.UrunAD;
                lookUpEditUrunGrup.EditValue = urun.UrunGrup;
                lookUpEditBirim.EditValue = urun.Birim;
                textEditFiyat.Text = urun.Fiyat.ToString();
                textEditToplam.Text = urun.Toplam.ToString();
                textEditKDV.Text = urun.Kdv.ToString();
                lookUpEditDurum.EditValue = urun.Durum;
            }


        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           

            t.UrunAD = textEditUrunAd.Text;
            t.UrunGrup =int.Parse( lookUpEditUrunGrup.EditValue.ToString());
            t.Birim=int.Parse(lookUpEditBirim.EditValue.ToString());
            t.Durum =int.Parse(lookUpEditDurum.EditValue.ToString());
            t.Fiyat = decimal.Parse( textEditFiyat.Text);
            t.Toplam = decimal.Parse( textEditToplam.Text);
            t.Kdv = byte.Parse(textEditKDV.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Urun Basarılı bir şekilde verı tabanına kaydedildi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urundeger = repo.Find(x => x.UrunID == id);
            urundeger.UrunAD = textEditUrunAd.Text;
            urundeger.UrunGrup = int.Parse(lookUpEditUrunGrup.EditValue.ToString());
            urundeger.Birim=int.Parse(lookUpEditBirim.EditValue.ToString());
            urundeger.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            urundeger.Fiyat =decimal.Parse( textEditFiyat.Text);
            urundeger.Toplam =decimal.Parse( textEditToplam.Text);
            urundeger.Kdv =byte.Parse( textEditKDV.Text);
            repo.TUpdate(urundeger);
            XtraMessageBox.Show("Urun Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textEditKDV.Text = "1";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textEditKDV.Text="8";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textEditKDV.Text = "10";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textEditKDV.Text = "18";
        }
    }
}
