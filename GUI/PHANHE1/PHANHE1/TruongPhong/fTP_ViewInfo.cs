using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1.TruongPhong
{
    public partial class fTP_ViewInfo : Form
    {
        DataTable dtb = new DataTable();
        List<string> tableList;
        int table;
        public fTP_ViewInfo()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() { "NHANVIEN", "PHANCONG", "PHONGBAN", "DEAN" };
            foreach (string roles in tableList)
            {
                comboBox1.Items.Add(roles);
            }

        }

        private void LoadData_ListUsers()
        {
            table = comboBox1.SelectedIndex;
            string sql;
            if (table == 0)
            {
                sql = "select * from U_AD.TP_SELECT_NHANVIEN";
            }
            else if (table == 1)
            {
                sql = "select * from U_AD.TP_UPDATE_PHANCONG";
            }
            else if (table == 2)
            {
                sql = "select * from U_AD.PHONGBAN";
            }
            else
            {
                sql = "select * from U_AD.DEAN";
            }
            dtb = Function.GetDataToTable(sql);
            dgvShow.DataSource = dtb;
            // set Font cho tên cột
            dgvShow.Font = new Font("Time New Roman", 13);
            dgvShow.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dgvShow.AllowUserToAddRows = false;
            dgvShow.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData_ListUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
