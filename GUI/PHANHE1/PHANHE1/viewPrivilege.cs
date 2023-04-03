using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class viewPrivilege : Form
    {
        DataTable dtTableName = new DataTable();
        String name;
        public viewPrivilege()
        {
            InitializeComponent();
        }

        private void LoadData_CheckPrivilegeOnTable()
        {
            name = txtPri.Text.Trim().ToString().ToUpper();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + name + "'" + " AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            dtTableName = Function.GetDataToTable(sql);
            dgvPri.DataSource = dtTableName;
            // set Font cho tên cột
            dgvPri.Font = new Font("Time New Roman", 13);
            dgvPri.Columns[0].HeaderText = "GRANTEE";
            dgvPri.Columns[1].HeaderText = "OWNER";
            dgvPri.Columns[2].HeaderText = "TABLE_NAME";
            dgvPri.Columns[3].HeaderText = "GRATOR STATUS";
            dgvPri.Columns[4].HeaderText = "GRANTALE";
            dgvPri.Columns[5].HeaderText = "HIERARCHY";
            dgvPri.Columns[6].HeaderText = "COMMON";
            dgvPri.Columns[7].HeaderText = "TYPE";
            dgvPri.Columns[8].HeaderText = "INHERITED";

            // set Font cho dữ liệu hiển thị trong cột
            dgvPri.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgvPri.Columns[0].Width = 150;
            dgvPri.Columns[1].Width = 150;
            dgvPri.Columns[2].Width = 250;
            dgvPri.Columns[3].Width = 150;
            dgvPri.Columns[4].Width = 150;
            dgvPri.Columns[5].Width = 150;
            dgvPri.Columns[6].Width = 150;
            dgvPri.Columns[7].Width = 150;
            dgvPri.Columns[8].Width = 150;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvPri.AllowUserToAddRows = false;
            dgvPri.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadData_CheckPrivilegeOnView()
        {
            name = txtPri.Text.Trim().ToString().ToUpper();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + name + "'" + " AND TYPE = 'VIEW' ORDER BY TABLE_NAME";
            dtTableName = Function.GetDataToTable(sql);
            dgvPri.DataSource = dtTableName;
            // set Font cho tên cột
            dgvPri.Font = new Font("Time New Roman", 13);
            dgvPri.Columns[0].HeaderText = "GRANTEE";
            dgvPri.Columns[1].HeaderText = "OWNER";
            dgvPri.Columns[2].HeaderText = "TABLE_NAME";
            dgvPri.Columns[3].HeaderText = "GRATOR STATUS";
            dgvPri.Columns[4].HeaderText = "GRANTALE";
            dgvPri.Columns[5].HeaderText = "HIERARCHY";
            dgvPri.Columns[6].HeaderText = "COMMON";
            dgvPri.Columns[7].HeaderText = "TYPE";
            dgvPri.Columns[8].HeaderText = "INHERITED";

            // set Font cho dữ liệu hiển thị trong cột
            dgvPri.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgvPri.Columns[0].Width = 150;
            dgvPri.Columns[1].Width = 150;
            dgvPri.Columns[2].Width = 250;
            dgvPri.Columns[3].Width = 150;
            dgvPri.Columns[4].Width = 150;
            dgvPri.Columns[5].Width = 150;
            dgvPri.Columns[6].Width = 150;
            dgvPri.Columns[7].Width = 150;
            dgvPri.Columns[8].Width = 150;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvPri.AllowUserToAddRows = false;
            dgvPri.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData_CheckPrivilegeOnTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData_CheckPrivilegeOnView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
