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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignup frmSignup = new FrmSignup();
            frmSignup.form1 = this;
            this.Hide();
            frmSignup.ShowDialog();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kết nối database
            string connectionString = "Server=.\\SQLEXPRESS;Database=cinemabooking;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Console.WriteLine("Kết nối thành công!");
            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và điền dữ liệu vào DataTable

            string query = "SELECT * FROM Account where username = '" + txtUsername.Text.ToString() + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            // Tạo DataTable để lưu trữ dữ liệu 
            DataTable dataTable = new DataTable();
            // Điền dữ liệu vào DataTable
            dataAdapter.Fill(dataTable);
            connection.Close();

            if (dataTable.Rows.Count > 0)//Tìm đc un
            {
                string inputPass = txtPass.Text.ToString(); // pass nhập vào
                string password = dataTable.Rows[0]["password"].ToString(); // lấy từ db
                // Convert sang kiểu dữ liệu int
                //int id = Convert.ToInt32(dataTable.Rows[0]["user_id"].ToString());

                if (!inputPass.Equals(password))
                {
                    MessageBox.Show("Ten dang nhap hoac mat khau khong dung!");
                }
                else
                {
                    FrmListMovie fListMovie = new FrmListMovie();
                    fListMovie.frm1 = this;
                    this.Hide();
                    fListMovie.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Ten dang nhap hoac mat khau khong dung!");
            }
        }
    }
}
