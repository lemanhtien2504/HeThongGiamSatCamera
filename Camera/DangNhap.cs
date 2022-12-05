using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Configuration;

namespace Camera
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e. Cancel= true;
            con.Close();
            Application.Exit();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["Camera"].ConnectionString.ToString();
            con = new MySqlConnection(conString);
            con.Open();
            string userName = txtTaiKhoan.Text;
            string passWord = txtMatKhau.Text;

            string query = "SELECT * FROM taikhoan WHERE taikhoan = '" + userName + "' AND matkhau = '" + passwordMd5.CreateMD5(passWord).ToUpper() + "'";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read()==true)
            {
                GiaoDien f = new GiaoDien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }  
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }    
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
