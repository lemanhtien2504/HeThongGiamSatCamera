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
    public partial class XemCamera : Form
    {
        public XemCamera()
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
            dataGridView1.DataSource = data;
        }
        private void XemCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void XemCamera_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["Camera"].ConnectionString.ToString();
            con = new MySqlConnection(conString);
            con.Open();
            Xem();
        }
    }
}
