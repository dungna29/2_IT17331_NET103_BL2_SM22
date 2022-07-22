using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_3_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Data Source=DUNGNAPC\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=dungna35;Password=123456
        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            string sqlConnectionString = @"Data Source=DUNGNAPC\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=dungna35;Password=123456";
            //1. Khởi tạo kết nối vào csdl
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            //2. Mở kết nối đến
            conn.Open();
            //3. Mở kết nối xóng thì sẽ thực hiện 1 hành động nào đó.
            //4. Khởi tạo 1 câu query với SqlCommand
            string sql = "SELECT * FROM ChucVu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //5. Thực thi và hứng dữ liệu vào SqlDataAdapter
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            //6. Sua khi thực hiện xong hành động thì phải đóng kết nối.
            conn.Close();
        }
    }
}