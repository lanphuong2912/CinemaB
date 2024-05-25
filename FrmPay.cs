using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBooking
{
    public partial class FrmPay : Form
    {
        public FrmPay()
        {
            InitializeComponent();
        }

        public void PassValue(string movieName, string cinemaName, List<string> seatNames, string money, DateTime start)
        {
            txtCinema.Text = cinemaName;
            txtMovieName.Text = movieName;
            txtMoney.Text = money;
            txtSeat.Text = String.Join(", ", seatNames.ToArray());  // gộp các phần tử trong mảng thành một chuỗi ngăn cách bằng dấu ", "
            txtStart.Text = start.ToString();
            txtEnd.Text = start.AddHours(2).ToString(); // thêm 2 giờ 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
