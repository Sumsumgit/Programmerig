using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Shape3D
{
    class Cylinder : Shape3D
    {

        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            r = 4.0;
            height = h;
            h = 6.0;

        }
        public double GetArea()
        {
            return 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;

        }
        public double GetVolume()
        {
            return 4 * Math.PI * radius * radius * height;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SkrivUt()
        {
            Console.WriteLine("Cylinder");
            Console.WriteLine("Radius:" + radius);
            Console.WriteLine("Height:" + height);
            Console.WriteLine("Area:" + GetArea());
            Console.WriteLine("Volume:" + GetVolume());
        }
    }

}
