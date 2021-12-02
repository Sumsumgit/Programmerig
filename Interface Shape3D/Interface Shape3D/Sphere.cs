using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Shape3D
{
    class Sphere : Shape3D
    {

        private double r;

        public Sphere(double radius)
        {
            r = radius;
            radius = 4.56;

        }

     

        public double GetArea()
        {
            return 4 * Math.PI * r * r;

        }
        public double GetVolume()
        {
            return 4 * Math.PI * r * r * r / 3;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SkrivUt()
        {
            Console.WriteLine("Sphere");
            Console.WriteLine("Radius:" + r);
            Console.WriteLine("Area:" +GetArea());
            Console.WriteLine("Volume:" + GetVolume());
           
            
        }
    }

}
