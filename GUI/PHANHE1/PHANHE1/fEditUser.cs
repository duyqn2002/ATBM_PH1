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
    public partial class fEditUser : Form
    {
        string username;
        string newpass;
        public fEditUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text.Trim().ToString().ToUpper();
            newpass  = tbPass.Text.Trim().ToString();

            if (Function.isUserValid(username) == 0)
            {
                MessageBox.Show("User khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Function.RunSQL(sql);

            sql = "alter user " + username + " IDENTIFIED BY " + newpass;

            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Doi mat khau thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doi mat khau that bai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
