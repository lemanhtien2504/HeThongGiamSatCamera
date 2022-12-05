using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            GiaoDien a = new GiaoDien();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DangNhap b = new DangNhap();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            
            Application.Exit();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["Camera"].ConnectionString.ToString();
            con = new MySqlConnection(conString);
            con.Open();
            string strMatKhauCu = txtMatKhauCu.Text;
            string strMatKhauMoi = txtMatKhauMoi.Text;
            string strNhapLaiMatKhau = txtNhapLaiMatKhau.Text;
            if (strMatKhauMoi == strNhapLaiMatKhau)
            {
                string mysqlUpdate = "UPDATE taikhoan SET '" + passwordMd5.CreateMD5(strMatKhauMoi).ToUpper() + "' = @matkhau WHERE '" + passwordMd5.CreateMD5(strMatKhauCu).ToUpper() + "' = @matkhau";
                MySqlCommand command = new MySqlCommand(mysqlUpdate, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng", "Lỗi");
            }    
        }

        private void Menu2TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan c = new TaiKhoan();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void Menu2DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau d = new DoiMatKhau();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }

        private void Menu2DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap g = new DangNhap();
            this.Hide();
            g.ShowDialog();
            this.Show();
        }
    }
}
