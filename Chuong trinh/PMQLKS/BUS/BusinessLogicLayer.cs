using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BusinessLogicLayer
    {
        //tạo mới lớp DAL
        DataAcessLayer da = new DataAcessLayer();
        //khởi tạo sigleton cho lớp BUS
        private static BusinessLogicLayer instance;

        public static BusinessLogicLayer Instance
        {
            get { if (instance == null) instance = new BusinessLogicLayer(); return BusinessLogicLayer.instance; }
            private set { BusinessLogicLayer.instance = value; }
        }
        public BusinessLogicLayer() { }
        //phương thức login
        public bool Login(string username, string passWord)
        {
            string query = "SELECT * FROM TaiKhoan WHERE tentaikhoan = N'" + username + "' AND matkhau = N'" + passWord + "'";

            DataTable result = da.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        //Đăng ký tài khoản
        public bool isRegister(string userName, string password, string quyen ,string hoten)
            
        {
            string query = "Insert into taikhoan values (N'" + userName + "', N'" + hoten + "' , N'" + password + "' , N'" + quyen + "' )";        
            DataTable result = da.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        //phương thức kiểm tra tồn tại user
        public bool isExistUserAccount(string userName)
        {
            string query = "Select * from TaiKhoan where tentaikhoan = '" + userName + "'";
            DataTable result = da.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }


        public void upDateUser(string userName, string password, string role)
        {
            string query = "Update TaiKhoan set matkhau = N'" + password + "', quyen = N'" + role + "' where tentaikhoan= N'" + userName + "'";
            da.excuteQuerry(query);
        }

        //lấy tên người đăng nhập
        public string getTenNhanVien(string userName)
        {
            string emloyeeName = "";
            string query = " Select hoten From TaiKhoan Where tentaikhoan = '" + userName + "'";
            DataTable dtb = da.ExecuteQuery(query);
            //DataRow r = dtb.Rows[0];
            foreach (DataRow item in dtb.Rows)
            {
                emloyeeName = item["hoten"].ToString();
            }

            return emloyeeName;
        }
        //lấy quyền hạn sử dụng
        public string getUserIDPermision(string userName, string password)
        {
            string quyen = "";
            string query = "SELECT * FROM TaiKhoan WHERE tentaikhoan = N'" + userName + "' AND matkhau = N'" + password + "'";
            DataTable dtbQuyenNV = da.ExecuteQuery(query);
            foreach (DataRow item in dtbQuyenNV.Rows)
            {
                quyen = item["quyen"].ToString();
            }

            return quyen;
        }
        //lấy bảng tài khoản
        public DataTable setUserDataTable()
        {
            DataTable dtb = new DataTable();
            string querry = "select * from TaiKhoan";
            dtb = da.ExecuteQuery(querry);
            return dtb;
        }
        //lấy quyền nhân viên theo tên tài khoản
        public string getUserPermision(string userName)
        {
            string tenQuyenquyen = "";
            string query = "SELECT * FROM TaiKhoan WHERE tentaikhoan = N'" + userName + "'";
            DataTable dtbQuyenNV = da.ExecuteQuery(query);
            foreach (DataRow item in dtbQuyenNV.Rows)
            {
                tenQuyenquyen = item["quyen"].ToString();
            }

            return tenQuyenquyen;
        }
        //lấy bảng nhân viên
        public DataTable getTableTaiKhoan(string userName)
        {
            DataTable dtb;
            string sql = "Select * from TaiKhoan where tentaikhoan =  N'" + userName + "'";
            dtb = da.ExecuteQuery(sql);
            return dtb;
        }
        //lấy bảng chức vụ
        public DataTable getTableChucVu(string maCV)
        {
            DataTable dtb;
            string sql = "Select* from chucvu where macv = N'" + maCV + "'";
            dtb = da.ExecuteQuery(sql);
            return dtb;
        }
        //lấy bảng tài khoản theo tên tài khoản
        /* public DataTable getTableTaiKhoan(string manv)
         {
             string sql = "select * from taikhoan where manv = N'" + manv + "'";
             DataTable dtb;
             dtb = da.GetTable(sql);
             return dtb;
         }*/
        //lấy tất cả tài khoản
        public DataTable getUserAccount()
        {
            DataTable dtb;
            string sql = "select * from taikhoan";
            dtb = da.getTableFromDB(sql);

            return dtb;
        }

        //lấy bảng dịch vụ
        public DataTable dichVu()
        {
            String sql = "select *from DichVu";
            DataTable dt = new DataTable();
            dt = da.getTableFromDB(sql);
            return dt;
        }
        //them dich vu
        public void InsertPN(string madv, string tendv, double gia)
        {
            string sql = "insert dichvu values(N'" + madv + "',N'" + tendv + "',N'" + gia + "')";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.excuteQuerry(sql);
        }

        //sửa dịch vụ
        public void UpdatePN(string madv, string tendv, double gia)
        {
            string sql = "update dichvu set tendv =N'" + tendv + "'," +
                "gia=N'" + gia + "'where madv=N'" + madv + "'";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.excuteQuerry(sql);
        }

        //xoa dich vu
        public void DeletePN(string madv)
        {
            string sql = "delete dichvu where madv=N'" + madv + "'";
            //lệnh thực thi không trả về bảng đã viết bên lớp DAL
            da.excuteQuerry(sql);
        }
        //tim kiem theo ma dich vu
        public DataTable LookMPN(string dk)
        {
            string sql = "select * from dichvu where madv like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTableFromDB(sql);
            return dt;
        }

        //tim kiem theo ten dich vu
        public DataTable LookT(string dk)
        {
            string sql = "select *from dichvu where tendv like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTableFromDB(sql);
            return dt;
        }
        //tim kiem theo gia dich vu
        public DataTable LookG(string dk)
        {
            string sql = "select *from dichvu where gia like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTableFromDB(sql);
            return dt;
        }

        //lay 8 cot bang nv
        public DataTable getNhanVienInfor()
        {
            DataTable dtb;
            string sql = "Select manv,macv,hoten,ngaysinh,gioitinh,sdt,cmnd,email,diachi from nhanvien";
            dtb = da.getTableFromDB(sql);
            return dtb;
        }

        public void insertNhanvien(string manv, string macv, string ht, DateTime ns, string gt, string sdt, string cmnd, string dc, string email)
        {
            string sql = "insert into nhanvien values(N'" + manv + "',N'" + macv + "',N'" + ht + "',N'" + ns + "',N'" + gt + "',N'" + sdt + "',N'" + cmnd + "',N'" + dc + "',N'" + email + "')";
            da.excuteQuerry(sql);
        }

        // sửa thông tin nhân viên
        public void updateNhanvien(string manv, string macv, string ht, DateTime ns, string gt, string sdt, string cmnd, string dc, string email)
        {
            string sql = "update nhanvien set macv = '" + macv + "',hoten=N'" + ht + "',ngaysinh='" + ns + "',gioitinh=N'" + gt + "',sdt=N'" + sdt + "',cmnd='" + cmnd + "',diachi=N'" + dc + "',email=N'" + email + " where manv ='" + manv + "'";
            da.excuteQuerry(sql);
        }

        //xóa nhân viên
        public void deleteNhanvien(string manv)
        {
            string sql = "delete nhanvien where manv=N'" + manv + "'";
            da.excuteQuerry(sql);
        }

        //update tài khoản
        public void upDateAccount(string userName,string hoten, string password, string quyen)
        {
            string sql = "update TaiKhoan set tentaikhoan = N'" + userName + "', hoten= N'" + hoten + "',matkhau= N'" + password + "', quyen= N'" + quyen + "' where tentaikhoan ='" + userName + "'";
            da.excuteQuerry(sql);
        }

        //xóa tài khoản
        public void delteteAccount(string userName)
        {
            string sql = "Delete TaiKhoan where tentaikhoan = N'" + userName + "'";
            da.excuteQuerry(sql);
        }
        //tim kiem
        public DataTable serchNhanVien(string dk, string txt)
        {
            string sql = "Select * From nhanvien Where " + dk + " like '%" + txt + "%'";
            DataTable dtb = da.getTableFromDB(sql);
            return dtb;
        }

        //auto generate id
        public string GetLastID(string nameTable, string nameFiled)
        {
            string sql = "SELECT TOP (1) " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
            return da.getTableFromDB(sql).Rows[0][nameFiled].ToString();
        }
        //cập nhật phòng
        public void capTrangThaiPhong(string maphong)
        {
            string sql = "Update phong set tinhtrang = 1 where maphong = '" + maphong + "'";
             da.excuteQuerry(sql);
        }

        public void capNhatSoLuongPhong(string tenlp, int soluong)
        {
            string sql = "update loaiphong set soluongtrong = soluongtrong - '" + soluong + "'  where tenlp = '" + tenlp + "'";
            da.excuteQuerry(sql);
        }

        public string getTenPhong(string maphong)
        {
            string sql = "select tenlp from phong where maphong = '" + maphong + "'";
            string tenPhong = "";
            DataTable Phong = da.ExecuteQuery(sql);
            foreach (DataRow item in Phong.Rows)
            {
                tenPhong = item["tenlp"].ToString();
            }

            return tenPhong;
        }   
        //cap nhat lai trang thái sau khi trả phòng
        public void capNhatTrangThaiPhongDat(string maphong)
        {
            string sql = "Update phong set tinhtrang = 1 where maphong = '" + maphong + "'";
            da.excuteQuerry(sql);
        }

        public void capNhatTrangThaiPhongTraPhong(string maphong)
        {
            string sql = "Update phong set tinhtrang = 0 where maphong = '" + maphong + "'";
            da.excuteQuerry(sql);
        }
        //cap nhat so luong sau khi tra phong
        public void capNhatSoLuongPhongSauKhiTra (string tenlp)
        {
            string sql = "update loaiphong set soluong = soluong +1 where tenlp = '" + tenlp + "'";
            da.excuteQuerry(sql);
        }
        public DataTable getLoaiPhong()
        {
            string sql = "select * from loaiphong";
            DataTable dtb = da.ExecuteQuery(sql);

            return dtb;
        }

        public DataTable getListPhong(string tenlp)
        {
            string sql = "Select phong.maphong From phong, loaiphong where phong.tenlp = loaiphong.tenlp and loaiphong.tenlp = '" + tenlp + "' and phong.tinhtrang = 'False'";
            DataTable dtb = da.ExecuteQuery(sql);
            return dtb;
        }

        public DataTable getListDatPhong()
        {
            string sql = "select * from datphong";
            DataTable dtb = da.ExecuteQuery(sql);
            return dtb;
        }

        public DataTable getMaNV()
        {
            string sql = "select * from nhanvien";
            DataTable dtb = da.ExecuteQuery(sql);
            return dtb;
        }
    }
}
