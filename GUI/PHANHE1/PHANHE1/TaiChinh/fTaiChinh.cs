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

namespace PHANHE1.TaiChinh
{
    public partial class fTaiChinh : Form
    {
        Thread t;
        public fTaiChinh()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            fTC_ViewInfo f = new fTC_ViewInfo();
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

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            fTC_EditNV f = new fTC_EditNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
    }
}
