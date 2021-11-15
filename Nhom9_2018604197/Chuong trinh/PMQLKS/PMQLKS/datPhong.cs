using System;
using System.Collections;
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
    public partial class datPhong : Form
    {
        string trangthaithanhtoan;
        string tenloaiphong;
        string madatphong;
        int songaythue;
        int soluongphongdat;

        string dsPhong;

        string tenphong;

        IList<string> arrDSPhong = new List<string>();

        IList<string> arr = new List<string>();
        IList<string> arr1 = new List<string>();
        public datPhong()
        {
            InitializeComponent();
        }


        public void loadComboxLoaiPhong()
        {
            comboBoxLoaiPhong.DataSource = BusinessLogicLayer.Instance.getLoaiPhong();
            comboBoxLoaiPhong.ValueMember = "tenlp";
            comboBoxLoaiPhong.DisplayMember = "tenlp";
        }

        private void datPhong_Load(object sender, EventArgs e)
        {
            loadComboxLoaiPhong();
            loadListPhong();
            loadDatgridView();
            loadMaNV();
            txtmakh.Text = setmakh();
          tbMaDP.Text = setmadp();

        }

        public void loadListPhong()
        {
            tenphong = comboBoxLoaiPhong.SelectedValue.ToString();

            //lbPhongTrong.DataBindings.Clear();
            lbPhongTrong.DataSource = BusinessLogicLayer.Instance.getListPhong(tenphong);
            lbPhongTrong.DisplayMember = "maphong";
            lbPhongTrong.ValueMember = "maphong";
        }

        public void loadDatgridView()
        {
            dataGridViewDP.DataSource = BusinessLogicLayer.Instance.getListDatPhong();
        }

        private void comboBoxLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            loadListPhong();
        }
        private void setarr1()
        {
            DataTable dtb = new DataTable();
            string tenlp = comboBoxLoaiPhong.SelectedValue.ToString();
            dtb = BusinessLogicLayer.Instance.getListPhong(tenphong);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow r = dtb.Rows[i];
                arr1.Add(r[0].ToString());
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (arr1.Count == 0)
            {
                setarr1();
            }

            lbPhongDat.DataSource = null;
            if (lbPhongTrong.SelectedIndex > -1)
            {
                arr.Add(lbPhongTrong.SelectedValue.ToString());
                arr1.RemoveAt(lbPhongTrong.SelectedIndex);
            }
            lbPhongDat.ClearSelected();
            BindingSource bsOne = new BindingSource();
            bsOne.DataSource = arr;
            lbPhongDat.DataSource = bsOne;

            lbPhongTrong.DataSource = null;

            lbPhongTrong.DataSource = arr1;

            int soluong = arr.Count;
            tbSoluong.Text = soluong.ToString();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string tmp = arr[lbPhongDat.SelectedIndex].ToString();
            arr.RemoveAt(lbPhongDat.SelectedIndex);
            arr1.Add(tmp);
            lbPhongTrong.DataSource = null;
            lbPhongTrong.DataBindings.Clear();
            lbPhongTrong.DataSource = arr1;
            lbPhongDat.DataSource = null;
            lbPhongDat.DataBindings.Clear();
            lbPhongDat.DataSource = arr;
            int soluong = arr.Count;
            tbSoluong.Text = soluong.ToString();

        }


        private string setmadp()
        {
            int id;
            id = int.Parse(BusinessLogicLayer.Instance.GetLastID("datphong", "madp").Substring(2, 3));
            if (id < 9)
                return "DP00" + (id + 1).ToString();
            else
                if (id < 99)
                return "DP0" + (id + 1).ToString();
            else
                return "DP" + (id + 1).ToString();
        }

        private string setmakh()
        {
            int id;
            id = int.Parse(BusinessLogicLayer.Instance.GetLastID("khachhang", "makh").Substring(2, 3));
            if (id < 9)
                return "KH00" + (id + 1).ToString();
            else
                if (id < 99)
                return "KH0" + (id + 1).ToString();
            else
                return "KH" + (id + 1).ToString();
        }

        public void loadMaNV()
        {
            comboBoxNV.DataSource = BusinessLogicLayer.Instance.getMaNV();
            comboBoxNV.ValueMember = "manv";
            comboBoxNV.DisplayMember = "manv";
        }

        private void insertDatPhong()
        {
            dbDataContext db = new dbDataContext();
            datphong dp = new datphong();
            tbMaDP.Text = setmadp();
            dp.madp = tbMaDP.Text;
            dp.manv = comboBoxNV.SelectedValue.ToString();
            dp.makh = txtmakh.Text;
            dp.tenlp = comboBoxLoaiPhong.SelectedValue.ToString();
            dp.ngaydat = DateTime.Now;
            dp.ngayden = dateTimeDen.Value;
            dp.ngaydi = dateTimeDi.Value;
            tbSoluong.Text = arr.Count.ToString();
            dp.soluong = Int16.Parse(tbSoluong.Text);
            dp.trangthaitt = "Chưa thanh toán";
            dp.dsphong = String.Join(", ", arr);
            db.datphongs.InsertOnSubmit(dp);
            db.SubmitChanges();
        }

        private void insertKhachHang()
        {

            dbDataContext db = new dbDataContext();
            khachhang newkh = new khachhang();
            newkh.makh = txtmakh.Text;
            newkh.hoten = txttenkh.Text;
            newkh.cmnd = txtcmt.Text;
            newkh.sdt = txtsdt.Text;
            newkh.diachi = txtdc.Text;
            newkh.email = txtemail.Text;
            db.khachhangs.InsertOnSubmit(newkh);
            db.SubmitChanges();
        }

        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            DateTime ngayDen = dateTimeDen.Value;
            DateTime ngayDi = dateTimeDi.Value;
            int reslut = DateTime.Compare(ngayDen, ngayDi);
            
            try
            {

                if (txtmakh.Text == "" ||
                 txttenkh.Text == "" ||
                 txtcmt.Text == "" ||
                 txtsdt.Text == "" ||
                 txtdc.Text == "" ||
                 txtemail.Text == "" ||
                 comboBoxLoaiPhong.Text == "" ||
                 comboBoxNV.Text == "" ||
                 comboBoxLoaiPhong.Text == "" ||
                 tbSoluong.Text == ""
                 )
                {
                    MessageBox.Show("Bạn phải điền đầy dủ thông tin!!!");
                }

              else if (reslut == 1)
                {
                    
                        MessageBox.Show("Ngày đi phải lớn hơn ngày đến");
                    
                }

                else
                {

                    DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn đặt phòng?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                    {
                        insertKhachHang();
                        insertDatPhong();
                      
                        for (int i = 0; i < arr.Count; i++)
                        {
                            BusinessLogicLayer.Instance.capNhatTrangThaiPhongDat(arr[i].ToString());
                        }
                        BusinessLogicLayer.Instance.capNhatSoLuongPhong(comboBoxLoaiPhong.SelectedValue.ToString(), arr.Count);
                        loadDatgridView();                              
                        MessageBox.Show("Đặt phòng thành công!");

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }



        private void buttoThanhToan_Click(object sender, EventArgs e)
        {
            if (this.trangthaithanhtoan == "Đã thanh toán")
            {
                MessageBox.Show("Bạn hãy chọn đặt phòng chưa thanh toán trong bảng dữ liệu!");
            }
            else
            {
                formThanhToan f = new formThanhToan(madatphong, tenloaiphong, songaythue, soluongphongdat, arrDSPhong);
                f.Show();
            }    
        }

        private void dateTimeDen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewDP.Rows[e.RowIndex];
            this.trangthaithanhtoan = row.Cells[9].Value.ToString();
            this.madatphong = row.Cells[0].Value.ToString();
            this.tenloaiphong = row.Cells[3].Value.ToString();
            this.songaythue = Convert.ToInt32((DateTime.ParseExact(row.Cells[6].Value.ToString(), "M/d/yyyy hh:mm:ss tt", null)).Subtract(DateTime.ParseExact(row.Cells[5].Value.ToString(), "M/d/yyyy hh:mm:ss tt", null)).TotalDays);
            this.soluongphongdat = Convert.ToInt32(row.Cells[7].Value.ToString());
            this.dsPhong = row.Cells[8].Value.ToString();
            arrDSPhong = dsPhong.Split(',');
           
             
        }
    }
    }
    

