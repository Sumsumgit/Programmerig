using System;

namespace PictureShapes
{
    class Dice
    {


        Circle [] dots;
        private static Random numberGenerator;
        private int size;
        private Square kvadrat;




        public Dice()
        {
            dots = new Circle[7];
         dots[0] = new Circle();
         dots[1] = new Circle();
         dots[2] = new Circle();
         dots[3] = new Circle();
         dots[4] = new Circle();
         dots[5] = new Circle();
         dots[6] = new Circle();

        

        numberGenerator = new Random();
            DrawImage();
            Roll();
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {

                if (value >= 20)
                {
                    size = value;
                }
                else
                {
                    size = 20;
                }

                kvadrat.ChangeSize(size);
                dots[0].ChangeSize(size * 20/100);
                dots[1].ChangeSize(size * 20/100);
                dots[2].ChangeSize(size * 20/100);
                dots[3].ChangeSize(size * 20/100);
                dots[4].ChangeSize(size * 20/100);
                dots[5].ChangeSize(size * 20/100);
                dots[6].ChangeSize(size * 20/100);

                dots[0].XPosition = kvadrat.XPosition + size * 40/100;
                dots[1].XPosition = kvadrat.XPosition + size * 10 / 100;
                dots[2].XPosition = kvadrat.XPosition + size * 70 / 100;
                dots[3].XPosition = kvadrat.XPosition + size * 10 / 100;
                dots[4].XPosition = kvadrat.XPosition + size * 70 / 100;
                dots[5].XPosition = kvadrat.XPosition + size * 10 / 100;
                dots[6].XPosition = kvadrat.XPosition + size * 70 / 100;

                dots[0].YPosition = kvadrat.YPosition + size * 40 / 100;
                dots[1].YPosition = kvadrat.YPosition + size * 10 / 100;
                dots[2].YPosition = kvadrat.YPosition + size * 70 / 100;
                dots[3].YPosition = kvadrat.YPosition + size * 70 / 100;
                dots[4].YPosition = kvadrat.YPosition + size * 10 / 100;
                dots[5].YPosition = kvadrat.YPosition + size * 40 / 100;
                dots[6].YPosition = kvadrat.YPosition + size * 40 / 100;


            }

        }


        public void Roll()

        {
            kvadrat.MakeVisible();
            int number = numberGenerator.Next(1, 7);



            if (number%2 == 1)
            {
                dots[0].MakeVisible();
            }
            if (number >= 2)
            {
                dots[1].MakeVisible();
                dots[2].MakeVisible();
            }
            if (number >= 4)
            {
                dots[3].MakeVisible();
                dots[4].MakeVisible();

            }
            if (number == 6)
            {
                dots[5].MakeVisible();
                dots[6].MakeVisible();
            }

        }
        public void DrawImage()
        {
        kvadrat = new Square();
        kvadrat.MakeVisible();
        kvadrat.ChangeColor("black");
        kvadrat.ChangeSize(450);
        kvadrat.XPosition = 160;
        kvadrat.YPosition = 20;


        dots[0].MakeInVisible();
        dots[0].ChangeColor("red");
        dots[0].ChangeSize(75);
        dots[0].XPosition = 350;
        dots[0].YPosition = 180;
        


        dots[1].MakeInVisible();
        dots[1].ChangeColor("red");
        dots[1].ChangeSize(75);
        dots[1].XPosition = 200;
        dots[1].YPosition = 30;


        dots[2].MakeInVisible();
        dots[2].ChangeColor("red");
        dots[2].ChangeSize(75);
        dots[2].XPosition = 500;
        dots[2].YPosition = 330;


        dots[3].MakeInVisible();
        dots[3].ChangeColor("red");
        dots[3].ChangeSize(75);
        dots[3].XPosition = 200;
        dots[3].YPosition = 330;


        dots[4].MakeInVisible();
        dots[4].ChangeColor("red");
        dots[4].ChangeSize(75);
        dots[4].XPosition = 500;
        dots[4].YPosition = 30;


        dots[5].MakeInVisible();
        dots[5].ChangeColor("red");
        dots[5].ChangeSize(75);
        dots[5].XPosition = 500;
        dots[5].YPosition = 180;


        dots[6].MakeInVisible();
        dots[6].ChangeColor("red");
        dots[6].ChangeSize(75);
        dots[6].XPosition = 200;
        dots[6].YPosition = 180;


        }

    }
}
