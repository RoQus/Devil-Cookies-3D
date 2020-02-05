using Devil_Cookies_3D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Models
{
    public class Pixel : IPixel
    {
        public double WX { get; set; }
        public double WY { get; set; }
        public double Z { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
