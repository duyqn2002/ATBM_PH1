using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1.TaiChinh
{
    public partial class fTC_EditNV : Form
    {
        DataTable dtb = new DataTable();
        string val;
        string nv;
        List<string> tableList;
        int table;
        public fTC_EditNV()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() { "LUONG", "PHUCAP" };
            foreach (string roles in tableList)
            {
                comboBox1.Items.Add(roles);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            table = comboBox1.SelectedIndex;
            val = tbVal.Text.Trim().ToString().ToUpper();
            nv = tbNV.Text.Trim().ToString().ToUpper();
            if (table == 0)
            {
                sql = "UPDATE U_AD.TC_UPDATE_NHANVIEN SET LUONG = "+val+ " WHERE MANV = '"+nv+"'";
            }
            else
            {
                sql = "UPDATE U_AD.TC_UPDATE_NHANVIEN SET PHUCAP = " + val + " WHERE MANV = '" + nv + "'";
            }

            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Update thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
