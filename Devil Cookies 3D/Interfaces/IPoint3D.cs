using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Interfaces
{
    public interface IPoint3D : IPoint
    {
        double Z { get; set; }
    }
}
