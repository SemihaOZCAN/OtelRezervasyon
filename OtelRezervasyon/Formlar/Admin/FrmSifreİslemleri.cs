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

namespace OtelRezervasyon.Formlar.Admin
{
    public partial class FrmSifreİslemleri : Form
    {
        public FrmSifreİslemleri()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();
        public int id;

        Repository<TblAdmin> repo = new Repository<TblAdmin>();

        private void FrmSifreİslemleri_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var admin = repo.Find(x => x.ID == id);
                textEditKullaniciAdi.Text = admin.Kullanici;
                textEditSifreMevcut.Text = admin.Sifre;
                textEditRol.Text = admin.Rol;

            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textEditYeniSifre.Text==textEditYsifreTekrar.Text)
            {
                TblAdmin t = new TblAdmin();
                t.Kullanici = textEditKullaniciAdi.Text;
                t.Sifre = textEditYeniSifre.Text;
                db.TblAdmin.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni Kullanıcı Başarılı Bir Şekilde Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Şifreler Uyuşmuyor Tekrar deneyınız","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (textEditYeniSifre.Text==textEditYsifreTekrar.Text)
            {
                var deger = repo.Find(x => x.ID == id);
                deger.Kullanici = textEditKullaniciAdi.Text;
                deger.Sifre = textEditYeniSifre.Text;
                deger.Rol = textEditRol.Text;
                repo.TUpdate(deger);
                XtraMessageBox.Show("Admin Şifre Bilgileri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Şifrelerin Uyuştuğuna emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmAdminListesi fr=new FrmAdminListesi();
            fr.ShowDialog();
            this.Close();
        }

        
    }
}
