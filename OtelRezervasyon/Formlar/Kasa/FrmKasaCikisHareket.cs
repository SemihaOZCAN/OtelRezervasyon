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

namespace OtelRezervasyon.Formlar.Kasa
{
    public partial class FrmKasaCikisHareket : Form
    {

        
        public FrmKasaCikisHareket()
        {
            InitializeComponent();
        }

        DbOtelRezervasyonEntities3 db=new DbOtelRezervasyonEntities3();
        private void FrmKasaCikisHareket_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TblKasaCikisHareketi 
                                     select new
                                     {
                                         x.Aciklama,
                                         x.Tarih,
                                         x.Tutar

                                     }
                                     ).ToList();
        }
    }
}
