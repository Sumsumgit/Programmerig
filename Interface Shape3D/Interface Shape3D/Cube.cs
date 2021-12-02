using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Shape3D
{
    class Cube : Shape3D
    {
        private double lenght;

        public Cube(double l)
        {
            l = lenght;
            lenght = 3.8;

        }

        public double GetArea()
        {
            return lenght * lenght * 6; 
        }
        public double GetVolume()
        {
            return lenght * lenght * lenght;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SkrivUt()
        {
            Console.WriteLine("Cube");
            Console.WriteLine("Lenght:" + lenght);
            Console.WriteLine("Area:" + GetArea());
            Console.WriteLine("Volume:" + GetVolume());

        }
    }

}
