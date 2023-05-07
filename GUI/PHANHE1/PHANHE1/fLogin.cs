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
        String qltt = "QL";
        String truongphong = "TP";
        String taichinh = "TC";
        String nhansu = "NS";
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

        public void open_NV(object obj)
        {
            Application.Run(new NhanVien.fNhanVien());
        }

        public void open_QLTT(object obj)
        {
            Application.Run(new Quan_ly_truc_tiep.fQLTT());
        }

        public void open_TP(object obj)
        {
            Application.Run(new TruongPhong.fTruongPhong());
        }

        public void open_TC(object obj)
        {
            Application.Run(new TaiChinh.fTaiChinh());
        }

        public void open_NS(object obj)
        {
            Application.Run(new NhanSu.fNhanSu());
        }

        public void open_TDA(object obj)
        {
            Application.Run(new TruongDeAn.fTruongDeAn());
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
            else if (username.Contains(nhanvien))
            {
                this.Close();
                t = new Thread(open_NV);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else if (username.Contains(qltt))
            {
                this.Close();
                t = new Thread(open_QLTT);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else if (username.Contains(truongphong))
            {
                this.Close();
                t = new Thread(open_TP);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else if (username.Contains(taichinh))
            {
                this.Close();
                t = new Thread(open_TC);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else if (username.Contains(nhansu))
            {
                this.Close();
                t = new Thread(open_NS);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else if (username.Contains(tda))
            {
                this.Close();
                t = new Thread(open_TDA);
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
