using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.ViewModel;

namespace WindowsFormsApp1.Services
{
    internal class MayTinhServices
    {
        public static List<MayTinhViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.KetQua.Select(e => new MayTinhViewModel
            {
                KetQua = e.ketqua,
            }).ToList();

            return rs;
        }
    }
}
