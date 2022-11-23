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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSLopHoc();
            NapDSSinhVien();
        }

        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbbLopHoc.SelectedItem as LopHocViewModel;
            }
        }
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return sinhVienViewModelBindingSource.Current as SinhVienViewModel;
            }
            ////get
            ////{
            ////    return dataGridView1.SelectedRows[0][0] as String;
            ////}
        }

        void NapDSLopHoc()
        {
            var ls = LopHocViewModel.GetList();
            cbbLopHoc.DataSource = ls;
            cbbLopHoc.ValueMember = "ID";
            cbbLopHoc.DisplayMember = "TenLop";
        }

        void NapDSSinhVien()
        {
            if(selectedLopHoc != null)
            {
                var ls = SinhVienService.GetList(selectedLopHoc.ID);
                sinhVienViewModelBindingSource.DataSource = ls;
                dataGridView1.DataSource = sinhVienViewModelBindingSource;
            }
            
        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDSSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra MSV trung hay không
            // MSV, Họ, Tên, không được để trống
            var f = new frmSinhVien();
            var rs =  f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapDSSinhVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(selectedSinhVien != null)
            {
                var f = new frmSinhVien(selectedSinhVien);
                if(f.ShowDialog() == DialogResult.OK)
                {
                    NapDSSinhVien();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(selectedSinhVien != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {
                    SinhVienService.RemoveSinhVien(selectedSinhVien);
                    NapDSSinhVien();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
