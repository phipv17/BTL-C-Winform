using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PMQLKS
{
    public partial class formThanhToan : Form
    {
        private string maDP;
        private string tenLP;
        private decimal tongTien;
        private int songaythue = 1;
        private int soluongphongdat = 1;
        private decimal tienLoaiPhong;
        private decimal tienPhong;
        private string thuephongstring;
        private int soluongphongdatam; 

        private IList<string> arrList = new List<string>();
       
        private string day = DateTime.Now.Day.ToString();
        private string month = DateTime.Now.Month.ToString();
        private string year = DateTime.Now.Year.ToString();
  

        public formThanhToan(string maDatPhong, string tenLoaiPhong, int soNgayThue, int soLuongPhongDat, IList<string> arrayList)
        {
            InitializeComponent();
       
            this.maDP = maDatPhong;
            this.tenLP = tenLoaiPhong;
            this.songaythue = soNgayThue;
            this.soluongphongdat = soLuongPhongDat;
            this.thuephongstring = "Thuê loại phòng: " + tenLoaiPhong + ", trong "+ soNgayThue + " ngày";
            this.arrList = arrayList;
            this.soluongphongdatam = -soluongphongdat;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbTongtien.Text == null)
                {
                    MessageBox.Show("Hãy tính tổng tiền!");
                }
                else
                {
                    dbDataContext db = new dbDataContext();
                    hoadon hd = new hoadon();
                    hd.mahd = tbMaHD.Text.Trim();
                    hd.madp = tbMaDP.Text;
                    hd.madv = cbbMadv.SelectedValue.ToString();
                    hd.ngaylap = DateTime.ParseExact(tbNgaylap.Text, "dd/MM/yyyy", null);
                    hd.tongtien = Decimal.Parse(tbTongtien.Text);
                    db.hoadons.InsertOnSubmit(hd);
                    db.SubmitChanges();

                    //cap nhat lai so luong phong trong trong loai phong
                    BusinessLogicLayer.Instance.capNhatSoLuongPhong(tenLP, soluongphongdatam);

                    //cap nhat lai tinh trang dat phong trong bang dat phong
                    var capnhat = db.datphongs.Single(dp => dp.madp == this.maDP);
                    capnhat.trangthaitt = "Đã thanh toán";
                    db.SubmitChanges();

                    //cap nhat lai trang thai phong 
                    for (int i = 0; i < arrList.Count; i++)
                    {
                        BusinessLogicLayer.Instance.capNhatTrangThaiPhongTraPhong(arrList[i].Trim().ToString());
                      
                    }

                    DialogResult d;
                    d = MessageBox.Show("Bạn có chắc chắn tiếp tục?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (d == DialogResult.Yes)
                    {
                        MessageBox.Show("Lưu hóa đơn thành công!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi, vui lòng thử lại!" + ex);
            }
            
        }
        private void loadCBBDichVu()
        {
            dbDataContext db = new dbDataContext();
            var dichvu = from dv in db.dichvus
                         select dv;
            cbbMadv.DataSource = dichvu;
            cbbMadv.DisplayMember = "tendv";
            cbbMadv.ValueMember = "madv";
        }

        private void formThanhToan_Load(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            tbMaDP.Text = maDP;
            tbNgaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            loadCBBDichVu();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    dbDataContext db = new dbDataContext();
                    var giadichvu = from dv in db.dichvus
                                    where dv.madv == cbbMadv.SelectedValue.ToString()
                                    select dv.gia;
                    var tienLP = from lp in db.loaiphongs
                                 where lp.tenlp == tenLP
                                  select lp.giaphong;
                    this.tienLoaiPhong = tienLP.FirstOrDefault();
                    this.tienPhong = tienLoaiPhong * songaythue * soluongphongdat;

                    tongTien = (Convert.ToDecimal(giadichvu.FirstOrDefault()) + tienPhong);
                    tbTongtien.Text = tongTien.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var tenKH = from dp in db.datphongs
                        join hd in db.hoadons
                        on dp.madp equals hd.madp
                        join kh in db.khachhangs
                        on dp.makh equals kh.makh
                        join lp in db.loaiphongs
                        on dp.tenlp equals lp.tenlp
                        where hd.mahd == tbMaHD.Text
                        select kh.hoten;

            var diachikhachhang = from dp in db.datphongs
                        join hd in db.hoadons
                        on dp.madp equals hd.madp
                        join kh in db.khachhangs
                        on dp.makh equals kh.makh
                        join lp in db.loaiphongs
                        on dp.tenlp equals lp.tenlp
                        where hd.mahd == tbMaHD.Text
                        select kh.diachi;

            var dongiaPhong = from dp in db.datphongs
                                  join hd in db.hoadons
                                  on dp.madp equals hd.madp
                                  join kh in db.khachhangs
                                  on dp.makh equals kh.makh
                                  join lp in db.loaiphongs
                                  on dp.tenlp equals lp.tenlp
                                  where hd.mahd == tbMaHD.Text
                                  select lp.giaphong;

            var giadichvu = from hd in db.hoadons
                              join dv in db.dichvus
                              on hd.madv equals dv.madv
                              where hd.mahd == tbMaHD.Text
                              select dv.gia;
       

            var dvName = from hd in db.hoadons
                         join dv in db.dichvus
                         on hd.madv equals dv.madv
                         select dv.tendv;

        


        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"lib\invoice.html");
            string invoice = File.ReadAllText(path);
            invoice = invoice.Replace("@#@comName", "Khách sạn HaUI");
            invoice = invoice.Replace("@#@comTaxCode", "123456789");
            invoice = invoice.Replace("@#@comAddress", "Cầu Diễn, Hà Nội");
            invoice = invoice.Replace("@#@comPhone", "0999999999");
            invoice = invoice.Replace("@#@comEmail", "khachsanhaui@gmail.com");
            invoice = invoice.Replace("@#@comWeb", "khachsanhaui.com");
            invoice = invoice.Replace("@#@comBank", "0999999999");
            invoice = invoice.Replace("@#@comPhone", "1125 356 457");
            invoice = invoice.Replace("@#@invDay", day);
            invoice = invoice.Replace("@#@invMonth", month);
            invoice = invoice.Replace("@#@invYear", year);
            invoice = invoice.Replace("@#@invNo", tbMaHD.Text.ToString());
            invoice = invoice.Replace("@#@cusName", tenKH.FirstOrDefault().ToString());
            invoice = invoice.Replace("@#@cusAddress", diachikhachhang.FirstOrDefault().ToString());
            invoice = invoice.Replace("@#@cusTaxCode", "");
            invoice = invoice.Replace("@#@cusCom", "");
            invoice = invoice.Replace("@#@day", songaythue.ToString());
            invoice = invoice.Replace("@#@price", tienLoaiPhong.ToString());
            invoice = invoice.Replace("@#@amount", tienPhong.ToString());
            invoice = invoice.Replace("@#@dvprice", giadichvu.FirstOrDefault().ToString());
            invoice = invoice.Replace("@#@dvamount", giadichvu.FirstOrDefault().ToString());
            invoice = invoice.Replace("@#@totalamount", tongTien.ToString());
            invoice = invoice.Replace("@#@dvName", dvName.FirstOrDefault());
            invoice = invoice.Replace("@#@thuephong", thuephongstring);

            byte[] data = PdfUtils.ExecuteGenPdfBytes(invoice, "A4");
            DownloadFile(data);
        }

        private void DownloadFile(byte[] data)
        {
            string fileName = $"{DateTime.Now.ToString("yyyyMMdd_hhmmss")}";

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Data Files (*.pdf)|*.pdf";
            sf.DefaultExt = "pdf";
            sf.AddExtension = true;
            sf.FileName = $"{fileName}.pdf";
            Invoke((Action)(() =>
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sf.FileName, data);
                    MessageBox.Show("Xuất hóa đơn thành công", "Thông báo");
                }
            }));
        }
    }
}
