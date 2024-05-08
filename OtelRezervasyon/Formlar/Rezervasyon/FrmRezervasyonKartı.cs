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

namespace OtelRezervasyon.Formlar.Rezervasyon
{
    public partial class FrmRezervasyonKartı : Form
    {
        public FrmRezervasyonKartı()
        {
            InitializeComponent();
        }
        public int id;
        Repository<TblRezervasyon> repo = new Repository<TblRezervasyon>();
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();


        private void FrmRezervasyonKartı_Load(object sender, EventArgs e)
        {
            //misafir liste
            lookUpEditMisafir.Properties.DataSource = (from x in db.TblMisafir
                                                       select new
                                                       {
                                                           x.MisafirID,
                                                           x.AdSoyad
                                                  }).ToList();

            //misafir liste2
            lookUpEditKisi2.Properties.DataSource = (from x in db.TblMisafir
                                                       select new
                                                       {
                                                           x.MisafirID,
                                                           x.AdSoyad
                                                       }).ToList();
            //misafir liste3
            lookUpEditKisi3.Properties.DataSource = (from x in db.TblMisafir
                                                       select new
                                                       {
                                                           x.MisafirID,
                                                           x.AdSoyad
                                                       }).ToList();
            //misafir liste3
            lookUpEditKisi4.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirID,
                                                         x.AdSoyad
                                                     }).ToList();

            //oda liste
            lookUpEditOda.Properties.DataSource = (from x in db.TblOda
                                                   select new
                                                   {
                                                       x.OdaID,
                                                       x.OdaNo,
                                                       x.TblDurum.DurumAD
                                                   }).Where(y=>y.DurumAD=="Aktif").ToList();

            //Durum Liste
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                     select new
                                                     {
                                                         x.DurumID,
                                                         x.DurumAD
                                                     }).ToList();



            ///urun guncelleme alanı
            if (id != 0)
            {
                var rezervasyon = repo.Find(x => x.RezervasyonID == id);
                lookUpEditMisafir.EditValue = rezervasyon.Misafir;
                lookUpEditKisi2.EditValue = rezervasyon.Kisi1;
                lookUpEditKisi3.EditValue=rezervasyon.Kisi2;
                lookUpEditKisi4.EditValue = rezervasyon.Kisi3;
                dateEditGirisTarih.EditValue = rezervasyon.GirişTarih.ToString();
                dateEditÇıkısTarih.EditValue = rezervasyon.CikisTarih.ToString();
                numericUpDown1.Value = decimal.Parse(rezervasyon.Kisi.ToString());
                lookUpEditOda.EditValue = rezervasyon.Oda;
                textEditTelefon.Text = rezervasyon.Telefon;    
                lookUpEditDurum.EditValue = rezervasyon.Durum;
                memoEditAciklama.EditValue = rezervasyon.Aciklama;
                textEditToplamTutar.Text = rezervasyon.ToplamTutar.ToString();
            }
        }
        //kaydetme işlemi
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblRezervasyon t = new TblRezervasyon();

            if (numericUpDown1.Value==1)
            {
                t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            }
            if (numericUpDown1.Value==2)
            {
                t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                t.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
            }
            if (numericUpDown1.Value==3)
            {
                t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                t.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
                t.Kisi2 = int.Parse(lookUpEditKisi3.EditValue.ToString());
            }
            if (numericUpDown1.Value==4)
            {
                t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                t.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
                t.Kisi2 = int.Parse(lookUpEditKisi3.EditValue.ToString());
                t.Kisi3 = int.Parse(lookUpEditKisi4.EditValue.ToString());
            }

            t.GirişTarih = DateTime.Parse(dateEditGirisTarih.Text);
            t.CikisTarih = DateTime.Parse(dateEditÇıkısTarih.Text);
            t.Kisi = numericUpDown1.Value.ToString();
            t.Oda = int.Parse(lookUpEditOda.EditValue.ToString());
            // t.RezervasyonAdSoyad = textEditAdSoyad.Text;
            t.Telefon = textEditTelefon.Text;
            t.Aciklama = memoEditAciklama.Text;
            t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            t.ToplamTutar = decimal.Parse(textEditToplamTutar.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Rezervasyon Başarılı Bir Şekilde Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lookUpEditMisafir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditMisafir.EditValue.ToString());
            var telefon = db.TblMisafir.Where(x => x.MisafirID == secilen).Select(y => y.Telefon).FirstOrDefault();
            textEditTelefon.Text = telefon.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var rezervasyon = repo.Find(x => x.RezervasyonID == id);
            Repository<TblOda> repo2 = new Repository<TblOda>();

            var odadurum=repo2.Find(x=>x.OdaID ==int.Parse(lookUpEditOda.EditValue.ToString()));
            odadurum.Durum = 3; 
            repo2.TUpdate(odadurum);

            rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            rezervasyon.GirişTarih = DateTime.Parse( dateEditGirisTarih.Text);
            rezervasyon.CikisTarih = DateTime.Parse(dateEditÇıkısTarih.Text);
            rezervasyon.Kisi=numericUpDown1.Value.ToString();
            rezervasyon.Oda=int.Parse(lookUpEditOda.EditValue.ToString());
            rezervasyon.Telefon=textEditTelefon.Text;
            rezervasyon.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            rezervasyon.ToplamTutar=int.Parse(textEditToplamTutar.Text);

            if (numericUpDown1.Value == 1)
            {
                rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            }
            if (numericUpDown1.Value == 2)
            {
                rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                rezervasyon.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
            }
            if (numericUpDown1.Value == 3)
            { 
                rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                rezervasyon.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
                rezervasyon.Kisi2 = int.Parse(lookUpEditKisi3.EditValue.ToString());  
            }
            if (numericUpDown1.Value == 4)
            {
                rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                rezervasyon.Kisi1 = int.Parse(lookUpEditKisi2.EditValue.ToString());
                rezervasyon.Kisi2 = int.Parse(lookUpEditKisi3.EditValue.ToString());
                rezervasyon.Kisi3=int.Parse(lookUpEditKisi4.EditValue.ToString());
            }
            rezervasyon.Aciklama=memoEditAciklama.Text;
            repo.TUpdate(rezervasyon);
           
            XtraMessageBox.Show("Rezervasyon Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Odanın durumunu değiştirme:
            


        }
    }
}   

