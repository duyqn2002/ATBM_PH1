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
    public partial class fDeleteUser : Form
    {
        string username;
        public fDeleteUser()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text.Trim().ToString().ToUpper();
            if (Function.isUserValid(username) == 0)
            {
                MessageBox.Show("User khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Function.RunSQL(sql);
            username = tbUsername.Text.Trim().ToString();

            if (cbCascade.Checked == true)
                sql = "DROP USER " + username + " CASCADE";
            else
                sql = "DROP USER " + username;

            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Xoa User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
