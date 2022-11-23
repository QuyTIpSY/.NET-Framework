using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            lbdongho.Text = convert(count);
            if(count == 0)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                button1.Enabled = false;
                timer1.Start();
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
        }
        int soPhut = 0;
        private void btncaidat_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            var rs = f.ShowDialog();
            if(rs== DialogResult.OK)
            {
                count = f.SoPhut * 60;
                lbdongho.Text = convert(count);
            }
        }

        string convert(int soGiay)
        {
            int p = soGiay / 60;
            int s = soGiay % 60;
            return $"{p:0#}:{s:0#}";
        }
    }
}
