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
    public partial class formQuanLyTaiKhoan : Form
    {
        public formQuanLyTaiKhoan()
        {
            InitializeComponent();

        }

        DataTranferObject dto = new DataTranferObject();


        private void formQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadUserIdCombo();
            userPermission.Enabled = false;
            panelCN.Enabled = false;
            comboBoxRole.SelectedIndex = 0;
            //comboBoxGioiTinh.SelectedIndex = 0;
            setInforUser();
            loadListTaiKhoan();
        }

        private void loadUserIdCombo()
        {
            DataTable dtb = BusinessLogicLayer.Instance.setUserDataTable();
            userIdCombo.DataSource = dtb;
            userIdCombo.DisplayMember = "tentaikhoan";
            userIdCombo.ValueMember = "tentaikhoan";
        }
        //quyền thay đổi ứng với tài khoản

        //load bảng thông tin tài khoản
        public void setInforUser()
        {
            DataTable tableUser = BusinessLogicLayer.Instance.getTableTaiKhoan(userIdCombo.SelectedValue.ToString());

            if (tableUser.Rows.Count > 0)
            {
                DataRow item = tableUser.Rows[0];
                tbTenTK.Text = item["tentaikhoan"].ToString();
                tbHoTen.Text = item["hoten"].ToString();
                tbQuyenHan.Text = item["quyen"].ToString();
                tbMK.Text = item["matkhau"].ToString();
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            panelCN.Enabled = true;
        }
        //check tồn tại user nếu tồn tại thì không cho đăng ký
        public bool isExsitUser(string userName)
        {
            return BusinessLogicLayer.Instance.isExistUserAccount(userName);
        }
        //cập nhật quyền và set mật khẩu

        //hiển thị danh sách tài khoản
        public void loadListTaiKhoan()
        {
            DataTable dtb = BusinessLogicLayer.Instance.getUserAccount();
            dataGridViewListTK.DataSource = dtb;
        }

        private void userIdCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            string userSelected = BusinessLogicLayer.Instance.getUserPermision(userIdCombo.SelectedValue.ToString());
            userPermission.Text = userSelected;
            setInforUser();
        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            panelCN.Enabled = true;
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            dto.Tentaikhoan = userIdCombo.SelectedValue.ToString();
            dto.Matkhau = tBMKChange.Text.Trim().ToString();
            string roleNV = "Nhân viên";
            string roleQT = "Quản trị";
            if (isExsitUser(dto.Tentaikhoan))
            {
                if (radioButtonQuanTri.Checked)
                {
                    BusinessLogicLayer.Instance.upDateUser(dto.Tentaikhoan, dto.Matkhau, roleQT);
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelCN.Enabled = true;
                    tBMKChange.Text = "";
                    userIdCombo_SelectedValueChanged(sender, e);
                    setInforUser();
                }
                if (radioButtonNV.Checked)
                {
                    BusinessLogicLayer.Instance.upDateUser(dto.Tentaikhoan, dto.Matkhau, roleNV);
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelCN.Enabled = true;
                    tBMKChange.Text = " ";
                    userIdCombo_SelectedValueChanged(sender, e);
                    setInforUser();
                }
            }
            else
            {
                MessageBox.Show("Nhân viên này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool isRegister(string userName, string hoten, string matkhau, string quyen)
        {
            return BusinessLogicLayer.Instance.isRegister(userName, matkhau, quyen, hoten);
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            dto.Tentaikhoan = tbTKDK.Text.Trim().ToString();
            dto.Matkhau = tbMKDK.Text.Trim().ToString();
            dto.Hoten = textBoxHoTen.Text.ToString();
            dto.Quyen = comboBoxRole.Text.ToString();
            if (isExsitUser(dto.Tentaikhoan))
            {
                MessageBox.Show("Tài khoản này đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                isRegister(dto.Tentaikhoan, dto.Hoten, dto.Matkhau, dto.Quyen);
                loadListTaiKhoan();
                MessageBox.Show("Đăng ký thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dto.Tentaikhoan = tkEdit.Text.Trim().ToString();
            dto.Hoten = hoTenEdit.Text.ToString();
            dto.Matkhau = mkedit.Text.ToString();
            dto.Quyen = quyenEdit.Text.ToString();
            if(tkEdit.Text == "")
            {
                MessageBox.Show("Bạn phải điền tên tài khoản cần sửa");
            }
            else if(hoTenEdit.Text == "" || mkedit.Text =="" || quyenEdit.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin");
            }
            else
            {
                BusinessLogicLayer.Instance.upDateAccount(dto.Tentaikhoan, dto.Hoten, dto.Matkhau, dto.Quyen);
                loadListTaiKhoan();
                hoTenEdit.Text = "";
                mkedit.Text ="";
                quyenEdit.Text = "";
                tkEdit.ResetText();
                MessageBox.Show("Chỉnh sủa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dto.Tentaikhoan = tkEdit.Text.Trim().ToString();
            if(tkEdit.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản cần xóa");
            }
          else if (isExsitUser(dto.Tentaikhoan))
            {
                
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa:", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Cancel)
                {

                    return;
                }
                else 
                {
                    BusinessLogicLayer.Instance.delteteAccount(dto.Tentaikhoan);
                    MessageBox.Show("Xóa thành công tài khoản: " + dto.Tentaikhoan);
                    loadListTaiKhoan();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản này không tồn tại");
            }
        }
    }
}
