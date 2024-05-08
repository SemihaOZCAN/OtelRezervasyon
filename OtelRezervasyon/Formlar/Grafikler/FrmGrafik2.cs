using DevExpress.XtraCharts;
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
    public partial class FrmGrafik2 : Form
    {
        public FrmGrafik2()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();
        private void FrmGrafik2_Load(object sender, EventArgs e)
        {
            //Oda Doluluk Grafiği
            var durumlar = db.OdaDurum();
            foreach (var x in durumlar)
            {
                chartControl1.Series["Oda Doluluk"].Points.AddPoint(x.DurumAD, double.Parse(x.Sayı.ToString()));
            }

        }
    }
}
