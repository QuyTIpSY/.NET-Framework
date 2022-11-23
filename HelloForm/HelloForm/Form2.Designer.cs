namespace HelloForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.gridGiangVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongTinGiangVien = new System.Windows.Forms.Button();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.maGiangVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gioiTinhStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(58, 12);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(192, 28);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // gridGiangVien
            // 
            this.gridGiangVien.AutoGenerateColumns = false;
            this.gridGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiangVienDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.hoVaTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.gioiTinhStrDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn,
            this.HoVaTen});
            this.gridGiangVien.DataSource = this.giangVienViewModelBindingSource;
            this.gridGiangVien.Location = new System.Drawing.Point(11, 85);
            this.gridGiangVien.Name = "gridGiangVien";
            this.gridGiangVien.RowHeadersWidth = 62;
            this.gridGiangVien.RowTemplate.Height = 28;
            this.gridGiangVien.Size = new System.Drawing.Size(1269, 505);
            this.gridGiangVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách Giảng viên";
            // 
            // btnThongTinGiangVien
            // 
            this.btnThongTinGiangVien.Location = new System.Drawing.Point(1093, 44);
            this.btnThongTinGiangVien.Name = "btnThongTinGiangVien";
            this.btnThongTinGiangVien.Size = new System.Drawing.Size(187, 35);
            this.btnThongTinGiangVien.TabIndex = 4;
            this.btnThongTinGiangVien.Text = "Thông tin Giảng Viên";
            this.btnThongTinGiangVien.UseVisualStyleBackColor = true;
            this.btnThongTinGiangVien.Click += new System.EventHandler(this.btnThongTinGiangVien_Click);
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "HoVaTen";
            this.HoVaTen.MinimumWidth = 8;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            this.HoVaTen.Width = 150;
            // 
            // maGiangVienDataGridViewTextBoxColumn
            // 
            this.maGiangVienDataGridViewTextBoxColumn.DataPropertyName = "MaGiangVien";
            this.maGiangVienDataGridViewTextBoxColumn.HeaderText = "MaGiangVien";
            this.maGiangVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maGiangVienDataGridViewTextBoxColumn.Name = "maGiangVienDataGridViewTextBoxColumn";
            this.maGiangVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Ho";
            this.hoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            this.hoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoVaTenDataGridViewTextBoxColumn
            // 
            this.hoVaTenDataGridViewTextBoxColumn.DataPropertyName = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.HeaderText = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoVaTenDataGridViewTextBoxColumn.Name = "hoVaTenDataGridViewTextBoxColumn";
            this.hoVaTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoVaTenDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.Width = 150;
            // 
            // gioiTinhStrDataGridViewTextBoxColumn
            // 
            this.gioiTinhStrDataGridViewTextBoxColumn.DataPropertyName = "GioiTinhStr";
            this.gioiTinhStrDataGridViewTextBoxColumn.HeaderText = "GioiTinhStr";
            this.gioiTinhStrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhStrDataGridViewTextBoxColumn.Name = "gioiTinhStrDataGridViewTextBoxColumn";
            this.gioiTinhStrDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhStrDataGridViewTextBoxColumn.Width = 150;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            this.queQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.Width = 150;
            // 
            // giangVienViewModelBindingSource
            // 
            this.giangVienViewModelBindingSource.DataSource = typeof(HelloForm.ViewModel.GiangVienViewModel);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 602);
            this.Controls.Add(this.btnThongTinGiangVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridGiangVien);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.DataGridView gridGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giangVienViewModelBindingSource;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private System.Windows.Forms.Button btnThongTinGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
    }
}