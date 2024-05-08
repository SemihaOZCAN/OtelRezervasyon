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

namespace OtelRezervasyon.Formlar.Personel
{
    public partial class FrmPersonelListe : Form
    {
        public FrmPersonelListe()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        //listeleme işlemi
        private void FrmPersonelListe_Load(object sender, EventArgs e)
        {
           gridControl1.DataSource = (from x in db.TblPersonel
                            select new
                            {
                                x.PersonelID,
                                x.AdSoyad,
                                x.TC,
                                x.Telefon,
                                x.Mail,
                                x.TblDepartman.DepartmanAD,
                                x.TblGorev.GorevAD,
                                x.TblDurum.DurumAD

                            }).ToList();
        }


        //tıklama işlemi ile form gelmesi
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmPersonelKart fr = new FrmPersonelKart();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("PersonelID").ToString());
            fr.Show();
        }
    }
}
