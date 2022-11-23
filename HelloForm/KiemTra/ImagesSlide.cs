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
    public partial class ImagesSlide : Form
    {
        IEnumerable<string> images;
        int soGiay;
        bool laplai;
        bool ngaunhien;
        List<string> imagesList = new List<string>();
        string[] imagesArray;

        public ImagesSlide(IEnumerable<string> images, int soGiay, bool laplai, bool ngaunhien)
        {
            InitializeComponent();
            this.images = images;
            this.soGiay = soGiay;
            this.laplai = laplai;
            this.ngaunhien = ngaunhien;
            imagesList = images.ToList();
            imagesArray = images.ToArray();


            timer1.Interval = soGiay * 1000;
            timer1.Start();
        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (laplai)
            {
                if (ngaunhien)
                {
                    Random random = new Random();
                    i = random.Next(0, images.ToArray().Length);
                    pictureBox1.ImageLocation = imagesArray[i];
                }
                else
                {
                    if (i >= images.ToArray().Length) i = 0;
                    pictureBox1.ImageLocation = images.ToArray()[i];
                    i++;
                }
            }
            else if (ngaunhien)
            {
                if (imagesList.Count == 0) timer1.Stop();
                Random random = new Random();
                i = random.Next(0, images.ToArray().Length);
                pictureBox1.ImageLocation = imagesArray[i];
                imagesList.Remove(images.ToArray()[i]);
                //MessageBox.Show(i.ToString());
            }
            else
            {
                if (i == images.ToArray().Length - 1) timer1.Stop();
                pictureBox1.ImageLocation = images.ToArray()[i];
                i++;
            }
        }
    }
}
