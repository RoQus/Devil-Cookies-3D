using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Interfaces
{
    public interface IPixel : IPoint3D
    {
        /// <summary>
        /// Angle in radians X
        /// </summary>
        double WX { get; set; }
        /// <summary>
        /// Angle in radians Y
        /// </summary>
        double WY { get; set; }
    }
}
