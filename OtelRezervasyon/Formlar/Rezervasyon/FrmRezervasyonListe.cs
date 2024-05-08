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

namespace OtelRezervasyon.Formlar.Rezervasyon
{
    public partial class FrmRezervasyonListe : Form
    {
        public FrmRezervasyonListe()
        {
            InitializeComponent();
        }

        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        //listeleme işlemi
        private void FrmRezervasyonListe_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblRezervasyon
                                       select new
                                       {
                                           x.RezervasyonID,
                                           x.TblMisafir.AdSoyad,
                                           x.GirişTarih,
                                           x.CikisTarih,
                                           x.Kisi,
                                           x.TblOda.OdaNo,
                                           x.Telefon,
                                           x.TblDurum.DurumAD
                                       }).ToList();
        }

        //tıklama işlemi ile form gelmesi
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmRezervasyonKartı fr = new FrmRezervasyonKartı();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("RezervasyonID").ToString());
            fr.Show();
        }

        
    }
}
