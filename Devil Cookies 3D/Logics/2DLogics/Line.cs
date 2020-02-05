using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Logics._2DLogics
{
    public class Line
    {
        private readonly PixelC first_line;
        private readonly PixelC second_line;
        private readonly Drawing drawing;

        private List<double> Values;
        private List<PixelC> lines = new List<PixelC>();


        public Line(PixelC first_line, PixelC second_line, Drawing drawing)
        {
            this.first_line = first_line;
            this.second_line = second_line;
            this.drawing = drawing;
            this.Values = new List<double>() { 0, 0 };

            Formulars();
        }
        private void Formulars()
        {
            FormulaValues(0, 1, first_line, second_line);
        }

        private void FormulaValues(int k, int b, PixelC point1, PixelC point2)
        {
            Values[0] = (point2.Y - point1.Y) / (point2.X - point1.X);
            Values[1] = point1.Y - point1.X * (Double.IsInfinity(Values[0]) ? 0 : Values[0]);
        }

        public Bitmap Lines()
        {
            var p1 = second_line;
            var p2 = first_line;
            DrawLine(p1, p2);
            Drawing.ChangePole(lines);
            return Drawing.GetPole();
        }

        private void DrawLine(PixelC point1, PixelC point2)
        {
            double k = Values[0];
            double b = Values[1];

            if (!Double.IsInfinity(k) && k <= 1 && k != 0)
            {
                if (point1.X > point2.X)
                {
                    var p = point1;
                    point1 = point2;
                    point2 = p;
                }
                var j = point1.X;
                while (j < point2.X)
                {

                    lines.Add(new PixelC()
                    {
                        X = j,
                        Y = k * j + b,
                    });
                    j += 0.001;
                }
            }
            else if (!Double.IsInfinity(k) && k > 1)
            {
                if (point1.Y > point2.Y)
                {
                    var p = point1;
                    point1 = point2;
                    point2 = p;
                }
                var j = point1.Y;
                while (j < point2.Y)
                {
                    lines.Add(new PixelC()
                    {
                        X = (j - b) / k,
                        Y = j,
                    });
                    j += 0.001;
                }

            }
            else if (point1.Y == point2.Y)
            {
                if (point1.X > point2.X)
                {
                    var p = point1;
                    point1 = point2;
                    point2 = p;
                }
                var j = point1.X;
                while (j < point2.X)
                {
                    lines.Add(new PixelC()
                    {
                        X = j,
                        Y = point1.Y,
                    });
                    j += 1;
                }
            }
            else
            {
                if (point1.Y > point2.Y)
                {
                    var p = point1;
                    point1 = point2;
                    point2 = p;
                }
                var j = point1.Y;
                while (j < point2.Y)
                {
                    lines.Add(new PixelC()
                    {
                        X = point1.X,
                        Y = j,
                    });
                    j += 1;
                }
            }

        }

    }
}
