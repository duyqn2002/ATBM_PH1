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

namespace PHANHE1.NhanSu
{
    public partial class fNhanSu : Form
    {
        Thread t;
        public fNhanSu()
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
            fNS_ViewInfo f = new fNS_ViewInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            fNS_EditNV f = new fNS_EditNV();
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

        private void btnPB_Click(object sender, EventArgs e)
        {
            fNS_EditPHGBAN f = new fNS_EditPHGBAN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
