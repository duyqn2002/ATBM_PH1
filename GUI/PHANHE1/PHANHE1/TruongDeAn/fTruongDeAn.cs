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

namespace PHANHE1.TruongDeAn
{
    public partial class fTruongDeAn : Form
    {
        Thread t;
        public fTruongDeAn()
        {
            InitializeComponent();
        }

        public void open_FormLogin(object obj)
        {
            Application.Run(new fLogin());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormLogin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            NhanVien.fNV_ViewInfo f = new NhanVien.fNV_ViewInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NhanVien.fNV_EditInfo f = new NhanVien.fNV_EditInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEditDA_Click(object sender, EventArgs e)
        {
            fEditDA f = new fEditDA();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
