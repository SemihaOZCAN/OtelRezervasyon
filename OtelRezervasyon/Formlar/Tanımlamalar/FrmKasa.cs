using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyon.Entity;


namespace OtelRezervasyon.Formlar.Tanımlamalar
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();


        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            db.TblKasa.Load();
            bindingSource1.DataSource = db.TblKasa.Local;

            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumID,
                                                            x.DurumAD

                                                        }).ToList();

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }


    }
}
