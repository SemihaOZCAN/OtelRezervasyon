using DevExpress.XtraEditors;
using OtelRezervasyon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.Formlar.Admin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbOtelRezervasyonEntities3 db=new DbOtelRezervasyonEntities3();

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            var kullanici=db.TblAdmin.Where(x=>x.Kullanici==textEditKullaniciAdi.Text && x.Sifre==textEditSifre.Text).FirstOrDefault();
            if (kullanici !=null)
            {
                Form1 frm =new Form1();
                frm.kullaniciRolu = kullanici.Rol;
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifreniz yanlış, Tekrar Deneyiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
        }
    }
}
