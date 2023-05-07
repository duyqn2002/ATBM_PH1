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
    public partial class fNS_EditNV : Form
    {
        string iMaNV;
        string uMaNV;
        string uVal;
        List<string> tableList;
        int attr;
        public fNS_EditNV()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            iMaNV = tbiNV.Text.Trim().ToString().ToUpper();
            string sql = "INSERT INTO U_AD.NS_UPDATE_NHANVIEN (MANV,USERNAME) VALUES('" + iMaNV + "','"+iMaNV+"')";

            if (Function.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Insert thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Fill_comboBox()
        {
            tableList = new List<string>() { "TENNV", "PHAI", "DIACHI", "SODT", "VAITRO", "MANQL", "PHG", "NGAYSINH" };
            foreach (string roles in tableList)
            {
                comboBox1.Items.Add(roles);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            attr = comboBox1.SelectedIndex;
            uVal = tbuVal.Text.Trim().ToString().ToUpper();
            uMaNV = tbuNV.Text.Trim().ToString().ToUpper();
            string sql;

            if(attr == 0)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET TENNV = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else if (attr == 1)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET PHAI = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else if(attr == 2)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET DIACHI = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else if (attr == 3)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET SODT = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else if (attr == 4)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET VAITRO = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else if (attr == 5)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET MANQL = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else if (attr == 6)
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET PHG = '" + uVal + "' WHERE MANV='" + uMaNV + "'";
            }
            else
            {
                sql = "UPDATE U_AD.NS_UPDATE_NHANVIEN SET NGAYSINH = TO_DATE('" + uVal + "','MM/DD/YY') WHERE MANV='" + uMaNV + "'";
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
