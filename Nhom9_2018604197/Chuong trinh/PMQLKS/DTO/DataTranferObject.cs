using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataTranferObject
    {
        //tt nhan vien + tai khoan
        private string manv;
        private string macv;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string sdt;
        private string cmnd;
        private string diachi;
        private string email;
        private string matkhau;
        private string quyen;
        private string tencv;
        string tentaikhoan;
        //tt tai khoan
        string madv;
        string tendv;
        double gia;

        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Macv { get => macv; set => macv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public string Madv { get => madv; set => madv = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public double Gia { get => gia; set => gia = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
    }
}
