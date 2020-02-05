﻿using Devil_Cookies_3D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Models
{
    public class Massive<T> : IMassive<T> where T: PixelC, IPixelC, IPixel
    {
        public List<T> Row { get; set; }
    }
}
