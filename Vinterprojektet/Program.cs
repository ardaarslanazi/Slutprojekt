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
            Raylib.InitWindow(900, 600, "abortion Clinic");
            //target fps på 60
            Raylib.SetTargetFPS(60);
            // bilder
            Texture2D background = Raylib.LoadTexture("bakgrund.png");
            Texture2D background2 = Raylib.LoadTexture("background.png");
            Texture2D menu = Raylib.LoadTexture("menusanta.png");

            Random generator = new Random();

            //barn listan där barn ska adderas
            List<First> firstList = new List<First>();

            firstList.Add(new First());

            List<Second> secondList = new List<Second>();

            secondList.Add(new Second());






            int scene = 1;

            while (!Raylib.WindowShouldClose())
            {

                //timer är = frametime
                timer += Raylib.GetFrameTime();

                // om timern = 3 lägg till en barn i listan och den kommer att placeras någonstans random


                Raylib.BeginDrawing();



                if (scene == 1)
                {

                    if (timer >= 3 && scene == 1)
                    {
                        firstList.Add(new First());
                        timer = 0;
                    }

                    Raylib.DrawTexture(background, 0, 0, Color.WHITE);

                    // för varje barn man har i listan kör den metoden
                    foreach (var item in firstList)
                    {
                        //skapa en barnspeed metod för listan
                        item.SpawnObj();

                    }

                    firstList.RemoveAll(b => b.invisibility == true);
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = 2;

                    }

                }


                if (scene == 2)
                {
                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawTexture(background2, 0, 0, Color.WHITE);
                    // Raylib.DrawTexture(background2, 0, 0, Color.WHITE);
                    if (timer >= 3)
                    {
                        secondList.Add(new Second());
                        timer = 0;
                    }
                    foreach (var item in secondList)
                    {
                        item.SpawnObj2();
                    }
                    secondList.RemoveAll(c => c.invisibility2 == true);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = 2;

                    }
                }







                Raylib.EndDrawing();

            }

        }
    }
}
