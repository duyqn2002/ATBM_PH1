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
    public partial class fViewInfo : Form
    {
        DataTable dtTableName = new DataTable();
        List<string> catg;
        int cate;
        public fViewInfo()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            catg = new List<string>() { "Table","View","Role","User"};
            foreach (string roles in catg)
            {
                cboCatg.Items.Add(roles);
            }

        }

        private void loadTable()
        {
            string sql = "SELECT * FROM ALL_TABLES WHERE owner = 'U_AD'";
            dtTableName = Function.GetDataToTable(sql);
            dgvView.DataSource = dtTableName;

            // set Font cho tên cột
            dgvView.Font = new Font("Time New Roman", 13);

            // set Font cho dữ liệu hiển thị trong cột
            dgvView.DefaultCellStyle.Font = new Font("Time New Roman", 12);


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvView.AllowUserToAddRows = false;
            dgvView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loadView()
        {
            string sql = "SELECT * FROM user_views";
            dtTableName = Function.GetDataToTable(sql);
            dgvView.DataSource = dtTableName;

            // set Font cho tên cột
            dgvView.Font = new Font("Time New Roman", 13);


            // set Font cho dữ liệu hiển thị trong cột
            dgvView.DefaultCellStyle.Font = new Font("Time New Roman", 12);


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvView.AllowUserToAddRows = false;
            dgvView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loadRole()
        {
            string sql = "SELECT * FROM DBA_ROLES where role like '%ROLE_%'";
            dtTableName = Function.GetDataToTable(sql);
            dgvView.DataSource = dtTableName;

            // set Font cho tên cột
            dgvView.Font = new Font("Time New Roman", 13);


            // set Font cho dữ liệu hiển thị trong cột
            dgvView.DefaultCellStyle.Font = new Font("Time New Roman", 12);


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvView.AllowUserToAddRows = false;
            dgvView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loadUser()
        {
            string sql = "SELECT * FROM all_users";
            dtTableName = Function.GetDataToTable(sql);
            dgvView.DataSource = dtTableName;

            // set Font cho tên cột
            dgvView.Font = new Font("Time New Roman", 13);


            // set Font cho dữ liệu hiển thị trong cột
            dgvView.DefaultCellStyle.Font = new Font("Time New Roman", 12);


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgvView.AllowUserToAddRows = false;
            dgvView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            cate = cboCatg.SelectedIndex + 1;
            if(cate == 1)
            {
                loadTable();
            }
            else if (cate == 2)
            {
                loadView();
            }
            else if (cate == 3)
            {
                loadRole();
            }
            else if (cate == 4)
            {
                loadUser();
            };

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
