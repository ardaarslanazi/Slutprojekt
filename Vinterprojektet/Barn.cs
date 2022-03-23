using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;

namespace Vinterprojektet
{
    // barn specs allt ifrån position till hastighet
    public class Barn
    {

        public int barnX = generator.Next(100, 900);

        public int barnY = generator.Next(100, 600);

        public int speedx;

        public int speedy;

        public Boolean invisibility = false;

        public Texture2D barnbild = Raylib.LoadTexture("epicbaby.png");

        static Random generator = new Random();






        //barn specs, bilder och rörelse

        public void Barnspeed()
        {


            int mouseX = Raylib.GetMouseX();

            int mouseY = Raylib.GetMouseY();





            speedx = generator.Next(1, 3);
            speedy = generator.Next(1, 3);

            if (invisibility == false)
            {
                // Raylib.DrawTextureEx(barnbild, new Vector2(barnX, barnY), 0, 0.20f, Color.WHITE);
                Raylib.DrawTexture(barnbild, barnX, barnY, Color.WHITE);
                Raylib.DrawRectangle(barnX + 8, barnY + 5, 80, 80, Color.BLACK);

                barnX = barnX + speedx;
                barnY = barnY + speedy;

                if (barnX >= 700)
                {
                    speedx = speedx * 0;
                }

                if (barnX <= 0)
                {
                    speedx = speedx * 0;
                }
                if (barnY >= 400)
                {
                    speedy = speedy * 0;
                }

                if (barnY <= 0)
                {
                    speedy = speedy * 0;
                }
            }

            if (mouseX >= barnX && mouseX < barnX + 88 && mouseY >= barnY && barnY < barnY + 80 && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {




                invisibility = true;





            }

        }

    }






}
