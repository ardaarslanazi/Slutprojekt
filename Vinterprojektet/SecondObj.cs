using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Second : Ground
    {
        static Random generator = new Random();
        public int score = 0;


        Texture2D secondPic = Raylib.LoadTexture("bird.png");

        public Boolean invisibility2 = false;
        // samma kod som på firstOBj fast med fågeln.
        public void SpawnObj2()
        {

            int mouseX = Raylib.GetMouseX();

            int mouseY = Raylib.GetMouseY();
            // rita ut bilden
            Raylib.DrawTexture(secondPic, posX, posY, Color.WHITE);
            // om mössen är på fågeln så kan man poppa den
            if (mouseX >= posX && mouseX < posX + 88 && mouseY >= posY && posY < posY + 80 && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {


                invisibility2 = true;
                score++;



            }
        }



    }
}