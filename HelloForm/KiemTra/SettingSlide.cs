using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class SettingSlide : Form
    {
        public int soGiay;
        public bool laplai;
        public bool ngaunhien;

        public SettingSlide()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soGiay = (int)numericUpDown1.Value;
            laplai = cblaplai.Checked;
            ngaunhien = cblapngaunhien.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
