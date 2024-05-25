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

namespace CinemaBooking
{
    public partial class FrmSignup : Form
    {
        public FrmSignup()
        {
            InitializeComponent();
        }

        public Form1 form1;

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=cinemabooking;Trusted_Connection=True;Connect Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Console.WriteLine("Kết nối thành công!");
            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và điền dữ liệu vào DataTable

            String query = "SELECT * FROM Account where username = '" + txtUsername.Text.ToString() + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            // Tạo DataTable để lưu trữ dữ liệu 
            DataTable dataTable = new DataTable();
            // Điền dữ liệu vào DataTable
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                connection.Close();
                MessageBox.Show(txtUsername.Text.ToString() + " đã có người sử dụng!");
            }
            else
            {
                if (!txtPass.Text.Equals(txtConfirm.Text))
                {
                    connection.Close();
                    MessageBox.Show("Mật khẩu xác nhận không đúng!");
                    return;
                }
                query = $"INSERT into Account (displayName, username, password) Values('{txtDisplayName.Text.ToString()}', '{txtUsername.Text.ToString()}', '{txtPass.Text.ToString()}')";

                SqlCommand cmd = new SqlCommand(query, connection);
                int k = cmd.ExecuteNonQuery(); // thực hiện query trả về số dòng ảnh hưởng
                if (k > 0)
                {
                    connection.Close();
                    form1.Show();
                    this.Close();
                }
            }
        }

        private void FrmSignup_Load(object sender, EventArgs e)
        {

        }
    }
}
