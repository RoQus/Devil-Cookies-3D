using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Interfaces
{
    public interface IVector<T> where T: PixelC, IPoint, IPoint3D, IPixel, IPixelC
    {
        T Start { get; set; }
        T Finish { get; set; }
    }
}
