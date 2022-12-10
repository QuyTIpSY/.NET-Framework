using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MayTinhEntities db = new MayTinhEntities();
        public Form1()
        {
            InitializeComponent();
            click();
            list = new List<string>();
            LoadData();
        }
        List<Button> buttons;
        List<string> list;

        private void click()
        {
            buttons = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, };
            foreach (var item in buttons)
            {
                item.Click += new EventHandler(buttonClick);
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            String text = ((Button)sender).Text;
            txtscreen.Text += text;
            //enablebtn();
        }

        private void tinhtoan()
        {
            if (list.Contains("+"))
            {
                list.Remove("+");
                double s = Convert.ToDouble(list[0]) + Convert.ToDouble(list[1]);
                txtscreen.Text = s.ToString();
                txtres.Text = s.ToString(); 
                AddData(s);
                LoadData();
            }
            else
            {
                if (list.Contains("-"))
                {
                    list.Remove("-");
                    double s = Convert.ToDouble(list[0]) - Convert.ToDouble(list[1]);
                    txtscreen.Text = s.ToString();
                    txtres.Text = s.ToString();
                    AddData(s);
                    LoadData();
                }
                else
                {
                    if (list.Contains("x"))
                    {
                        list.Remove("x");
                        double s = Convert.ToDouble(list[0]) * Convert.ToDouble(list[1]);
                        txtscreen.Text = s.ToString();
                        txtres.Text = s.ToString();
                        AddData(s);
                        LoadData();
                    }
                    else
                    {
                        if (list.Contains(":"))
                        {
                            list.Remove(":");
                            double s = Convert.ToDouble(list[0]) / Convert.ToDouble(list[1]);
                            txtscreen.Text = s.ToString();
                            txtres.Text = s.ToString();
                            AddData(s);
                            LoadData();
                        }
                    }
                }
            }
        }
        
        void LoadData()
        {
            //MayTinhEntities db = new MayTinhEntities();
            dataGridView1.DataSource = db.KetQua.ToList();
        }

        void AddData(double res)
        {
            {
                string tmp=res.ToString();
                KetQua kq = new KetQua() { LichSuTinhToan = tmp };
                db.KetQua.Add(kq);
                db.SaveChanges();
            }         
        }

        private void enablebtn()
        {
            btncong.Enabled = true;
            btntru.Enabled = true;
            btnnhan.Enabled = true;
            btnchia.Enabled = true;
        }

        private void disnablebtn()
        {
            btncong.Enabled = false;
            btntru.Enabled = false;
            btnnhan.Enabled = false;
            btnchia.Enabled = false;
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                list.Add(btncong.Text);
                txtscreen.Text = "";
                disnablebtn();
            }
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                tinhtoan();
                list.Clear();
                enablebtn();
            }
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                list.Add(btntru.Text);
                txtscreen.Text = "";
                disnablebtn();
            }
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                list.Add(btnnhan.Text);
                txtscreen.Text = "";
                disnablebtn();
            }
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text != "")
            {
                list.Add(txtscreen.Text);
                list.Add(btnchia.Text);
                txtscreen.Text = "";
                disnablebtn();
            }
        }

        private void btnxoaall_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "";
            txtres.Text = "";
            list.Clear();
            enablebtn();
            txtscreen.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
