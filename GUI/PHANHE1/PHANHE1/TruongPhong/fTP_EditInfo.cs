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
    public partial class fTP_EditInfo : Form
    {
        List<string> tableList;
        int attr;
        string value;
        public fTP_EditInfo()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() { "DIACHI", "SDT", "NGAYSINH" };
            foreach (string roles in tableList)
            {
                comboBox1.Items.Add(roles);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            attr = comboBox1.SelectedIndex;
            value = tbVal.Text.Trim().ToString().ToUpper();
            string sql;
            if (attr == 0)
            {
                sql = "update U_AD.NV_UPDATE_NHANVIEN set DIACHI = '" + value + "'";
            }
            else if (attr == 1)
            {
                sql = "update U_AD.NV_UPDATE_NHANVIEN set SODT = '" + value + "'";
            }
            else
            {
                sql = "update U_AD.NV_UPDATE_NHANVIEN set NGAYSINH = '" + value + "'";
            }


            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Update thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
