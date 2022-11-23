using HelloForm.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            NapDSKhoa();
        }

        void NapDSKhoa()    // Tải ds khoa lên combo box
        {
            var ds = KhoaViewModel.getList();
            cbbKhoa.DataSource = ds;
            cbbKhoa.DisplayMember = "TenKhoa";

        }

        void NapDsGiangVien()
        {
            if(selectedKhoa != null)
            {
                var list = GiangVienViewModel.getByKhoa(selectedKhoa.MaKhoa);
                bdsGiangVien.DataSource = list;
                gridGiangVien.DataSource = bdsGiangVien;
            }
        }

        public KhoaViewModel selectedKhoa
        {
            get
            {
                return cbbKhoa.SelectedItem as KhoaViewModel;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsGiangVien();

        }

        private void btnThongTinGiangVien_Click(object sender, EventArgs e)
        {
            var giangVien = bdsGiangVien.Current as GiangVienViewModel;
            MessageBox.Show($"Xin chào, {(giangVien.GioiTinh?"thầy":"cô")} {giangVien.HoVaTen}");
        }
    }
}
