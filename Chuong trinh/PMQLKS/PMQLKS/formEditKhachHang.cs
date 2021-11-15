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
    public partial class formEditKhachHang : Form
    {
        private String maKH;
        public formEditKhachHang(string maKH)
        {
            InitializeComponent();
            tbMaKH.Text = maKH;
            this.maKH = maKH;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (maKH.Length == 0)
            {
                if (tbTenKH.TextLength == 0 || tbTenKH.TextLength == 0 || tbCMND.TextLength == 0 || tbSDT.TextLength == 0 || tbEmail.TextLength == 0 || tbDiaChi.TextLength == 0)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
                }
                else
                {
                    try
                    {
                        dbDataContext db = new dbDataContext();
                        khachhang kh = new khachhang();
                        kh.makh = tbMaKH.Text.Trim();
                        kh.hoten = tbTenKH.Text;
                        kh.cmnd = tbCMND.Text;
                        kh.sdt = tbSDT.Text;
                        kh.email = tbEmail.Text;
                        kh.diachi = tbDiaChi.Text;
                        db.khachhangs.InsertOnSubmit(kh);
                        db.SubmitChanges();
                        DialogResult d;
                        d = MessageBox.Show("Bạn có chắc chắn muốn thêm khách hàng này không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (d == DialogResult.Yes)
                        {
                            Close();
                        }                     
                        MessageBox.Show("Bạn đã thêm khách hàng thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm khách hàng không thành công, vui lòng thử lại!" + ex);
                    }
                }
            }
            else
            {
                if (tbCMND.TextLength == 0 || tbSDT.TextLength == 0 || tbEmail.TextLength == 0 || tbDiaChi.TextLength == 0)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
                }
                else
                {
                    try
                    {
                        dbDataContext db = new dbDataContext();
                        var khachhang = db.khachhangs.Single(kh => kh.makh == this.maKH);
                        khachhang.hoten = tbTenKH.Text;
                        khachhang.cmnd = tbCMND.Text;
                        khachhang.sdt = tbSDT.Text;
                        khachhang.email = tbEmail.Text;
                        khachhang.diachi = tbDiaChi.Text;
                        db.SubmitChanges();
                        DialogResult b;
                        b = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin này không!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (b == DialogResult.Yes)
                        {
                            Close();
                        }
                        MessageBox.Show("Bạn đã sửa khách hàng thành công!" );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa khách hàng không thành công, vui lòng thử lại!" + ex);
                    }
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
