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
    public partial class fAddUser : Form
    {
        string username;
        string password;
        List<string> vaitroList;
        int vaitro;
        public fAddUser()
        {
            InitializeComponent();
            Fill_comboBox();
        }


        private void Fill_comboBox()
        {
            vaitroList = new List<string>() { "Nhân viên", "QLTT", "Trưởng phòng", "Tài chính", "Nhân sự", "Trưởng đề án", "Ban giám đốc" };
            foreach (string roles in vaitroList)
            {
                cboRole.Items.Add(roles);
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim().Length == 0 ||
                tbPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            username = tbUsername.Text.Trim().ToString().ToUpper();
            if (Function.isUserValid(username) == 1)
            {
                MessageBox.Show("Ten user da duoc su dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Function.RunSQL(sql);
            username = tbUsername.Text.Trim().ToString().ToUpper();
            password = tbPass.Text.Trim().ToString();

            vaitro = cboRole.SelectedIndex + 1;
            string vaitro_str = Convert.ToString(vaitro);

            sql = "CALL createUser('" + username + "','" + password + "'," + vaitro_str  + ")";
            Function.RunSQLwithResult(sql);

            MessageBox.Show("Them User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbUsername.Text = "";
            tbPass.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
