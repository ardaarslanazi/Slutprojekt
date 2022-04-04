using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Second : Ground
    {
        static Random generator = new Random();





        Texture2D secondPic = Raylib.LoadTexture("bird.png");

        public Boolean invisibility2 = false;

        public void SpawnObj2()
        {

            int mouseX = Raylib.GetMouseX();

            int mouseY = Raylib.GetMouseY();

            Raylib.DrawTexture(secondPic, posX, posY, Color.WHITE);

            if (mouseX >= posX && mouseX < posX + 88 && mouseY >= posY && posY < posY + 80 && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {




                invisibility2 = true;





            }
        }



    }
}