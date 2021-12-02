using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Shape3D
{
    class Databas
    {

        private List<Shape3D> shape;
        public Databas()
        {
            shape = new List<Shape3D>();
            shape.Add(new Sphere(5));
            shape.Add(new Cylinder(6, 5));
            shape.Add(new Cube(6));



        }

        public void Run()
        {
            foreach (Shape3D grej in shape)
            {
                grej.SkrivUt();
                Console.WriteLine();
            }
        }
    }
}
