namespace KiemTra
{
    partial class SettingSlide
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
            this.cblapngaunhien = new System.Windows.Forms.CheckBox();
            this.cblaplai = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian chuyển slide (s):";
            // 
            // cblapngaunhien
            // 
            this.cblapngaunhien.AutoSize = true;
            this.cblapngaunhien.Location = new System.Drawing.Point(23, 100);
            this.cblapngaunhien.Name = "cblapngaunhien";
            this.cblapngaunhien.Size = new System.Drawing.Size(132, 24);
            this.cblapngaunhien.TabIndex = 1;
            this.cblapngaunhien.Text = "Lặp ngẫu nhiên";
            this.cblapngaunhien.UseVisualStyleBackColor = true;
            // 
            // cblaplai
            // 
            this.cblaplai.AutoSize = true;
            this.cblaplai.Location = new System.Drawing.Point(23, 70);
            this.cblaplai.Name = "cblaplai";
            this.cblaplai.Size = new System.Drawing.Size(75, 24);
            this.cblaplai.TabIndex = 1;
            this.cblaplai.Text = "Lặp lại";
            this.cblaplai.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(220, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy bỏ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 209);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cblaplai);
            this.Controls.Add(this.cblapngaunhien);
            this.Controls.Add(this.label1);
            this.Name = "SettingSlide";
            this.Text = "SettingSlide";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox cblapngaunhien;
        private CheckBox cblaplai;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
    }
}