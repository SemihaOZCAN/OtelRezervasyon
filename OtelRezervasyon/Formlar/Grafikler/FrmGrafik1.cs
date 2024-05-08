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

namespace OtelRezervasyon.Formlar.Grafikler
{
    public partial class FrmGrafik1 : Form
    {
        public FrmGrafik1()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        private void FrmGrafik1_Load(object sender, EventArgs e)
        {
            //Urun-Stok Grafiği
            var urunler = db.TblUrun.ToList();
            foreach (var x in urunler)
            {
                chartControl1.Series["Urun-Stok"].Points.AddPoint(x.UrunAD, double.Parse(x.Toplam.ToString()));
            }
        }
    }
}
