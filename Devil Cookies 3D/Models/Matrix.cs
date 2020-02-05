using Devil_Cookies_3D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Models
{
    public class Matrix<T, F> : IMatrix<T, F> where F : Massive<T>, IMassive<T> where T : PixelC, IPixel, IPixelC
    {
        public List<T> Rows { get; set; }
    }
}
