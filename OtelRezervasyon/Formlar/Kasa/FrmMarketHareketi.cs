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
    public partial class FrmMarketHareketi : Form
    {
        public FrmMarketHareketi()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        private void FrmMarketHareketi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TblUrun
                                     select new
                                     {
                                         x.UrunAD,
                                         x.Toplam
                                     }).ToList();        

        }
    }
}
