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
using DAL;
namespace PMQLKS
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
             panelTruot .Height = pictureBox1.Height;
        }

        private formLogin fmLg = new formLogin();
        private string userName;
        private string password;
        public formMain(string userName = null, string password = null)
        {
            InitializeComponent();
            panelTruot.Height = btnShowFormNV.Height;
            this.userName = userName;
            this.password = password;

        }
        //set quyền nếu là nhân viên thì không cho sử dụng quản lý nhân viên và quản lý tài khoản
        private void getCurrentUserPermision()
        {
            btnShowFormNV.Enabled = false;
            btnShowFormTK.Enabled = false;
            btnThongKe.Enabled = false;
            //btnShowFormNV.Visible = false;
            //btnShowFormTK.Visible = false;
        }

        //set quyen


        private void formMain_Load(object sender, EventArgs e)
        {
            labelTitle.Text = "Home";
           
            string currentPermission = fmLg.getPermission(userName, password);
            if (currentPermission == "Nhân viên")
            {
                getCurrentUserPermision();
            }
          
            string tenNV = BusinessLogicLayer.Instance.getTenNhanVien(userName);
            labelQuyenHan.Text = currentPermission;
            labelName.Text = tenNV;
            showChildrenForm(new formHome());
            panelTruot.Visible = false;
            buttonDatPhong.Enabled = false;
        }

        private Form activeForm = null;
        //show các form con
        private void showChildrenForm(Form childernForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childernForm;
            childernForm.TopLevel = false;
            childernForm.FormBorderStyle = FormBorderStyle.None;
            childernForm.Dock = DockStyle.Fill;
            panelHienThiChucNang.Controls.Add(childernForm);
            panelHienThiChucNang.Tag = childernForm;
            panelHienThiChucNang.BringToFront();
            childernForm.Show();
        }

        private void btnShowFormKH_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = btnShowFormKH.Height;
            panelTruot.Top = btnShowFormKH.Top;
            showChildrenForm(new formQuanLyKhachHang());
            labelTitle.Text = "Quản lý khách hàng";
        }

        private void btnShowFormPhong_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = btnShowFormPhong.Height;
            panelTruot.Top = btnShowFormPhong.Top;
            showChildrenForm(new formQuanLyPhong());
            labelTitle.Text = "Quản lý phòng";
            buttonDatPhong.Enabled = true;
        }

        private void btnShowFormDV_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = btnShowFormDV.Height;
            panelTruot.Top = btnShowFormDV.Top;
            showChildrenForm(new formQuanLyDichVu());
            labelTitle.Text = "Quản lý dịch vụ";
        }

        private void btnShowFormHD_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = btnShowFormHD.Height;
            panelTruot.Top = btnShowFormHD.Top;
            showChildrenForm(new formQuanLyHoaDon());
            labelTitle.Text = "Quản lý hóa đơn";
        }

        private void btnShowFormNV_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = btnShowFormNV.Height;
            panelTruot.Top = btnShowFormNV.Top;
            showChildrenForm(new formQuanLyNhanVien());
            labelTitle.Text = "Quản lý nhân viên";
        }

        private void btnShowFormTK_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = btnShowFormTK.Height;
            panelTruot.Top = btnShowFormTK.Top;
            showChildrenForm(new formQuanLyTaiKhoan());
            labelTitle.Text = "Quản lý tài khoản";
        }

       


        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            panelTruot.Height = buttonDatPhong.Height;
            panelTruot.Top = buttonDatPhong.Top;
            showChildrenForm(new datPhong());
            labelTitle.Text = "Đặt phòng";
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            panelTruot.Visible = true;
            panelTruot.Height = buttonDangXuat.Height;
            panelTruot.Top = buttonDangXuat.Top;
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel)
            {

                return;
            }
            else if (dr == DialogResult.OK)
            {
                formLogin fm = new formLogin();
                fm.Show();
                this.Hide();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panelTruot.Height = btnThongKe.Height;
            panelTruot.Top = btnThongKe.Top;
            showChildrenForm(new FormThongke());
            labelTitle.Text = "Báo cáo thống kê";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showChildrenForm(new formHome());
            panelTruot.Height = pictureBox1.Height;
            panelTruot.Top = pictureBox1.Top;
            panelTruot.Visible = false;
            labelTitle.Text = "Home";
            formMain_Load(sender, e);
        }
    }
}
