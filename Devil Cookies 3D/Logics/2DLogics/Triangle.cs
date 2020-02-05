using Devil_Cookies_3D.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devil_Cookies_3D.Logics._2DLogics
{
    public class Triangle
    {
        private readonly Vector<PixelC> first_vector;
        private readonly Vector<PixelC> second_vector;
        private readonly Drawing drawing;

        private List<double> Values;

        private List<PixelC> lines = new List<PixelC>();


        public Triangle(Vector<PixelC> first_vector, Vector<PixelC> second_vector, Drawing drawing)
        {
            this.first_vector = first_vector;
            this.second_vector = second_vector;
            this.drawing = drawing;
            this.Values = new List<double>() { 0,0,0,0,0,0};

            Formulars();
        }
        private void Formulars() {
            FormulaValues(0, 1, first_vector.Start, first_vector.Finish);
            FormulaValues(2, 3, second_vector.Start, second_vector.Finish);
            FormulaValues(4, 5, second_vector.Finish, first_vector.Finish);
        }

        private void FormulaValues(int k, int b, PixelC point1, PixelC point2)
        {
            Values[k] = (point1.Y - point2.Y) / (point2.X - point1.X);
            Values[b] = point1.Y - point1.X * (Double.IsInfinity(Values[k]) ? 0 : Values[k] );
        }

        public Bitmap Lines()
        {
            var p2 = first_vector.Finish;
            var p1 = first_vector.Start;
            var p3 = second_vector.Finish;

            var t = new Line(p1, p2, drawing);
            t.Lines();
            t = new Line(p1, p3, drawing);
            t.Lines();
            t = new Line(p2, p3, drawing);
            t.Lines();
            Drawing.ChangePole(lines);
            return Drawing.GetPole();
        }

        
    }
}
