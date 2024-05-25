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
    public partial class FrmListMovie : Form
    {
        public FrmListMovie()
        {
            InitializeComponent();
        }
        public Form1 frm1;
        private void btnBook1_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(1); // truyền movie_id vào form movie detail
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(2);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(3);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(4);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(5);
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(6);
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(7);
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(8);
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(9);
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(10);
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(11);
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmMovieDetail frm = new FrmMovieDetail();
            frm.ShowMovieDetail(12);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Close();
        }
    }
}
