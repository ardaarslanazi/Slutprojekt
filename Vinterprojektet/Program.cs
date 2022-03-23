using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;
using System.Collections.Generic;
namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)

        {
            //timer intet
            float timer = 0;
            Raylib.InitWindow(900, 600, "Gamestate testing");
            //target fps på 60
            Raylib.SetTargetFPS(60);
            // bilder
            Texture2D bakgrund = Raylib.LoadTexture("bakgrund.png");
            Texture2D meny = Raylib.LoadTexture("menusanta.png");

            Random generator = new Random();

            //barn listan där barn ska adderas
            List<Barn> barnList = new List<Barn>();

            barnList.Add(new Barn());






            int scene = 1;

            while (!Raylib.WindowShouldClose())
            {

                //timer är = frametime
                timer += Raylib.GetFrameTime();

                // om timern = 3 lägg till en barn i listan och den kommer att placeras någonstans random
                if (timer >= 3)
                {
                    barnList.Add(new Barn());
                    timer = 0;
                }

                Raylib.BeginDrawing();

                if (scene == 1)
                {

                    Raylib.DrawTexture(bakgrund, 0, 0, Color.WHITE);

                    // för varje barn man har i listan kör den metoden
                    foreach (var item in barnList)
                    {
                        //skapa en barnspeed metod för listan
                        item.Barnspeed();
                        Barn barn1 = new Barn();

                        if (barn1.invisibility == true)
                        {

                            barnList.Remove(barn1);


                        }




                    }


                }







                Raylib.EndDrawing();

            }

        }
    }
}
