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
    public partial class fGrantRole : Form
    {
        string username;
        string rolename;
        public fGrantRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = tbUser.Text.Trim().ToString().ToUpper();
            rolename = tbRole.Text.Trim().ToString().ToUpper();

            if (Function.isUserValid(username) == 0 && Function.isRoleValid(username) == 0)
            {
                MessageBox.Show("User/Role khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Function.isRoleValid(rolename) == 0)
            {
                MessageBox.Show("Role khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Function.RunSQL(sql);

            sql = "GRANT " + rolename + " TO " + username;

            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Grant thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Grant that bai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
