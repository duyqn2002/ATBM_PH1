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
    public partial class fGrantPri : Form
    {
        DataTable dtTableName = new DataTable();
        string usernameView;
        string usernameGrant;
        string pri;
        string table;
        List<string> priList;
        List<string> tableList;
        public fGrantPri()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            priList = new List<string>() { "SELECT","INSERT","UPDATE","DELETE" };
            tableList = new List<string>() { "NHANVIEN", "PHONGBAN", "DEAN", "PHANCONG"};
            foreach (string roles in priList)
            {
                cboPri.Items.Add(roles);
            }

            foreach (string roles in tableList)
            {
                cboTable.Items.Add(roles);
            }
        }

        private void LoadData_ListUsers()
        {
            usernameView = tbUserRole.Text.Trim().ToUpper();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '"+usernameView+"' AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            dtTableName = Function.GetDataToTable(sql);
            dgvPri.DataSource = dtTableName;
        }

        private void btnFindPri_Click(object sender, EventArgs e)
        {
            LoadData_ListUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            usernameGrant = tbUserRoleGrant.Text.Trim().ToUpper();
            if (usernameGrant.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(Function.isUserValid(usernameGrant) == 0 && Function.isRoleValid(usernameGrant) == 0)
            {
                MessageBox.Show("User/Role không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Function.RunSQL(sql);

            pri = cboPri.SelectedItem.ToString();
            table = cboTable.SelectedItem.ToString();

            sql = "GRANT "+pri+" ON "+table+" TO "+usernameGrant;
            Function.RunSQL(sql);

            MessageBox.Show("Grant thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
