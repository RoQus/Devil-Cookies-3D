using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Devil_Cookies_3D.Logics._2DLogics
{
    public class Drawing
    {
        private static Bitmap Pole;

        public Drawing(int width = 600, int height = 400)
        {
            Pole = new Bitmap(width, height);
        }

        public static Bitmap GetPole() => Pole;

        public static void ChangePole(List<PixelC> pixels)
        {
            var b = new Bitmap(Pole.Width, Pole.Height);
            Random random = new Random();
            foreach (var item in pixels)
            {
                var x = Convert.ToInt32(item.X);
                var y = Pole.Height - Convert.ToInt32(item.Y);
                
                b.SetPixel(x, y, Color.FromArgb(random.Next(0, 150), random.Next(0, 150), random.Next(0, 150)));
                
            }
            for (int y = 0; y < Pole.Height; y++)
            {
                bool i = false;
                for (int x = 0; x < Pole.Width; x++)
                {
                    if (b.GetPixel(x, y) != Color.White)
                        i = i ? false : true;
                    if (i)
                        b.SetPixel(x, y, Color.FromArgb(random.Next(0, 150), random.Next(0, 150), random.Next(0, 150)));
                }
            }
        }

    }
}
