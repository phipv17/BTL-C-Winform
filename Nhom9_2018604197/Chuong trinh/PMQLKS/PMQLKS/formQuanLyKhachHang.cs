using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLKS
{
    public partial class formQuanLyKhachHang : Form
    {
        private string maKHSelected = null;
        public formQuanLyKhachHang()
        {
            InitializeComponent();
        }
        private void loadDataGridViewKhachHang()
        {
            dbDataContext db = new dbDataContext();
            var khachhang = from kh in db.khachhangs
                            select kh;
            dataGridViewKhachHang.DataSource = khachhang;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {

                dbDataContext db = new dbDataContext();
                IQueryable<khachhang> table = db.khachhangs.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tbMaKH.Text))
                    table = table.Where(kh => kh.makh.Contains(tbMaKH.Text));

                if (!string.IsNullOrWhiteSpace(tbTenKH.Text))
                    table = table.Where(kh => kh.hoten.Contains(tbTenKH.Text));

                if (!string.IsNullOrWhiteSpace(tbCMND.Text))
                    table = table.Where(kh => kh.cmnd.Contains(tbCMND.Text));

                if (!string.IsNullOrWhiteSpace(tbSDT.Text))
                    table = table.Where(kh => kh.sdt.ToString().Contains(tbSDT.Text));

                if (!string.IsNullOrWhiteSpace(tbEmail.Text))
                    table = table.Where(kh => kh.email.Contains(tbEmail.Text));

                if (!string.IsNullOrWhiteSpace(tbDiaChi.Text))
                    table = table.Where(kh => kh.diachi.Contains(tbDiaChi.Text));

                dataGridViewKhachHang.DataSource = table.Select(kh => kh);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm!" + ex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formEditKhachHang f = new formEditKhachHang("");
            f.FormClosed += new FormClosedEventHandler(editFormClosed);
            f.Show();
        }
        void editFormClosed(object sender, FormClosedEventArgs e)
        {
            loadDataGridViewKhachHang();
        }

        private void formQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            loadDataGridViewKhachHang();
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewKhachHang.Rows[e.RowIndex];
            tbMaKH.Text = row.Cells[0].Value.ToString();
            maKHSelected = tbMaKH.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            formEditKhachHang f = new formEditKhachHang(maKHSelected);
            f.FormClosed += new FormClosedEventHandler(editFormClosed);
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaKH.TextLength == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!");
            }
            else
            {
                try
                {
                    dbDataContext db = new dbDataContext();
                    var xoa = from kh in db.khachhangs
                              where kh.makh == tbMaKH.Text
                              select kh;
                    foreach (var i in xoa)
                    {
                        db.khachhangs.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    loadDataGridViewKhachHang();
                    DialogResult b;
                    b = MessageBox.Show("Bạn có chắc chắn xóa khách hàng này không!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (b == DialogResult.Yes)
                    {
                        MessageBox.Show("Bạn đã xóa khách hàng thành công!");
                    }
                  

                }
                catch
                {
                    MessageBox.Show("Bạn không thể xóa khách hàng này, vui lòng thử lại!");
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDataGridViewKhachHang();
            tbMaKH.ResetText();
        }
    }
}
