using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_arv
{
    class Zoo
    {
        private List<Dog> dog;
        private List<Cat> cat;
        public Zoo()

        {

            cat = new List<Cat>();
            
                cat.Add(new Cat(2));
                cat.Add(new Cat(5));
                cat.Add(new Cat(7));
                cat.Add(new Cat(1));


            dog = new List<Dog>();

            dog.Add(new Dog(4));
            dog.Add(new Dog(2));
            dog.Add(new Dog(8));
            dog.Add(new Dog(5));



        }

        public void Run()
        {
            foreach (Cat katt in cat)
            {
                katt.Act();
            }


            foreach (Dog hund in dog)
            {
                hund.Act();
            }
        }


    }
}
