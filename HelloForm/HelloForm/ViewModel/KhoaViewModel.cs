using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloForm.ViewModel
{
    public class KhoaViewModel
    {
        public int MaKhoa {get; set;}
        public string TenKhoa {get; set;}

        public static List<KhoaViewModel> getList()
        {
            var list = new List<KhoaViewModel>();
            list.Add(new KhoaViewModel { MaKhoa = 1, TenKhoa = "CNTT" });
            list.Add(new KhoaViewModel { MaKhoa = 2, TenKhoa = "ĐTVT" });
            list.Add(new KhoaViewModel { MaKhoa = 3, TenKhoa = "Văn" });
            list.Add(new KhoaViewModel { MaKhoa = 4, TenKhoa = "Báo Chí" });
            list.Add(new KhoaViewModel { MaKhoa = 5, TenKhoa = "Môi Trường" });
            list.Add(new KhoaViewModel { MaKhoa = 6, TenKhoa = "Hóa Học" });

            return list;
        }
    }
}
