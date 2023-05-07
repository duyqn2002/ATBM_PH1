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

namespace PHANHE1.TruongPhong
{
    public partial class fTruongPhong : Form
    {
        Thread t;
        public fTruongPhong()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            fTP_ViewInfo f = new fTP_ViewInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fTP_EditInfo f = new fTP_EditInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEditPC_Click(object sender, EventArgs e)
        {
            fTP_EditPC f = new fTP_EditPC();
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
