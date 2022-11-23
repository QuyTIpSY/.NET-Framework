using AppQuanLySinhVien.Model;
using AppQuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Services
{
    internal class LopHocServices
    {
        public static List<LopHocViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.LopHoc.Select(e => new LopHocViewModel
            {
                ID = e.ID,
                TenLop = e.TenLop,
            }).ToList();

            return rs;
        }

        public static List<LopHocViewModel> GetList(int idLopHoc)
        {
            var db = new AppDBContext();
            var rs = db.LopHoc
                .Where(e => e.ID == idLopHoc)
                .Select(e => new LopHocViewModel
                {
                    ID = e.ID,
                    TenLop = e.TenLop,
                }).ToList();

            return rs;
        }

        public static KetQua AddLopHoc(LopHoc l)
        {
            var db = new AppDBContext();
            var count = db.LopHoc.Where(e => e.ID == l.ID).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.LopHoc.Add(l);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua UpdateLop(LopHoc l)
        {
            var db = new AppDBContext();
            var lopHoc = db.LopHoc.Where(e => e.ID == l.ID).FirstOrDefault();
            lopHoc.TenLop = l.TenLop;
            lopHoc.ID = l.ID;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua RemoveLopHoc(LopHocViewModel l)
        {
            var db = new AppDBContext();
            var lopHoc = db.LopHoc.Where(e => e.ID == l.ID).FirstOrDefault();
            db.LopHoc.Remove(lopHoc);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
