using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;

namespace Vinterprojektet
{
    // barn specs allt som tar arvet från Ground som är grudnen till alla barn specs
    public class First : Ground
    {
        //bilden
        public Texture2D firstPic = Raylib.LoadTexture("epicbaby.png");

        static Random generator = new Random();







        //barn specs och if sats om att kunna ta bort den

        public void SpawnObj()
        {


            int mouseX = Raylib.GetMouseX();

            int mouseY = Raylib.GetMouseY();



            Raylib.DrawTexture(firstPic, posX, posY, Color.WHITE);



            // om musen är på en viss position och klickad invisibility är true
            if (mouseX >= posX && mouseX < posX + 88 && mouseY >= posY && posY < posY + 80 && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {




                invisibility = true;





            }

        }

    }






}
