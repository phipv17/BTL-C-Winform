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
    public partial class formQuanLyNhanVien : Form
    {
        public formQuanLyNhanVien()
        {
            InitializeComponent();
        }
        DataTranferObject dto = new DataTranferObject();
        private void formQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadDataGridViewNV();
            reset();
        }

        private void loadDataGridViewNV()
        {
            dataGridViewListNhanVien.DataSource = BusinessLogicLayer.Instance.getNhanVienInfor();
        }

        public void reset()
        {
            textboxMaNV.ResetText();
            textBoxHoTenNV.ResetText();
            comboBoxGioiTinhNV.Text = "";
            dateTimePickerNSNV.Value = DateTime.Today;
            textBoxDiaChiNV.ResetText();
            textBoxSDTNV.ResetText();
            textBoxEmailNV.ResetText();
            textBoxCMNDNV.ResetText();
            textBoxMaCVNV.ResetText();
            loadDataGridViewNV();
         
        }
        private void buttonThemNV_Click_1(object sender, EventArgs e)
        {
            try
            {
                dto.Manv = textboxMaNV.Text.Trim().ToString();
                dto.Macv = textBoxMaCVNV.Text.Trim().ToString();
                dto.Hoten = textBoxHoTenNV.Text.ToString();
                dto.Ngaysinh = dateTimePickerNSNV.Value;
                dto.Gioitinh = comboBoxGioiTinhNV.SelectedItem?.ToString();
                dto.Diachi = textBoxDiaChiNV.Text.ToString();
                dto.Sdt = textBoxSDTNV.Text.ToString();
                dto.Email = textBoxEmailNV.Text.ToString();
                dto.Cmnd = textBoxCMNDNV.Text.ToString();

                // MessageBox.Show(dto.Manv);
                if (textboxMaNV.Text == "" || textBoxMaCVNV.Text == "" || textBoxHoTenNV.Text == "" || comboBoxGioiTinhNV.Text == "" || dateTimePickerNSNV.Value == null || textBoxDiaChiNV.Text == "" || textBoxSDTNV.Text == "" || textBoxEmailNV.Text == "" || textBoxCMNDNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
                }
                else
                {
                    BusinessLogicLayer.Instance.insertNhanvien(dto.Manv, dto.Macv, dto.Hoten, dto.Ngaysinh, dto.Gioitinh, dto.Sdt, dto.Cmnd, dto.Diachi, dto.Email);
                    MessageBox.Show("Thêm nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridViewNV();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm nhân viên"+ "\n" + ex);
            }       
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (textboxMaNV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên cần sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxMaCVNV.Text == "" || textBoxHoTenNV.Text == "" || comboBoxGioiTinhNV.Text == "" || dateTimePickerNSNV.Value == null || textBoxDiaChiNV.Text == "" || textBoxSDTNV.Text == "" || textBoxEmailNV.Text == "" || textBoxCMNDNV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dto.Manv = textboxMaNV.Text.Trim().ToString();
                    dto.Macv = textBoxMaCVNV.Text.Trim().ToString();
                    dto.Hoten = textBoxHoTenNV.Text.ToString();
                    dto.Ngaysinh = dateTimePickerNSNV.Value;
                    dto.Gioitinh = comboBoxGioiTinhNV.SelectedItem?.ToString();
                    dto.Diachi = textBoxDiaChiNV.Text.ToString();
                    dto.Sdt = textBoxSDTNV.Text.ToString();
                    dto.Email = textBoxEmailNV.Text.ToString();
                    dto.Cmnd = textBoxCMNDNV.Text.ToString();
                    BusinessLogicLayer.Instance.updateNhanvien(dto.Manv, dto.Macv, dto.Hoten, dto.Ngaysinh, dto.Gioitinh, dto.Sdt, dto.Cmnd, dto.Diachi, dto.Email);
                    MessageBox.Show("Thay đổi thông tin thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridViewNV();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi sửa nhân viên " + "\n" + ex);
            }
            
        }

        private void dataGridViewListNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (dataGridViewListNhanVien.Rows[d].Cells[0].Value == null || dataGridViewListNhanVien.Rows[d].Cells[1].Value == null || dataGridViewListNhanVien.Rows[d].Cells[2].Value == null
                || dataGridViewListNhanVien.Rows[d].Cells[3].Value == null || dataGridViewListNhanVien.Rows[d].Cells[4].Value == null || dataGridViewListNhanVien.Rows[d].Cells[5].Value == null ||
                dataGridViewListNhanVien.Rows[d].Cells[6].Value == null || dataGridViewListNhanVien.Rows[d].Cells[7].Value == null || dataGridViewListNhanVien.Rows[d].Cells[8].Value == null)
            {
                textboxMaNV.Text = "";
                textBoxMaCVNV.Text = "";
                textBoxHoTenNV.Text = ""; 
                comboBoxGioiTinhNV.Text = "";
                dateTimePickerNSNV.Text = "";
                textBoxDiaChiNV.Text =""; 
                textBoxSDTNV.Text = "";
                textBoxEmailNV.Text = ""; textBoxCMNDNV.Text = "";
              
             
                textBoxCMNDNV.Text = "";
            }
            else
            {
                textboxMaNV.Text = dataGridViewListNhanVien.Rows[d].Cells[0].Value.ToString();
                textBoxMaCVNV.Text = dataGridViewListNhanVien.Rows[d].Cells[1].Value.ToString();
                textBoxHoTenNV.Text = dataGridViewListNhanVien.Rows[d].Cells[2].Value.ToString();
                dateTimePickerNSNV.Text = dataGridViewListNhanVien.Rows[d].Cells[3].Value.ToString();
                comboBoxGioiTinhNV.Text = dataGridViewListNhanVien.Rows[d].Cells[4].Value.ToString();
                textBoxSDTNV.Text = dataGridViewListNhanVien.Rows[d].Cells[5].Value.ToString();
                textBoxCMNDNV.Text = dataGridViewListNhanVien.Rows[d].Cells[6].Value.ToString();
                textBoxDiaChiNV.Text = dataGridViewListNhanVien.Rows[d].Cells[8].Value.ToString();
                textBoxEmailNV.Text = dataGridViewListNhanVien.Rows[d].Cells[7].Value.ToString();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textboxMaNV.TextLength == 0)
            {
                MessageBox.Show("Bạn cần chọn mã nhân viên để xóa!");
            }
            else
            {
                dto.Manv = textboxMaNV.Text;
                BusinessLogicLayer.Instance.deleteNhanvien(dto.Manv);
                MessageBox.Show("Đã xóa thành công!");
                loadDataGridViewNV();
            }
        }

        private void buttonTimKiemInfor_Click(object sender, EventArgs e)
        {
            string noiDungTimKiem = textBoxNoiDung.Text.ToString();
            string dieuKien = comboBoxSearchField.Text.ToString();
            DataTable dtb = BusinessLogicLayer.Instance.serchNhanVien(dieuKien, noiDungTimKiem);
            dataGridViewListNhanVien.DataSource = dtb;
        }
    }
}
