using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;
namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)

        {
            Raylib.InitWindow(1300, 900, "Gamestate testing");

            Texture2D bakgrund = Raylib.LoadTexture("bakgrund.png");
            Texture2D meny = Raylib.LoadTexture("menusanta.png");


            Random generator = new Random();
            Barn Barn1 = new Barn();
            speed speed1 = new speed();
            gift gift1 = new gift();
            Barn1.barnX = generator.Next(0, 1300);
            Barn1.barnY = generator.Next(0, 900);
            gift1.giftX = generator.Next(100, 800);
            Barn1.barnX = Barn1.barnX + speed1.speedx;
            Timer t = new Timer(TimerCallback, null, 0, 1000);
            int scene = 0;
            static void TimerCallback(Object o)
            {
                Console.WriteLine("In TimerCallback: " + DateTime.Now);
            }

            while (!Raylib.WindowShouldClose())
            {


                Raylib.BeginDrawing();

                if (scene == 0)
                {

                    Raylib.DrawTexture(meny, 0, 0, Color.WHITE);
                }

                if (scene == 1)
                {

                    Raylib.DrawTexture(bakgrund, 0, 0, Color.WHITE);

                    //Äckel barnjävel spawn
                    Raylib.DrawTextureEx(Barn1.barnbild, new Vector2(Barn1.barnX, Barn1.barnY), 0, 0.20f, Color.WHITE);
                    Barn1.barnX = Barn1.barnX + speed1.speedx;
                    Barn1.barnY = Barn1.barnY + speed1.speedy;


                    if (Barn1.barnX >= 900)
                    {
                        speed1.speedx = speed1.speedx * -1;
                    }

                    if (Barn1.barnX <= 0)
                    {
                        speed1.speedx = speed1.speedx + 1;
                    }
                    if (Barn1.barnY >= 600)
                    {
                        speed1.speedy = speed1.speedy * -1;
                    }

                    if (Barn1.barnY <= 0)
                    {
                        speed1.speedy = speed1.speedy * -1;
                    }
                }




                // Raylib.DrawTexture(Barn.barnbild,)


                Raylib.EndDrawing();

            }

        }
    }
}
