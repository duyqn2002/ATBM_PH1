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
    public partial class fRevoke : Form
    {
        string username;
        string rolename;
        public fRevoke()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Trim().Length == 0 | tbRole.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

            if (!rolename.Equals(username))
            {
                sql = "revoke " + rolename + " from " + username;     

                if (Function.RunSQLwithResult(sql) == 1)
                {
                    MessageBox.Show("Revoke thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Revoke that bai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
