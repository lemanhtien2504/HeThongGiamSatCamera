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
    public partial class QLCamera : Form
    {
        public QLCamera()
        {
            InitializeComponent();
        }

        MySqlConnection con;

        public void Xem()
        {
            string query = "SELECT * FROM camera";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            DgviewDanhSachCamera.DataSource = data;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QLCamera_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["Camera"].ConnectionString.ToString();
            con = new MySqlConnection(conString);
            con.Open();
            Xem();
        }

        private void Menu2DangXuat_Click(object sender, EventArgs e)
        {

        }

        private void QLCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            con.Close();
            Application.Exit();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mysqlInsert = "INSERT INTO camera VALUES ('', @ten, @RtspUrl, @vitri, @ghichu)";
            MySqlCommand command = new MySqlCommand(mysqlInsert, con);
            
            command.Parameters.AddWithValue("ten", txtTenCamera.Text);
            command.Parameters.AddWithValue("RtspUrl", txtRtspUrl.Text);
            command.Parameters.AddWithValue("vitri", txtViTri.Text);
            command.Parameters.AddWithValue("ghichu", txtGhiChu.Text);
            command.ExecuteNonQuery();
            Xem();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string mysqlUpdate = "UPDATE camera SET ten = @ten, RtspUrl = @RtspUrl, vitri = @vitri, ghichu = @ghichu WHERE id = @id";
            MySqlCommand command = new MySqlCommand(mysqlUpdate, con);
            command.Parameters.AddWithValue("id", txtMa.Text);
            command.Parameters.AddWithValue("ten", txtTenCamera.Text);
            command.Parameters.AddWithValue("RtspUrl", txtRtspUrl.Text);
            command.Parameters.AddWithValue("vitri", txtViTri.Text);
            command.Parameters.AddWithValue("ghichu", txtGhiChu.Text);
            command.ExecuteNonQuery();
            Xem();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string mysqlDelete = "DELETE FROM camera WHERE id = @id";
            MySqlCommand command = new MySqlCommand(mysqlDelete, con);
            command.Parameters.AddWithValue("id", txtMa.Text);
            command.Parameters.AddWithValue("ten", txtTenCamera.Text);
            command.Parameters.AddWithValue("RtspUrl", txtRtspUrl.Text);
            command.Parameters.AddWithValue("vitri", txtViTri.Text);
            command.Parameters.AddWithValue("ghichu", txtGhiChu.Text);
            command.ExecuteNonQuery();
            Xem();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string mysqlSearch = "SELECT * FROM camera WHERE id = @id OR ten = @ten OR RtspUrl = @RtspUrl OR vitri = @vitri OR ghichu = @ghichu";
            MySqlCommand command = new MySqlCommand(mysqlSearch, con);
            command.Parameters.AddWithValue("id", txtMa.Text);
            command.Parameters.AddWithValue("ten", txtTenCamera.Text);
            command.Parameters.AddWithValue("RtspUrl", txtRtspUrl.Text);
            command.Parameters.AddWithValue("vitri", txtViTri.Text);
            command.Parameters.AddWithValue("ghichu", txtGhiChu.Text);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            DgviewDanhSachCamera.DataSource = data;
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            GiaoDien f = new GiaoDien();
            this.Hide();
            f.ShowDialog();
        }

        private void Menu2QLDVHC_Click(object sender, EventArgs e)
        {
            QLDonvihanhchinh f = new QLDonvihanhchinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Menu2QLCamera_Click(object sender, EventArgs e)
        {
            QLCamera f = new QLCamera();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Menu2XemCamera_Click(object sender, EventArgs e)
        {
            XemCamera f = new XemCamera();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void DgviewDanhSachCamera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.DgviewDanhSachCamera.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTenCamera.Text = row.Cells[1].Value.ToString();
                txtRtspUrl.Text = row.Cells[2].Value.ToString();
                txtViTri.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
