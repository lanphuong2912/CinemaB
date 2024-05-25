using CinemaBooking.DTO;
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
    public partial class FrmMovieDetail : Form
    {
        public List<Movie> movies = new List<Movie>();
        public FrmMovieDetail()
        {
            InitializeComponent();
            AddMovieToList();
            
            cmbCinema.Items.Add("CGV Trần Duy Hưng");
            cmbCinema.Items.Add("CGV TimeCity");
            cmbCinema.Items.Add("CGV Bà Triệu");
            cmbCinema.Items.Add("CGV Royal City");
            cmbCinema.SelectedIndex = 0;
        }

        public int movie_id = 0;

        public void AddMovieToList()
        {
            Movie m1 = new Movie(1, "Doraemon", Properties.Resources.doraemon, "Doraemon: Nobita và bản giao hưởng Địa Cầu là bộ phim điện ảnh thứ 43 trong loạt phim điện ảnh Doraemon. Bộ phim được đạo diễn bởi Imai Kazuaki, người cũng đã thực hiện hai phần phim trước đó là Nobita và đảo giấu vàng và Nobita và những bạn khủng long mới. Utsumi Teruko sẽ đảm nhận phần biên kịch cho bộ phim.");
            movies.Add(m1);
            m1 = new Movie(2, "The Avengers", Properties.Resources.advengers, "Avengers: Hồi kết là phim điện ảnh siêu anh hùng Mỹ ra mắt năm 2019, do Marvel Studios sản xuất và Walt Disney Studios Motion Pictures phân phối độc quyền tại thị trường Bắc Mỹ.");
            movies.Add(m1);
            m1 = new Movie(3, "Aladdin và cây đèn thần", Properties.Resources.aladdin, "Aladdin và cây đèn thần: Aladdin, còn được biết tới với tên Aladdin và cây đèn thần ở Việt Nam là một trong những truyện đặc sắc nhất trong bộ truyện Nghìn lẻ một đêm của vùng Trung Đông.");
            movies.Add(m1);
            m1 = new Movie(4, "Walk Alone", Properties.Resources.alone, "Walk Alone: I Walk Alone là một bộ phim noir năm 1947 do Byron Haskin đạo diễn và có sự tham gia của Burt Lancaster và Lizabeth Scott, với dàn diễn viên phụ gồm Wendell Corey và Kirk Douglas.");
            movies.Add(m1);
            m1 = new Movie(5, "Barbie", Properties.Resources.barbie, "Barbie: Barbie là một bộ phim điện ảnh Anh – Mỹ thuộc thể loại hài – lãng mạn – chính kịch công chiếu vào năm 2023 do Greta Gerwig làm đạo diễn kiêm viết kịch bản với Noah Baumbach.[4] Dựa trên thương hiệu búp bê nổi tiếng Barbie của công ty Mattel, đây là tác phẩm điện ảnh đầu tiên về búp bê Barbie do người thật đóng sau hơn 40 phim hoạt hình máy tính và phim truyền hình đã được thực hiện.");
            movies.Add(m1);
            m1 = new Movie(6, "Batman", Properties.Resources.batman, "Batman: Người Dơi là một nhân vật hư cấu, một siêu anh hùng truyện tranh được tạo ra bởi họa sĩ Bob Kane và nhà văn Bill Finger. Batman xuất hiện lần đầu tiên trong Detective Comics #27, và kể từ đó đã xuất hiện trong nhiều tác phẩm xuất bản của DC Comics. ");
            movies.Add(m1);
            m1 = new Movie(7, "Beauty and the Beast", Properties.Resources.beautyandthebeast, "Beauty and the Beast: Người đẹp và quái vật (tựa gốc tiếng Anh: Beauty and the Beast) là một phim điện ảnh nhạc kịch kỳ ảo lãng mạn của Mỹ năm 2017 được đạo diễn bởi Bill Condon với phần kịch bản phim do Stephen Chbosky và Evan Spiliotopoulos thực hiện. Dưới sự sản xuất của hai hãng phim Walt Disney Pictures và Mandeville Films[6], Người đẹp và quái vật được lấy cảm hứng từ bộ phim hoạt hình cùng tên năm 1991 của Disney, đồng thời cũng là tác phẩm chuyển thể từ truyện cổ tích Người đẹp và quái vật của nữ văn sĩ người Pháp Jeanne-Marie Leprince de Beaumont.");
            movies.Add(m1);
            m1 = new Movie(8, "Dune: Hành tinh cát", Properties.Resources.dune, "Dune: Hành tinh cát là phim điện ảnh sử thi khoa học viễn tưởng của Mỹ năm 2021 do Denis Villeneuve làm đạo diễn và đồng sản xuất với phần kịch bản do ông cùng với Jon Spaihts và Eric Roth chắp bút. ");
            movies.Add(m1);
            m1 = new Movie(9, "Exhuma: Quật mộ trùng ma", Properties.Resources.Exhuma_film_poster, "Exhuma: Quật mộ trùng ma là một bộ phim điện ảnh Hàn Quốc thuộc thể loại trinh thám – kinh dị – giật gân ra mắt vào năm 2024 do Jang Jae-hyun viết kịch bản kiêm đạo diễn, với sự tham gia diễn xuất của các diễn viên gồm Choi Min-sik, Kim Go-eun, Yoo Hae-jin và Lee Do-hyun.");
            movies.Add(m1);
            m1 = new Movie(10, "Harry Potter", Properties.Resources.harryporter, "Harry Potter và Hòn đá Phù thủy là một bộ phim giả tưởng năm 2001 được đạo diễn bởi Chris Colombus và được phát hành bởi Warner Bros. Pictures, dựa theo cuốn tiểu thuyết cùng tên năm 1997 của nhà văn Anh J. K. Rowling.");
            movies.Add(m1);
            m1 = new Movie(11, "Joker", Properties.Resources.joker, "Joker là một bộ phim điện ảnh giật gân tâm lý của Mỹ năm 2019 do Todd Phillips chịu trách nhiệm đạo diễn kiêm sản xuất, với phần kịch bản do anh chấp bút cùng nhà biên kịch Scott Silver. Bộ phim dựa trên nguyên tác truyện tranh gốc của DC Comics, với bối cảnh được đặt vào năm 1981 ở Thành phố Gotham.");
            movies.Add(m1);
            m1 = new Movie(12, "Truth never know", Properties.Resources.truth_never_know, "Truth never know: Một ca sĩ đang đi lưu diễn và nhớ chồng. Cảm thấy lạc lõng và cô đơn, anh nhận ra rằng chỉ nói \"Anh yêu em\" là chưa đủ và anh thể hiện tình yêu của mình với chồng và với thế giới trên sân khấu qua ca khúc \"You'll Never Know\".");
            movies.Add(m1);
        }

        public void ShowMovieDetail(int id)
        {
            this.movie_id = id;
            Movie movie = movies.First(n => n.movie_id == id);
            if (movie != null)
            {
                pictureBox1.Image = movie.srcImg;
                lbdetail.Text = movie.movie_desc;
                lbMovieName.Text = movie.movie_name;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBookSeat frmBookSeat = new FrmBookSeat();
            frmBookSeat.timeStart = dateTimePicker1.Value;
            frmBookSeat.cinemaName = cmbCinema.Text;
            frmBookSeat.movieName = lbMovieName.Text;
            frmBookSeat.ShowDialog();
            this.Close();

        }
    }
}
