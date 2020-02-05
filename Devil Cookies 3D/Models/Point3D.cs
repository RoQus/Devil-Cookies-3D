using Devil_Cookies_3D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Models
{
    public class Point3D : IPoint3D
    {
        public double Z { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
