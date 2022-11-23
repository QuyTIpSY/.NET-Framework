using System.Collections;

namespace SliderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            FolderBrowserDialog dialog = new FolderBrowserDialog(); 
            var rs = dialog.ShowDialog(); // chọn thư mục
            if (rs== DialogResult.OK)
            {
                txtFolderPath.Text = dialog.SelectedPath; // hiển thị thư mục
                lsvListFile.Items.Clear(); // xóa sạch listview trước khi hiển thị dữ liệu
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath); // lấy thông tin thư mục 
                var listFile = directory.GetFiles(); // lấy thông tin thư mục có đuôi là png, jpg... 
                foreach(var file in listFile) // duyệt hết file trong list đó
                {
                    if (exts.Contains(file.Extension.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.FullName); // lấy tên
                        //item.SubItems.Add(file.Length.ToString()); // lấy đường dẫn
                        lsvListFile.Items.Add(item); // gán item vào list view
                        String[] arr = new String[100];
                        arr[i] = item.SubItems.Add(file.Length.ToString());
                    }          
                }
            }
        }

        private void lsvListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lsvListFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lsvListFile.SelectedItems[0]; // lấy đường dẫn 
            var imagePath = selectedItem.SubItems[1].Text; // lấy path 
            ImageForm f = new ImageForm(imagePath);
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var rs = dialog.ShowDialog(); // chọn thư mục
            if (rs == DialogResult.OK)
            {
                txtFolderPath.Text = dialog.SelectedPath; // hiển thị thư mục
                lsvListFile.Items.Clear(); // xóa sạch listview trước khi hiển thị dữ liệu
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath); // lấy thông tin thư mục
                var listFile = directory.GetFiles(); // lấy thông tin thư mục có đuôi là png, jpg... 
                int i = 0;  
                foreach (var file in listFile) // duyệt hết file trong list đó
                {
                    if (exts.Contains(file.Extension.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.FullName); // lấy tên
                        item.SubItems.Add(file.Length.ToString()); // lấy đường dẫn
                        lsvListFile.Items.Add(item); // gán item vào list view
                        String[] arr = new String[100];
                        arr[i] = item.SubItems.Add(file.Length.ToString());
                    }
                }
            }
        }
    }
}