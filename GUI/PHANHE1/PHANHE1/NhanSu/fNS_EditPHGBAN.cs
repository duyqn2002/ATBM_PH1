using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1.NhanSu
{
    public partial class fNS_EditPHGBAN : Form
    {
        string iPB;
        string uPB;
        string uVal;
        string iName;
        string iTP;
        List<string> tableList;
        int attr;
        public fNS_EditPHGBAN()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            iPB = tbiPB.Text.Trim().ToString().ToUpper();
            iName = tbiTenPB.Text.Trim().ToString().ToUpper();
            iTP = tbiTrgP.Text.Trim().ToString().ToUpper();

            string sql = "INSERT INTO U_AD.PHONGBAN(MAPB, TENPB, TRPHG) VALUES ('" + iPB + "','" + iName + "','" + iTP + "')";
            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Insert thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() { "TENPB","TRUONGPHONG" };
            foreach (string roles in tableList)
            {
                comboBox1.Items.Add(roles);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            attr = comboBox1.SelectedIndex;
            uPB = tbuPB.Text.Trim().ToString().ToUpper();
            uVal = tbuVal.Text.Trim().ToString().ToUpper();
            string sql;

            if (attr == 0)
            {
                sql = "UPDATE U_AD.PHONGBAN SET TENPB = '" + uVal + "' WHERE MAPB='" + uPB + "'";
            }
            else
            {
                sql = "UPDATE U_AD.PHONGBAN SET TRPHG = '" + uVal + "' WHERE MAPB='" + uPB + "'";
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
