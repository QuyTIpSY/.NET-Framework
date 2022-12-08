using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            click();
            list = new List<string>();
        }
        List<Button> buttons;
        List<string> list;
        private void click()
        {
            buttons = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var item in buttons)
            {
                item.Click += new EventHandler(buttonClick);
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            String text = ((Button)sender).Text;
            txtscreen.Text += text;
        }

        void DSKetQua()
        {
            var ds = MayTinhServices.GetList();
           
        }
        private void cong()
        {
            if (list.Contains("+"))
            {
                list.Remove("+");
                double s = Convert.ToDouble(list[0]) + Convert.ToDouble(list[1]);
                txtscreen.Text = s.ToString();
            }
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                list.Add(btncong.Text);
                txtscreen.Text = "";
            }
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                cong();
            }
        }
    }
}
