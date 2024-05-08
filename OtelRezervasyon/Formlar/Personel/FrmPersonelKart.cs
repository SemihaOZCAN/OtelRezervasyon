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

namespace OtelRezervasyon.Formlar.Personel
{
    public partial class FrmPersonelKart : Form
    {
        public FrmPersonelKart()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        public int id;
        Repository<TblPersonel> repo = new Repository<TblPersonel>();


        private void FrmPersonelKart_Load(object sender, EventArgs e)
        {
            //this.Text = id.ToString();
            if (id!=0)
            {
                var personel = repo.Find(x => x.PersonelID == id);
                textEditAdSoyad.Text = personel.AdSoyad;
                textEditTC.Text = personel.TC;
                memoEditAdres.Text = personel.Adres;
                textEditTelefon.Text = personel.Telefon;
                textEditMail.Text = personel.Mail;
                dateEditGirisTarih.Text = personel.IşeGirişTarih.ToString();
                dateEditCikisTarih.Text = personel.IseCikisTarih.ToString();
                memoEditAciklama.Text = personel.Aciklama;
                textEditSifre.Text = personel.Sifre;
                pictureEditKimikOn.Image = Image.FromFile(personel.KimlikOn);
                pictureEditKimlikArka.Image = Image.FromFile(personel.KimlikArka);
                labelControl15.Text = personel.KimlikOn;
                labelControl16.Text = personel.KimlikArka;
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.PersonelGorev;

               
            }
           //departman
            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAD
                                                         }).ToList();

            //gorev 
            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorev
                                                     select new
                                                     {
                                                         x.GorevID,
                                                         x.GorevAD
                                                     }).ToList();

        }

        //vazgecme işlemi
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
       
        //kaydetme işlemi
        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
            TblPersonel t = new TblPersonel();
            t.AdSoyad = textEditAdSoyad.Text;
            t.TC = textEditTC.Text;
            t.Adres = memoEditAdres.Text;
            t.Telefon = textEditTelefon.Text;
            t.Mail = textEditMail.Text;
            t.IşeGirişTarih = DateTime.Parse(dateEditGirisTarih.Text);
            t.Departman =int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.PersonelGorev =int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Aciklama = memoEditAciklama.Text;
            t.KimlikOn = pictureEditKimikOn.GetLoadedImageLocation();
            t.KimlikArka = pictureEditKimlikArka.GetLoadedImageLocation();
            t.Sifre = textEditSifre.Text;
            t.Durum = 1;
            repo.TAdd(t);
            XtraMessageBox.Show("personel başarılı bir şekilde sisteme kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //guncelleme işlemi
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelID == id);
           deger.AdSoyad = textEditAdSoyad.Text;
            deger.TC = textEditTC.Text;
            deger.Adres = memoEditAdres.Text;
            deger.Telefon = textEditTelefon.Text;
            deger.Mail = textEditMail.Text;
            deger.IşeGirişTarih = DateTime.Parse(dateEditGirisTarih.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.PersonelGorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Sifre = textEditSifre.Text;
            deger.Aciklama = memoEditAciklama.Text;
            deger.KimlikOn = labelControl15.Text;
            deger.KimlikArka = labelControl16.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel Kartı Bilgileri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //resim yukleme
        private void pictureEditKimikOn_EditValueChanged(object sender, EventArgs e)
        {
            labelControl15.Text = pictureEditKimikOn.GetLoadedImageLocation().ToString();

        }
        //resim yukleme
        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            labelControl16.Text = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }
    }
}
