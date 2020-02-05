using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Interfaces
{
    public interface IMassive<T> where T: PixelC, IPixel, IPixelC
    {
        List<T> Row { get; set; }
    }
}
