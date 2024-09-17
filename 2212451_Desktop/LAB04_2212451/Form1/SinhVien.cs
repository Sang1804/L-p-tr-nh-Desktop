using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop {  get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        
        public SinhVien()
        {

        }

        public SinhVien(string mssv, string ht, bool gt, DateTime ngay,string lop, string dienthoai, string email, string dc, string hinh)
        {
            this.MSSV = mssv;
            this.HoTen = ht;
            this.Phai = gt;
            this.NgaySinh = ngay;
            this.Lop = lop;
            this.SDT = dienthoai;
            this.Email = email;
            this.DiaChi = dc;
            this.Hinh = hinh;
        }
    }
}
