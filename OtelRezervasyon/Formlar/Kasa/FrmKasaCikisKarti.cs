using DevExpress.XtraEditors;
using OtelRezervasyon.Entity;
using OtelRezervasyon.Repositories;
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
    public partial class FrmKasaCikisKarti : Form
    {
        public FrmKasaCikisKarti()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();
        Repository<TblKasaCikisHareketi> repo = new Repository<TblKasaCikisHareketi>();
        TblKasaCikisHareketi t = new TblKasaCikisHareketi();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            t.Aciklama = memoEditAciklama.Text;
            t.Tarih=DateTime.Parse(dateEditTarih.Text);
            t.Tutar=decimal.Parse(textEditTutar.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Çıkış Hareketi Sisteme Başarıyla kaydedildi");
        }
    }
}
