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

namespace PMQLKS
{
    public partial class formQuanLyPhong : Form
    {
        public formQuanLyPhong()
        {
            InitializeComponent();
        }
        private string maPhong;
        private string tenLoaiPhong;
        private bool tinhTrang;
        private int soluongphongtrong;
        private void Load_data_room(string type)
        {
           dbDataContext  db = new dbDataContext();
           var phong = from p in db.phongs
                        join k in db.loaiphongs
                        on p.tenlp equals k.tenlp
                        where p.tenlp == type
                        select new { p.maphong, p.tenlp, p.tinhtrang, k.giaphong };
            var soluongPhongTrong = from lp in db.loaiphongs
                                    where lp.tenlp == type
                                    select lp.soluongtrong;
  

            txttrong.Text = soluongPhongTrong.FirstOrDefault().ToString();
            soluongphongtrong = soluongPhongTrong.FirstOrDefault();
            dataGridViewPhong.DataSource = phong;
        }


       
        private void formQuanLyPhong_Load(object sender, EventArgs e)
        {
        
        }

        private void radioBtnStandard_Click(object sender, EventArgs e)
        {
            Load_data_room("Standard");
        }

        private void radioButtonSuperio_Click(object sender, EventArgs e)
        {
            Load_data_room("Superio");
        }

        private void radioButtonSuite_Click(object sender, EventArgs e)
        {
            Load_data_room("Suite");
        }

        private void radioButtonDeluxe_Click(object sender, EventArgs e)
        {
            Load_data_room("Deluxe");

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            if (maPhong == null)
            {
                MessageBox.Show("Hãy chọn phòng muốn cập nhật tình trạng!");
            }
            else
            {
                try
                {                
                    var phong = db.phongs.Single(p => p.maphong == this.maPhong);
                    phong.tenlp = tenLoaiPhong;
                    if (tinhTrang)
                    {
                        phong.tinhtrang = false;
                        txttrong.Text = (soluongphongtrong + 1).ToString();
                    }
                    else
                    {
                        phong.tinhtrang = true;
                        txttrong.Text = (soluongphongtrong - 1).ToString();
                    }
                    db.SubmitChanges();
                    Load_data_room(this.tenLoaiPhong);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex);
                }
            }
            
        }

        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewPhong.Rows[e.RowIndex];
            maPhong = row.Cells[0].Value.ToString();
            tenLoaiPhong = row.Cells[1].Value.ToString();
            tinhTrang = Convert.ToBoolean(row.Cells[2].Value);
        }
    }
}
