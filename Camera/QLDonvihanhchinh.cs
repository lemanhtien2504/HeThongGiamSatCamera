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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Camera
{
    public partial class QLDonvihanhchinh : Form
    {
        public QLDonvihanhchinh()
        {
            InitializeComponent();
            
        }
        MySqlConnection con;
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu2DangXuat_Click(object sender, EventArgs e)
        {

        }

        private void Menu2TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan f = new TaiKhoan();
            this.Hide();
            f.ShowDialog();
        }

        private void Menu2DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau f1 = new DoiMatKhau();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void Menu2DangXuat_Click_1(object sender, EventArgs e)
        {
            DangNhap f2 = new DangNhap();
            this.Hide();
            f2.ShowDialog();
        }

        private void Menu2QLDVHC_Click(object sender, EventArgs e)
        {
            QLDonvihanhchinh f3 = new QLDonvihanhchinh();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void Menu2QLCamera_Click(object sender, EventArgs e)
        {
            QLCamera f4 = new QLCamera();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void Menu2XemCamera_Click(object sender, EventArgs e)
        {
            XemCamera f5 = new XemCamera();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            
            GiaoDien f6 = new GiaoDien();
            this.Hide();
            f6.ShowDialog();
            this.Show();
        }

        private void QLDonvihanhchinh_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["Camera"].ConnectionString.ToString();
            con = new MySqlConnection(conString);
            con.Open();
            Xem();
        } 

        public void Xem()
        {
            string query = "SELECT * FROM donvihanhchinh";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView1.DataSource = data;
        }
        private void QLDonvihanhchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            con.Close();
            Application.Exit();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mysqlInsert = "INSERT INTO donvihanhchinh VALUES ('', @TinhTp, @QuanHuyen, @PhuongXa)";
            MySqlCommand command = new MySqlCommand(mysqlInsert, con);
            command.Parameters.AddWithValue("TinhTp", txtTinhTp.Text);
            command.Parameters.AddWithValue("QuanHuyen", txtQuanHuyen.Text);
            command.Parameters.AddWithValue("PhuongXa", txtPhuongXa.Text);
            command.ExecuteNonQuery();
            Xem();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string mysqlUpdate = "UPDATE donvihanhchinh SET TinhTp = @TinhTp, QuanHuyen = @QuanHuyen, PhuongXa = @PhuongXa WHERE id = @id";
            MySqlCommand command = new MySqlCommand(mysqlUpdate, con);
            command.Parameters.AddWithValue("id", txtMa.Text);
            command.Parameters.AddWithValue("TinhTp", txtTinhTp.Text);
            command.Parameters.AddWithValue("QuanHuyen", txtQuanHuyen.Text);
            command.Parameters.AddWithValue("PhuongXa", txtPhuongXa.Text);
            command.ExecuteNonQuery();
            Xem();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string mysqlDelete = "DELETE FROM donvihanhchinh WHERE id = @id";
            MySqlCommand command = new MySqlCommand(mysqlDelete, con);
            command.Parameters.AddWithValue("id", txtMa.Text);
            command.Parameters.AddWithValue("TinhTp", txtTinhTp.Text);
            command.Parameters.AddWithValue("QuanHuyen", txtQuanHuyen.Text);
            command.Parameters.AddWithValue("PhuongXa", txtPhuongXa.Text);
            command.ExecuteNonQuery();
            Xem();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string mysqlSearch = "SELECT * FROM donvihanhchinh WHERE id = @id OR TinhTp = @TinhTp OR QuanHuyen = @QuanHuyen OR PhuongXa = @PhuongXa";
            MySqlCommand command = new MySqlCommand(mysqlSearch, con);
            command.Parameters.AddWithValue("id", txtMa.Text);
            command.Parameters.AddWithValue("TinhTp", txtTinhTp.Text);
            command.Parameters.AddWithValue("QuanHuyen", txtQuanHuyen.Text);
            command.Parameters.AddWithValue("PhuongXa", txtPhuongXa.Text);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTinhTp.Text = row.Cells[1].Value.ToString();
                txtQuanHuyen.Text = row.Cells[2].Value.ToString();
                txtPhuongXa.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
