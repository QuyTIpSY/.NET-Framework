using AppQuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.ViewModel
{
    public class LopHocViewModel
    {
        public int ID { get; set; }
        public string TenLop { get; set; }


        /// <summary>
        /// Lấy toàn bộ lớp học
        /// </summary>
        /// <returns></returns>
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
    }
}
