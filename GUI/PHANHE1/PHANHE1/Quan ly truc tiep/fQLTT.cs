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

namespace PHANHE1.Quan_ly_truc_tiep
{
    public partial class fQLTT : Form
    {
        Thread t;
        public fQLTT()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fQLTT_EditInfo f = new fQLTT_EditInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            fQLTT_ViewInfo f = new fQLTT_ViewInfo();
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
