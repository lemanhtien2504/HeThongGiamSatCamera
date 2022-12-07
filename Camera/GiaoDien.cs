using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void Menu2TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan f = new TaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Menu2DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau f1 = new DoiMatKhau();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void Menu2DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap f2 = new DangNhap();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void btQLDVHC_Click(object sender, EventArgs e)
        {
            QLDonvihanhchinh f3 = new QLDonvihanhchinh();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void btQLCamera_Click(object sender, EventArgs e)
        {
            QLCamera f4 = new QLCamera();
            this.Hide();
            f4.ShowDialog();
        }

        private void btXemCamera_Click(object sender, EventArgs e)
        {
            XemCamera f5 = new XemCamera();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        private void GiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            Application.Exit();
        }
    }
}
