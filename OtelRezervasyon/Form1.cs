using DevExpress.XtraTabbedMdi;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumTanımlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmDurum frm = new Formlar.Tanımlamalar.FrmDurum();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }


        }

        private void btnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmBirim frm = new Formlar.Tanımlamalar.FrmBirim();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }


        }

        private void btnDepartmanTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmDepartman frm = new Formlar.Tanımlamalar.FrmDepartman();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmGorev frm = new Formlar.Tanımlamalar.FrmGorev();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa fr = new Formlar.Tanımlamalar.FrmKasa();
            fr.MdiParent = this;
            fr.Show();

        }



        private void btnKurTanımları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmKurlar frm = new Formlar.Tanımlamalar.FrmKurlar();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }

        }


        private void btnOdaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmOda frm = new Formlar.Tanımlamalar.FrmOda();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }

        }

        private void btnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmTelefon frm = new Formlar.Tanımlamalar.FrmTelefon();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }

        }

        private void btnUlkeTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmUlke frm = new Formlar.Tanımlamalar.FrmUlke();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }

        }


        private void btnUrunGrupTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Tanımlamalar.FrmUrunGrup frm = new Formlar.Tanımlamalar.FrmUrunGrup();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }

        }

        private void btnPersonelListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Personel.FrmPersonelListe frm = new Formlar.Personel.FrmPersonelListe();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnPersonelKartı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Personel.FrmPersonelKart frm = new Formlar.Personel.FrmPersonelKart();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnMiisafirKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Misafir.FrmMisafirKart frm = new Formlar.Misafir.FrmMisafirKart();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }



        private void btnMisafirListeleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Misafir.FrmMusteriListele frm = new Formlar.Misafir.FrmMusteriListele();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }


        private void btnUrunListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Urun.FrmUrunListe frm = new Formlar.Urun.FrmUrunListe();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnUrunKartı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Urun.FrmUrunKarti frm = new Formlar.Urun.FrmUrunKarti();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnUrunGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Urun.FrmUrunGirisHareketleri frm = new Formlar.Urun.FrmUrunGirisHareketleri();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Urun.FrmUrunCıkısHareket frm = new Formlar.Urun.FrmUrunCıkısHareket();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnYeniUrunHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Urun.FrmUrunHareketTanım frm = new Formlar.Urun.FrmUrunHareketTanım();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnRezervasyonListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Rezervasyon.FrmRezervasyonListe frm = new Formlar.Rezervasyon.FrmRezervasyonListe();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }



        private void btnRezervasyonKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Rezervasyon.FrmRezervasyonKartı frm = new Formlar.Rezervasyon.FrmRezervasyonKartı();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnAktifRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Rezervasyon.FrmAktifRezervasyon frm = new Formlar.Rezervasyon.FrmAktifRezervasyon();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnİptalRezervasypn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Rezervasyon.FrmİptalRezervasyon frm = new Formlar.Rezervasyon.FrmİptalRezervasyon();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnGecmisRezerasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Rezervasyon.FrmGecmisRezervasyonlar frm = new Formlar.Rezervasyon.FrmGecmisRezervasyonlar();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnGelecekRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Rezervasyon.FrmGelecekRezervasyonlar frm = new Formlar.Rezervasyon.FrmGelecekRezervasyonlar();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("outlookcal:");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Takvim uygulaması başlatılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Araclar.FrmKurlar frm = new Formlar.Araclar.FrmKurlar();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Araclar.FrmYoutube frm = new Formlar.Araclar.FrmYoutube();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnGoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Araclar.FrmGoogle frm = new Formlar.Araclar.FrmGoogle();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string excelPath = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE"; // Office 2016 için örnek
                if (!System.IO.File.Exists(excelPath))
                {
                    excelPath = @"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE"; // 32-bit Office için örnek
                }

                if (System.IO.File.Exists(excelPath))
                {
                    System.Diagnostics.Process.Start(excelPath);
                }
                else
                {
                    MessageBox.Show("Excel bulunamadı. Lütfen Excel'in yüklü olduğundan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel başlatılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSifreİslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Admin.FrmSifreİslemleri fr = new Formlar.Admin.FrmSifreİslemleri();
            fr.Show();
        }



        private void btnYetki_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Admin.FrmSifreİslemleri fr = new Formlar.Admin.FrmSifreİslemleri();
            fr.Show();
        }

        private void btnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHesapMak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.AnaForm.FrmAnaForm frm = new Formlar.AnaForm.FrmAnaForm();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

 
        private void btnGrafik1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Grafikler.FrmGrafik1 frm = new Formlar.Grafikler.FrmGrafik1();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void BtnGrafik1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool formControl = false;
            Formlar.Grafikler.FrmGrafik2 frm = new Formlar.Grafikler.FrmGrafik2();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }
        public string kullaniciRolu;
        private void Form1_Load(object sender, EventArgs e)
        {

            //this.Text=kullaniciadi.ToString();
            //ribbonPageTanımlamalar.Visible = false;
            //if (kullaniciRolu != "B") 
            //{
            //    ribbonPageTanımlamalar.Visible = false;
            //}

            bool formControl = false;
            Formlar.AnaForm.FrmAnaForm frm = new Formlar.AnaForm.FrmAnaForm();
            if (MdiChildren.Length == 0) //MdiChildren boşsa direkt olarak açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            foreach (var item in MdiChildren) //Eğer MdiChildren boş değilse içerisinde bizim açmak istediğimiz form var mı yok diye kontrol ediyoru
            {
                if (item.Text == frm.AccessibilityObject.Name)
                {
                    formControl = true;
                    break;
                }
            }
            if (!formControl) //Eğer formControl değeri false dönerse formu açıyoruz
            {
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.MdiChild.Text == frm.AccessibilityObject.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        break;
                    }
                }
            }
        }

        private void btnResepsiyonHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmResepsiyonHareket fr = new Formlar.Kasa.FrmResepsiyonHareket();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniKasaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa fr = new Formlar.Tanımlamalar.FrmKasa();
            fr.Show();
        }

        private void btnKasaCikisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmKasaCikisKarti fr = new Formlar.Kasa.FrmKasaCikisKarti();
            fr.Show();
        }

        private void btnKasaCikisHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmKasaCikisHareket fr = new Formlar.Kasa.FrmKasaCikisHareket();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnRaporSihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Raporlar.FrmRapor fr =new Formlar.Raporlar.FrmRapor();
            fr.Show();
        }

        private void btnMarketHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmMarketHareketi fr = new Formlar.Kasa.FrmMarketHareketi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniResepsiyonGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
