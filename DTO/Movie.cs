using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.DTO
{
    public class Movie
    {
        public Movie(int id, string name, Bitmap srcImg, string desc)
        {
            this.movie_name = name;
            this.movie_desc = desc;
            this.movie_id = id;
            this.srcImg = srcImg;
        }
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public string movie_desc { get; set; }
        public Bitmap srcImg { get; set; }
    }
}
