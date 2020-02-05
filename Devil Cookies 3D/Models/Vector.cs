using Devil_Cookies_3D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Models
{
    public class Vector<T> : IVector<T> where T : PixelC, IPoint, IPoint3D, IPixel, IPixelC
    {
        public T Start { get; set; }
        public T Finish { get; set; }
    }
}
