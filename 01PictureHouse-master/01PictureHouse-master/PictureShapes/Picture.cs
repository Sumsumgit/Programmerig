namespace PictureShapes
{
    class Picture
    {

        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            Square wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);

            
            Square window = new Square();
            window.MakeVisible();
            window.ChangeColor("black");
            window.ChangeSize(70);
            window.MoveHorizontal(100);
            window.MoveVertical(50);

            Triangle roof = new Triangle();
            roof.MakeVisible();
            roof.ChangeColor("black");
            roof.ChangeSize(300);
            roof.MoveHorizontal(-25);
            roof.MoveVertical(-25);

            Circle sun = new Circle();
            sun.MakeVisible();
            sun.ChangeColor("yellow");
            sun.ChangeSize(75);
            sun.MoveHorizontal(500);
            sun.MoveVertical(0);


        }
    }
}
