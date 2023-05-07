using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1.TruongDeAn
{
    public partial class fEditDA : Form
    {
        string iDA;
        string uDA;
        int uAttr;
        string uVal;
        string dDA;
        List<string> tableList;
        public fEditDA()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            iDA = tbiDA.Text.Trim().ToString().ToUpper();
            string sql = "INSERT INTO U_AD.DEAN(MADA) VALUES ('" + iDA + "')";
            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Insert thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() { "TENDA", "PHONG","NGAYBATDAU" };
            foreach (string roles in tableList)
            {
                cbAttr.Items.Add(roles);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uAttr = cbAttr.SelectedIndex;
            uDA = tbuDA.Text.Trim().ToString().ToUpper();
            uVal = tbuVal.Text.Trim().ToString().ToUpper();
            string sql;
            if (uAttr == 0)
            {
                sql = "UPDATE U_AD.DEAN SET TENDA = '" + uVal + "' WHERE MADA = '" + uDA + "'";
            }
            else if (uAttr == 1)
            {
                sql = "UPDATE U_AD.DEAN SET PHONG = '" + uVal + "' WHERE MADA = '" + uDA + "'";
            }
            else
            {
                sql = "UPDATE U_AD.DEAN SET NGAYBD = TO_DATE('" + uVal + "','MM/DD/YY') WHERE MADA = '" + uDA + "'";
            }

            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Update thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dDA = tbDel.Text.Trim().ToString().ToUpper();
            string sql = "DELETE FROM U_AD.DEAN WHERE MADA = '" + dDA + "'";
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
