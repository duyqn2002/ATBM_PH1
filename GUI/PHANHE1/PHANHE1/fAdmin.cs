using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            panel1.Height = 40;
        }

        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fShowUser f = new fShowUser();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bntPrivilege_Click(object sender, EventArgs e)
        {
            viewPrivilege f = new viewPrivilege();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            fDeleteUser f = new fDeleteUser();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            fAddRole f = new fAddRole();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bntDelRole_Click(object sender, EventArgs e)
        {
            fDeleteRole f = new fDeleteRole();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            fGrantRole f = new fGrantRole();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            fRevoke f = new fRevoke();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f = new fAddUser();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnFunc1_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 40)
            {
                panel1.Height = 780;
            }
            else
            {
                panel1.Height = 40;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            fEditUser f = new fEditUser();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnGrantPri_Click(object sender, EventArgs e)
        {
            fGrantPri f = new fGrantPri();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            fViewInfo f = new fViewInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnAddTable_Click(object sender, EventArgs e)
        {
            fCreateTable f = new fCreateTable();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
