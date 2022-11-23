namespace HelloForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbLabel = new System.Windows.Forms.RadioButton();
            this.rdbMessage = new System.Windows.Forms.RadioButton();
            this.lnkChonMau = new System.Windows.Forms.LinkLabel();
            this.linkChonHinh = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(192, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng tính toán cơ bản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số thứ hai";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(205, 125);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(497, 28);
            this.txtSoThuNhat.TabIndex = 3;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(205, 197);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(497, 28);
            this.txtSoThuHai.TabIndex = 4;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(205, 271);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 41);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(342, 271);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 41);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(479, 271);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 41);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(627, 271);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 41);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(299, 347);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(24, 27);
            this.lbKetQua.TabIndex = 10;
            this.lbKetQua.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hiển thị kết quả";
            // 
            // rdbLabel
            // 
            this.rdbLabel.AutoSize = true;
            this.rdbLabel.Location = new System.Drawing.Point(174, 415);
            this.rdbLabel.Name = "rdbLabel";
            this.rdbLabel.Size = new System.Drawing.Size(108, 25);
            this.rdbLabel.TabIndex = 13;
            this.rdbLabel.TabStop = true;
            this.rdbLabel.Text = "Tên Label";
            this.rdbLabel.UseVisualStyleBackColor = true;
            this.rdbLabel.CheckedChanged += new System.EventHandler(this.rdbLabel_CheckedChanged);
            // 
            // rdbMessage
            // 
            this.rdbMessage.AutoSize = true;
            this.rdbMessage.Location = new System.Drawing.Point(368, 413);
            this.rdbMessage.Name = "rdbMessage";
            this.rdbMessage.Size = new System.Drawing.Size(162, 25);
            this.rdbMessage.TabIndex = 14;
            this.rdbMessage.TabStop = true;
            this.rdbMessage.Text = "Tên messageBox";
            this.rdbMessage.UseVisualStyleBackColor = true;
            // 
            // lnkChonMau
            // 
            this.lnkChonMau.AutoSize = true;
            this.lnkChonMau.Location = new System.Drawing.Point(17, 484);
            this.lnkChonMau.Name = "lnkChonMau";
            this.lnkChonMau.Size = new System.Drawing.Size(89, 21);
            this.lnkChonMau.TabIndex = 15;
            this.lnkChonMau.TabStop = true;
            this.lnkChonMau.Text = "Chọn màu";
            this.lnkChonMau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChonMau_LinkClicked);
            // 
            // linkChonHinh
            // 
            this.linkChonHinh.AutoSize = true;
            this.linkChonHinh.Location = new System.Drawing.Point(234, 484);
            this.linkChonHinh.Name = "linkChonHinh";
            this.linkChonHinh.Size = new System.Drawing.Size(89, 21);
            this.linkChonHinh.TabIndex = 16;
            this.linkChonHinh.TabStop = true;
            this.linkChonHinh.Text = "Chọn hình";
            this.linkChonHinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChonHinh_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 583);
            this.Controls.Add(this.linkChonHinh);
            this.Controls.Add(this.lnkChonMau);
            this.Controls.Add(this.rdbMessage);
            this.Controls.Add(this.rdbLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbLabel;
        private System.Windows.Forms.RadioButton rdbMessage;
        private System.Windows.Forms.LinkLabel lnkChonMau;
        private System.Windows.Forms.LinkLabel linkChonHinh;
    }
}

