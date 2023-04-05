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
    public partial class fCreateTable : Form
    {
        string tbNameCreate;
        string tbNameAlter;
        string dataType;
        List<string> dataTypeList;
        string columnName;
        public fCreateTable()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Fill_comboBox()
        {
            dataTypeList = new List<string>() { "NUMBER", "VARCHAR2(45)", "NVARCHAR2(45)", "DATE" };
            foreach (string roles in dataTypeList)
            {
                cbType.Items.Add(roles);
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tbNameCreate = tbTableCreate.Text.Trim().ToString().ToUpper();

            if (Function.isTableValid(tbNameCreate) == 1)
            {
                MessageBox.Show("Table đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "create table " + tbNameCreate + "(t int)";
            Function.RunSQL(sql);
            MessageBox.Show("Tạo Table thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            tbNameAlter = tbTableAlter.Text.Trim().ToString().ToUpper();

            if (Function.isTableValid(tbNameAlter) == 0)
            {
                MessageBox.Show("Table không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataType = cbType.SelectedItem.ToString();
            columnName = tbColumn.Text.Trim().ToString().ToUpper();

            string sql = "ALTER TABLE " + tbNameAlter +  " ADD " + columnName + " " + dataType;

            if (Function.RunSQLwithResult(sql) == 0)
            {
                MessageBox.Show("Thêm thuộc tính thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Thêm thuộc tính thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
