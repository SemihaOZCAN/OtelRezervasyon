using OtelRezervasyon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.Formlar.AnaForm
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();


        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            //misafir listesi
            gridControl3.DataSource = (from x in db.TblMisafir
                                       select new
                                       {
                                           x.AdSoyad
                                       }).ToList();

            //urun isimleri
            gridControl1.DataSource=(from x in db.TblUrun
                                     select new
                                     {
                                         x.UrunAD,
                                         x.Toplam
                                     }).ToList();

            //mesaj gonderen
            gridControl4.DataSource=(from x in db.TbliletisimMesaj
                                     select new
                                     {
                                         x.Gonderen,
                                         x.Mesaj
                                     }).ToList();

            //bugun gelecekler listesi
            gridControl2.DataSource = (from x in db.TblRezervasyon
                                       select new
                                       {
                                           x.TblMisafir.AdSoyad,
                                           x.Durum
                                       }).Where(y => y.Durum == 15).ToList();

            gridView2.Columns["Durum"].Visible = false;

         
           //Urun-Stok Grafiği
           var urunler=db.TblUrun.ToList();
            foreach (var x in urunler)
            {
                chartControl1.Series["Urun-Stok"].Points.AddPoint(x.UrunAD, double.Parse(x.Toplam.ToString()));
            }

            //Oda Doluluk Grafiği
            var durumlar = db.OdaDurum();
            foreach (var x in durumlar)
            {
                chartControl2.Series["Series 1"].Points.AddPoint(x.DurumAD, double.Parse(x.Sayı.ToString()));
            }

            





        }
    }
}
