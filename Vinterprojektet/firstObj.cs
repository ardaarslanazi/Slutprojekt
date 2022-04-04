using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;

namespace Vinterprojektet
{
    // barn specs allt ifrån position till hastighet
    public class FirstObj
    {

        public int posX = generator.Next(100, 900);

        public int posY = generator.Next(100, 600);




        public Boolean invisibility = false;

        public Texture2D firstPic = Raylib.LoadTexture("epicbaby.png");

        static Random generator = new Random();







        //barn specs, bilder och rörelse

        public void SpawnObj()
        {


            int mouseX = Raylib.GetMouseX();

            int mouseY = Raylib.GetMouseY();




            Raylib.DrawTexture(firstPic, posX, posY, Color.WHITE);


            /* if (barnX < 0)
             {
                 speedx = speedx * 1;
             }
             if (barnY > 400)
             {
                 speedy = speedy * -2;
             }

             if (barnY < 0)
             {
                 speedy = speedy * 1;
             } */
            //}


            if (mouseX >= posX && mouseX < posX + 88 && mouseY >= posY && posY < posY + 80 && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {




                invisibility = true;





            }

        }

    }






}
