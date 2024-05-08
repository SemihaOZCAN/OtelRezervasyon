using System;
using System.Data.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelRezervasyon.Entity;

namespace OtelRezervasyon.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

       

        private void FrmDurum_Load(object sender, EventArgs e)
        {

            db.TblDurum.Load();
            bindingSource1.DataSource = db.TblDurum.Local;


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

             XtraMessageBox.Show("Lütfen Değerleri Kontrol Edip Yeniden Giriş Yapın!", "Uyarı", MessageBoxButtons.OK ,MessageBoxIcon.Warning);

            }
           
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
