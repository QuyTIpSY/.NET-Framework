using AppQuanLySinhVien.Model;
using AppQuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Services
{
    internal class SinhVienService
    {
        public static List<SinhVienViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.SinhVien.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                HoDem = e.HoDem,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh,
                QueQuan = e.QueQuan,
                IDLopHoc = e.IDLopHoc,

            }).ToList();

            return rs;
        }

        public static List<SinhVienViewModel> GetList(int idLopHoc)
        {
            var db = new AppDBContext();
            var rs = db.SinhVien
                .Where(e => e.IDLopHoc == idLopHoc)
                .Select(e => new SinhVienViewModel
                {
                    ID = e.ID,
                    GioiTinh = e.GioiTinh,
                    MaSinhVien = e.MaSinhVien,
                    HoDem = e.HoDem,
                    Ten = e.Ten,
                    NgaySinh = e.NgaySinh,
                    QueQuan = e.QueQuan,
                    IDLopHoc = e.IDLopHoc,

                }).ToList();

            return rs;
        }

        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new AppDBContext();
            var count = db.SinhVien.Where(e => e.MaSinhVien == sv.MaSinhVien).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.SinhVien.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua UpdateSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhVien.Where(e => e.ID == sv.ID).FirstOrDefault();
            sinhVien.Ten = sv.Ten;
            sinhVien.HoDem = sv.HoDem;
            sinhVien.QueQuan = sv.QueQuan;
            sinhVien.GioiTinh = sv.GioiTinh;
            sinhVien.IDLopHoc = sv.IDLopHoc;
            sinhVien.MaSinhVien = sv.MaSinhVien;
            sinhVien.NgaySinh = sv.NgaySinh;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua RemoveSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhVien.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhVien.Remove(sinhVien);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
