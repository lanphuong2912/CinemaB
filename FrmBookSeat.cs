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
    public partial class FrmBookSeat : Form
    {
        public FrmBookSeat()
        {
            InitializeComponent();
            AddSeat();
        }

        public FrmMovieDetail frmMovieDetail;

        public int money = 0;
        public DateTime timeStart;
        public string cinemaName;
        public string movieName;
        public List<string> seatNames = new List<string>(); // lưu số ghế đã chọn
        public void AddSeat()
        {
            for (char c = 'A'; c <= 'F'; c++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string seatName = c + i.ToString();
                    Button btn = new Button() { Width = 62, Height = 48, Text = seatName };
                    btn.BackColor = Color.White;
                    btn.Click += SeatClick; // set hàm khi click vào button
                    flPn1.Controls.Add(btn); // thêm button vào flow panel
                }
            }
        }

        public void SeatClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Text.ToString();
            // bỏ chọn ghế
            if (button.BackColor.Equals(Color.Gray))
            {
                button.BackColor = Color.White;
                seatNames.Remove(name); // remove ghế đã chọn
                money = money - 125000;
            } else // chọn ghế
            {
                button.BackColor = Color.Gray;
                money = money + 125000;
                seatNames.Add(name); // thêm ghế vào danh sách đã chọn
            }
           
            lbMoney.Text = money.ToString() + " VNĐ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmMovieDetail.Show(); ;
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FrmPay frmPay = new FrmPay();
            frmPay.PassValue(movieName, cinemaName,seatNames, money.ToString(), timeStart);
            frmPay.ShowDialog();
            this.Close();


        }
    }
}
