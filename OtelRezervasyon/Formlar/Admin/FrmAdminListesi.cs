using OtelRezervasyon.Entity;
using OtelRezervasyon.Formlar.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.Formlar.Admin
{
    public partial class FrmAdminListesi : Form
    {
        public FrmAdminListesi()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db=new DbOtelRezervasyonEntities3();


        private void FrmAdminListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=db.TblAdmin.ToList();

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmSifreİslemleri fr = new FrmSifreİslemleri();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
