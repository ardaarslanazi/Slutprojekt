using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Second : First
    {
        static Random generator = new Random();

        public int pos2X = generator.Next(100, 900);

        public int pos2Y = generator.Next(100, 600);

        Texture2D secondPic = Raylib.LoadTexture("bird.png");

        public Boolean invisibility2 = false;
        public void SpawnObj2()
        {

            int mouseX = Raylib.GetMouseX();

            int mouseY = Raylib.GetMouseY();
            Raylib.DrawTexture(secondPic, pos2X, pos2Y, Color.WHITE);

            if (mouseX >= pos2X && mouseX < pos2X + 88 && mouseY >= pos2Y && posY < pos2Y + 80 && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {




                invisibility2 = true;





            }
        }



    }
}