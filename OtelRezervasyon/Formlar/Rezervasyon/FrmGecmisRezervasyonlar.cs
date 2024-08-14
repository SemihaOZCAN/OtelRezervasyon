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
    public partial class FrmGecmisRezervasyonlar : Form
    {
        public FrmGecmisRezervasyonlar()
        {
            InitializeComponent();
        }

        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        // Gecmiş Rezervasyon listeleme işlemi 
        private void FrmGecmisRezervasyonlar_Load(object sender, EventArgs e)
        {
            var data = (from x in db.TblRezervasyon
                        where x.TblDurum.DurumAD == "Çıkış Yapıldı."
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

            if (data.Any())
            {
                gridControl1.DataSource = data;
            }
            else
            {
                MessageBox.Show("Çıkış Yapıldı durumunda rezervasyon bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
