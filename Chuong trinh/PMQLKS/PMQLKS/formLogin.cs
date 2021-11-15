using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PMQLKS
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        DataTranferObject nv = new DataTranferObject();
        private void formLogin_Load(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbMatKhau.Text = "123456";
        }



        private void tbUserName_MouseLeave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Tài khoản";
                tbUserName.ForeColor = Color.Gray;
            }
        }

        private void tbUserName_MouseEnter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Tài khoản")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Blue;
            }
        }

        private void tbMatKhau_MouseEnter(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "Mật khẩu")
            {
                tbMatKhau.Text = "";
                tbMatKhau.ForeColor = Color.Blue;
            }

        }

      
        public bool isLogin(string manv, string password)
        {
            return BusinessLogicLayer.Instance.Login(manv, password);
        }


        public string getPermission(string maNv, string password)
        {
            return BusinessLogicLayer.Instance.getUserIDPermision(maNv, password);
        }

        private void checkBoxShowOrHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowOrHide.Checked)
            {
                tbMatKhau.UseSystemPasswordChar = false;
                checkBoxShowOrHide.Text = "Hide";
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
                checkBoxShowOrHide.Text = "Show";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nv.Tentaikhoan = tbUserName.Text.Trim();
            nv.Matkhau= tbMatKhau.Text.Trim();
            //getPermission(maNV, password);
            string tenNV = BusinessLogicLayer.Instance.getTenNhanVien(nv.Tentaikhoan);
            if (nv.Tentaikhoan == "" || nv.Matkhau == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu hoặc password");
            }

            else if (isLogin(nv.Tentaikhoan, nv.Matkhau))
            {
                MessageBox.Show("Xin chào" + " " + tenNV, "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formMain fm = new formMain(nv.Tentaikhoan, nv.Matkhau);
                fm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}

