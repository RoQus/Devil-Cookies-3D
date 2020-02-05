using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Interfaces
{
    public interface IMatrix<T, F> where F: Massive<T>, IMassive<T> where T: PixelC, IPixel, IPixelC 
    {
        List<T> Rows { get; set; }
    }
}
