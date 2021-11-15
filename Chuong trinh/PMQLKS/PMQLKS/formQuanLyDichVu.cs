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
    public partial class formQuanLyDichVu : Form
    {
        public formQuanLyDichVu()
        {
            InitializeComponent();
        }
        DataTranferObject dto = new DataTranferObject();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (tbMadv.TextLength == 0) MessageBox.Show("Mã không được bỏ trống!");
            if (tbTenDichVu.TextLength == 0) MessageBox.Show("Tên sản phẩm không được bỏ trống!");
            if (tbGiaDich.TextLength == 0) MessageBox.Show("Giá không được bỏ trống!");

            else
            {
                try
                {
                    dto.Madv = tbMadv.Text;
                    dto.Tendv = tbTenDichVu.Text;
                    dto.Gia = double.Parse(tbGiaDich.Text);

                    BusinessLogicLayer.Instance.InsertPN(dto.Madv, dto.Tendv, dto.Gia);
                    MessageBox.Show("Thêm thành công!");
                    formQuanLyDichVu_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Phiếu đã tồn tại\nVui lòng tạo mã phiếu khác!", "Thông báo");
                }
            }
        }

        private void formQuanLyDichVu_Load(object sender, EventArgs e)
        {
            dgvListDichVu.DataSource = BusinessLogicLayer.Instance.dichVu();
        }

        
        private void dgvListDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvListDichVu.RowCount; i++)
            {
                dgvListDichVu.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgvListDichVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (dgvListDichVu.Rows[d].Cells[1].Value == null || dgvListDichVu.Rows[d].Cells[2].Value == null || dgvListDichVu.Rows[d].Cells[3].Value == null)
                {
                tbMadv.Text = "";
                tbTenDichVu.Text = "";
                tbGiaDich.Text = "";
            }
            else
            {
                tbMadv.Text = dgvListDichVu.Rows[d].Cells[1].Value.ToString();
                tbTenDichVu.Text = dgvListDichVu.Rows[d].Cells[2].Value.ToString();
                tbGiaDich.Text = dgvListDichVu.Rows[d].Cells[3].Value.ToString();
            }
        }


        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (tbMadv.TextLength == 0) MessageBox.Show("Mã không được bỏ trống!");
            if (tbTenDichVu.TextLength == 0) MessageBox.Show("Tên sản phẩm không được bỏ trống!");
            if (tbGiaDich.TextLength == 0) MessageBox.Show("Giá không được bỏ trống!");
            else
            {
                try
                {
                    dto.Madv = tbMadv.Text;
                    dto.Tendv = tbTenDichVu.Text;
                    dto.Gia = double.Parse(tbGiaDich.Text);

                    BusinessLogicLayer.Instance.UpdatePN(dto.Madv, dto.Tendv, dto.Gia);
                    MessageBox.Show("Sửa thành công!");
                    formQuanLyDichVu_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Error", "Thông báo");
                }
            }
        }

        private void btnxoaDV_Click(object sender, EventArgs e)
        {
            if (tbMadv.TextLength == 0) MessageBox.Show("Nhập mã DV cần xóa!", "Thông báo");
            else
            {

                dto.Madv = tbMadv.Text;

                BusinessLogicLayer.Instance.DeletePN(dto.Madv);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                formQuanLyDichVu_Load(sender, e);


            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMadv.ResetText();
            tbGiaDich.ResetText();
            tbTenDichVu.ResetText();
            tbTimKiem.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfull");
        }

        private void btimKiem_Click(object sender, EventArgs e)
        {
            if (rbMaDV.Checked)
            {
                if(tbTimKiem.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng nhập nội dung dịch vụ cần tìm kiếm!!!");
                }
                else
                {
                    string condition = tbTimKiem.Text.Trim().ToString();
                    dgvListDichVu.DataSource = BusinessLogicLayer.Instance.LookMPN(tbTimKiem.Text);
                    MessageBox.Show("Tìm kiếm mã dịch vụ thành công!");
                   // formQuanLyDichVu_Load(sender, e);
                }
            }
            if (rbTenDV.Checked)
            {
                if (tbTimKiem.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng nhập nội dung dịch vụ cần tìm kiếm!!!");
                }
                else
                {
                    string condition = tbTimKiem.Text.Trim().ToString();
                    dgvListDichVu.DataSource = BusinessLogicLayer.Instance.LookT(condition);
                   // formQuanLyDichVu_Load(sender, e);
                    MessageBox.Show("Tìm kiếm tên dịch vụ thành công!");
                }
            }
            if (rbGiaDV.Checked)
            {
                if (tbTimKiem.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng nhập nội dung dịch vụ cần tìm kiếm!!!");
                }
                else
                {
                    string condition = tbTimKiem.Text.Trim().ToString();
                    dgvListDichVu.DataSource = BusinessLogicLayer.Instance.LookG(condition);
                   // formQuanLyDichVu_Load(sender, e);
                    MessageBox.Show("Tìm kiếm giá dịch vụ thành công!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvListDichVu.DataSource = BusinessLogicLayer.Instance.dichVu();
        }
    }
}
