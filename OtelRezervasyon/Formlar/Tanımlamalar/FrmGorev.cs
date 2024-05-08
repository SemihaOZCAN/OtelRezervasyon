using DevExpress.XtraEditors;
using OtelRezervasyon.Entity;
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

namespace OtelRezervasyon.Formlar.Tanımlamalar
{
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();



        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorev.Load();
            bindingSource1.DataSource = db.TblGorev.Local;

            repositoryItemLookUpEditDepartman.DataSource = (from x in db.TblDepartman
                                                            select new
                                                            {
                                                                x.DepartmanID,
                                                                x.DepartmanAD
                                                            }).ToList();


            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurum
                                                            select new
                                                            {
                                                                x.DurumID,
                                                                x.DurumAD
                                                            }).ToList();
                                                          
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Bilgiler Kaydedilirken Hata Oluştu Lütfen Tekrar Deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
