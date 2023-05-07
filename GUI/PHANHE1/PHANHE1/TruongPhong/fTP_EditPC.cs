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
    public partial class fTP_EditPC : Form
    {
        string iNV;
        string iDA;
        string dNV;
        string dDA;
        string uNV;
        string uDA;
        int uAttr;
        string uVal;
        List<string> tableList;
        int attr;
        string value;
        public fTP_EditPC()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() {"THOIGIAN" };
            foreach (string roles in tableList)
            {
                cbAttr.Items.Add(roles);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            iNV = tbiNV.Text.Trim().ToString().ToUpper();
            iDA = tbiDA.Text.Trim().ToString().ToUpper();

            string sql = "insert into U_AD.TP_UPDATE_PHANCONG values ('"+ iNV+"','"+iDA+"',TO_DATE('11/11/11','MM/DD/YY'))";
            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Insert thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dNV = tbdNV.Text.Trim().ToString().ToUpper();
            dDA = tbdDA.Text.Trim().ToString().ToUpper();
            string sql = "delete from U_AD.TP_UPDATE_PHANCONG where MANV = '"+dNV+"' and MADA='"+dDA+"'";
            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Delete thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uNV = tbuNV.Text.Trim().ToString().ToUpper();
            uDA = tbDA.Text.Trim().ToString().ToUpper();
            uVal = tbuVal.Text.Trim().ToString().ToUpper();
            uAttr = cbAttr.SelectedIndex;

            string sql;
            if (uAttr == 0)
            {
                string final_val = "TO_DATE('"+ uVal+ "','MM/DD/YY')";
                sql = "update U_AD.TP_UPDATE_PHANCONG set THOIGIAN = " + final_val + " WHERE MANV ='" + uNV + "' and MADA = '" + uDA + "'";
                /*MessageBox.Show(sql, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                if (Function.RunSQLwithResult(sql) == 1)
                {
                    MessageBox.Show("Update thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }

        }
    }
}
