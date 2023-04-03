using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1
{
    public partial class fLogin : Form
    {
        Thread t;
        String username = "", password = "";
        String admin = "U_AD";
        String nhanvien = "NV";
        String qltt = "QLTT";
        String truongphong = "TP";
        String taichinh = "TC";
        String nhansu = "ns";
        String tda = "TDA";
        String bgd = "BGD";

        public fLogin()
        {
            InitializeComponent();
        }

        public void open_Admin(object obj)
        {
            Application.Run(new fAdmin());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text.Trim();
            password = tbPassword.Text.Trim();
            Login(username, password);

            if (username.Contains(admin))
            {
                this.Close();
                t = new Thread(open_Admin);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }

        private void Login(String username,String password)
        {
            try
            {

                Function.InitConnection(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
