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

namespace OtelRezervasyon.Formlar.Misafir
{
    public partial class FrmMisafirKart : Form
    {
        public FrmMisafirKart()
        {
            //TODO deneme
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db=new DbOtelRezervasyonEntities3();

        public int id;

        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();

        string resim1, resim2;

        private void FrmMisafirKart_Load(object sender, EventArgs e)
        {
            //ulke
            lookUpEditUlke.Properties.DataSource = (from x in db.TblUlke
                                                    select new
                                                    {
                                                        x.UlkeID,
                                                        x.UlkeAD
                                                    }).ToList();
            //sehır
            lookUpEditSehir.Properties.DataSource = (from x in db.iller
                                                     select new
                                                     {
                                                         Id = x.id,
                                                         Şehir = x.sehir
                                                     }).ToList();
            //ilce
            lookUpEditIlce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                        Id = x.id,
                                                        İlçe = x.ilce
                                                    }).ToList();
            try
            {
                //GUNCELLENECEK KART BİLGİLERİ
                if (id != 0)
                {
                    var misafir = repo.Find(x => x.MisafirID == id);
                    textEditAdSoyad.Text = misafir.AdSoyad;
                    textEditTC.Text = misafir.TC;
                    memoEditAdres.Text = misafir.Adres;
                    textEditTelefon.Text = misafir.Telefon;
                    textEditMail.Text = misafir.Mail;
                    memoEditAciklama.Text = misafir.Acıklama;
                    pictureEditKimikOn.Image = Image.FromFile(misafir.KimlikFoto1);
                    pictureEditKimlikArka.Image = Image.FromFile(misafir.KimlikFoto2);
                    resim1 = misafir.KimlikFoto1;
                    resim2 = misafir.KimlikFoto2;
                    lookUpEditSehir.EditValue = misafir.sehir;
                    lookUpEditUlke.EditValue = misafir.Ulke;
                    lookUpEditIlce.EditValue = misafir.ilce;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Bir Hata Oluştu Lütfen Sütunları kontrol edin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        
        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                       Id=x.id,
                                                       İlçe=x.ilce,
                                                       Şehir=x.sehir
                                                    }).Where(y => y.Şehir == secilen).ToList();
        }
      
        //resim yukleme
        private void pictureEditKimikOn_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = pictureEditKimikOn.GetLoadedImageLocation().ToString();

        }

        //resim yukleme
        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }

        //vazgecme işlemi
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //guncelleme islemi
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.MisafirID == id);
            deger.AdSoyad = textEditAdSoyad.Text;
            deger.TC = textEditTC.Text;
            deger.Adres = memoEditAdres.Text;
            deger.Telefon = textEditTelefon.Text;
            deger.Mail = textEditMail.Text;
            deger.Adres = memoEditAdres.Text;
            deger.Acıklama = memoEditAciklama.Text;
            deger.KimlikFoto1 = resim1;
            deger.KimlikFoto2 = resim2;
            deger.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            deger.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
            deger.Durum =1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir Kartı Bilgileri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //kaydetme islemi
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEditKimlikArka.Image !=null && pictureEditKimikOn.Image !=null)
            {
                t.AdSoyad = textEditAdSoyad.Text;
                t.TC = textEditTC.Text;
                t.Telefon = textEditTelefon.Text;
                t.Mail = textEditMail.Text;
                t.Adres = memoEditAdres.Text;
                t.Acıklama = memoEditAciklama.Text;
                t.Durum = 1;
                t.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
                t.ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
                t.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
                t.KimlikFoto1 = resim1;
                t.KimlikFoto2 = resim2;
                repo.TAdd(t);
                XtraMessageBox.Show("Misafir Sisteme Başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen bilgilerinizi kontrol ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
