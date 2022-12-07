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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        public void Xem()
        {
            string query = "SELECT * FROM taikhoan";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);

        }

        private void btTao_Click(object sender, EventArgs e)
        {
            
            string strNhapLaiPass = txtNhapLaiMatKhau.Text;
            string conString = ConfigurationManager.ConnectionStrings["Camera"].ConnectionString.ToString();
            con = new MySqlConnection(conString);
            con.Open();
            string strInsert = "INSERT INTO taikhoan VALUES ('', @ten, @taikhoan, @matkhau)";
            MySqlCommand command = new MySqlCommand(strInsert, con);            
            command.Parameters.AddWithValue("ten", txtTenHienThi.Text);
            command.Parameters.AddWithValue("taikhoan", txtTaiKhoan.Text);
            string strPassword = txtMatKhau.Text;
            if (strPassword == strNhapLaiPass)
            {


                command.Parameters.AddWithValue("matkhau", passwordMd5.CreateMD5(strPassword));
                command.ExecuteNonQuery();
                Xem();
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại, mật khẩu không chính xác!", "Thông báo");
            }    
            con.Close();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            GiaoDien f = new GiaoDien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DangNhap f1 = new DangNhap();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void TaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            
            Application.Exit();
        }
    }
}
