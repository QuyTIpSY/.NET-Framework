using AppQuanLySinhVien.Model;
using AppQuanLySinhVien.Services;
using AppQuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        SinhVienViewModel sinhVien;
        public frmSinhVien(SinhVienViewModel sinhVien = null)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
            if(sinhVien != null)
            {
                cbmLopHoc.SelectedValue = sinhVien.IDLopHoc;
                txtMaSinhVien.Text = sinhVien.MaSinhVien;
                txtHoDem.Text = sinhVien.HoDem;
                txtTen.Text = sinhVien.Ten;
                txtNgaySinh.Value = sinhVien.NgaySinh?? DateTime.Now;
                if(sinhVien.GioiTinh == 0)
                {
                    rdbNam.Checked = true;
                }
                else if (sinhVien.GioiTinh == 1)
                {
                    rdbNu.Checked = true;
                }
                else
                {
                    rdbKhac.Checked = true;
                }
                txtQueQuan.Text = sinhVien.QueQuan;
            }
            NapDSLopHoc();
        }

        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbmLopHoc.SelectedItem as LopHocViewModel;
            }
        }
        
        void NapDSLopHoc()
        {
            var ls = LopHocViewModel.GetList();
            cbmLopHoc.DataSource = ls;
            cbmLopHoc.DisplayMember = "TenLop";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(this.sinhVien == null)
            {
                #region Thêm mới sinh viên
                var sv = new SinhVien
                {
                    HoDem = txtHoDem.Text,
                    Ten = txtTen.Text,
                    QueQuan = txtQueQuan.Text,
                    NgaySinh = txtNgaySinh.Value,
                    MaSinhVien = txtMaSinhVien.Text,
                    IDLopHoc = selectedLopHoc.ID,
                    GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2),
                };
                if (SinhVienService.AddSinhVien(sv) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                    txtMaSinhVien.Focus();
                }
                #endregion
            }
            else
            {
                #region Cập nhật thông tin sinh viên
                sinhVien.QueQuan = txtQueQuan.Text;
                sinhVien.HoDem = txtHoDem.Text;
                sinhVien.Ten = txtTen.Text;
                sinhVien.NgaySinh = txtNgaySinh.Value;
                sinhVien.GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2);
                sinhVien.MaSinhVien = txtMaSinhVien.Text;
                sinhVien.IDLopHoc = selectedLopHoc.ID;
                SinhVienService.UpdateSinhVien(sinhVien);
                DialogResult = DialogResult.OK;

                #endregion
            }
        }
    }
}
