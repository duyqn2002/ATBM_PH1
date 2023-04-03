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
    public partial class fShowUser : Form
    {
        DataTable dtTableName = new DataTable();
        public fShowUser()
        {
            InitializeComponent();
        }

        private void LoadData_ListUsers()
        {
            string sql = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, CREATED  FROM dba_users WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            dtTableName = Function.GetDataToTable(sql);
            dgvUser.DataSource = dtTableName;
            // set Font cho tên cột
            dgvUser.Font = new Font("Time New Roman", 13);
            dgvUser.Columns[0].HeaderText = "USERNAME";
            dgvUser.Columns[1].HeaderText = "USER_ID";
            dgvUser.Columns[2].HeaderText = "ACOUNT STATUS";
            dgvUser.Columns[3].HeaderText = "CREATED";

            // set Font cho dữ liệu hiển thị trong cột
            dgvUser.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgvUser.Columns[0].Width = 200;
            dgvUser.Columns[1].Width = 150;
            dgvUser.Columns[2].Width = 200;
            dgvUser.Columns[3].Width = 250;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvUser.AllowUserToAddRows = false;
            dgvUser.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Form_ShowUsers_Load(object sender, EventArgs e)
        {
            LoadData_ListUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ShowUsers_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
