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
    public partial class fAddRole : Form
    {
        string name;
        public fAddRole()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            name = tbRole.Text.Trim().ToString().ToUpper();
            if (Function.isRoleValid(name) == 1 || Function.isUserValid(name) == 1)
            {
                MessageBox.Show("Ten role da duoc su dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Function.RunSQL(sql);
            name = tbRole.Text.Trim().ToString();
            sql = "CREATE ROLE " + name;

            if (Function.RunSQLwithResult(sql) == 1)
            {
                //sql = "grant create role to " + name + " container=all";
                // Functions.RunSQL(sql);
                MessageBox.Show("Them Role thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
