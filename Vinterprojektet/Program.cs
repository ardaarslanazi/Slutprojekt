
using System;
using Raylib_cs;
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
            Texture2D menu = Raylib.LoadTexture("menu.png");
            Texture2D ironSight = Raylib.LoadTexture("ironsight.png");
            Texture2D shot = Raylib.LoadTexture("gunshot.png");
            Texture2D ironSight2 = Raylib.LoadTexture("ironsight2.png");


            Random generator = new Random();

            //objekt listan där objekt ska adderas
            List<First> firstList = new List<First>();

            firstList.Add(new First());

            List<Second> secondList = new List<Second>();

            secondList.Add(new Second());

            Ground ironsight = new Ground();

            int score = 0;


            // First score1 = new First();










            int scene = 0;

            while (!Raylib.WindowShouldClose())
            {
                int mouseX = Raylib.GetMouseX();

                int mouseY = Raylib.GetMouseY();

                //timer är = frametime
                timer += Raylib.GetFrameTime();

                // om timern = 3 lägg till en objekt i listan och den kommer att placeras någonstans random


                Raylib.BeginDrawing();

                string score1 = score.ToString();

                // hoppa över till nästa scen beroende på vad man vill skjuta
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    scene++;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
                {
                    scene = 2;

                }
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
                {
                    scene = 3;
                }

                // meny
                if (scene == 0)
                {
                    Raylib.DrawTexture(menu, 0, 0, Color.WHITE);
                }
                // valsidan
                if (scene == 1)
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawText("Press 1 to shoot kitten/cat", 50, 50, 50, Color.BLACK);
                    Raylib.DrawText("Discord/kitten", 50, 150, 50, Color.BLACK);
                    Raylib.DrawText("Press 2 to Dumb bird/ wet owl", 50, 250, 50, Color.BLACK);

                }


                if (scene == 2)
                {

                    //om timer är större eller lika med 3 samt scene är lika med 1 lägg till en ny objekt i listan
                    if (timer >= 1 && scene == 2)
                    {
                        firstList.Add(new First());

                        timer = 0;
                    }
                    // bakgrundsbild
                    Raylib.DrawTexture(background, 0, 0, Color.WHITE);




                    // för varje objekt man har i listan kör den metoden
                    foreach (var item in firstList)
                    {
                        //skapa en object metod för listan
                        item.SpawnObj();

                    }

                    firstList.RemoveAll(b => b.invisibility == true);

                    // om man klickar på mössen så kommer det ut eld ur vapnet

                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        Raylib.DrawTexture(shot, mouseX - 98, mouseY - 85, Color.WHITE);
                        score++;
                    }
                    Raylib.DrawTexture(ironSight, mouseX - 55, mouseY - 15, Color.WHITE);
                    Raylib.DrawText(score1, 100, 100, 50, Color.WHITE);
                    Raylib.DrawText("Ammo used", 100, 50, 50, Color.WHITE);



                }

                // samma sak som scene 1 fast med objekt
                if (scene == 3)
                {
                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawTexture(background2, 0, 0, Color.WHITE);
                    // Raylib.DrawTexture(background2, 0, 0, Color.WHITE);
                    if (timer >= 1)
                    {
                        secondList.Add(new Second());
                        timer = 0;
                    }
                    foreach (var item in secondList)
                    {
                        item.SpawnObj2();

                    }
                    // ta bort objekt från listan
                    secondList.RemoveAll(c => c.invisibility2 == true);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = 2;

                    }
                    // kommer eld ut ur vapnet om man klickar på mössen
                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        Raylib.DrawTexture(shot, mouseX + 15, mouseY - 5, Color.WHITE);
                        score++;
                    }
                    Raylib.DrawTexture(ironSight2, mouseX - 55, mouseY - 15, Color.WHITE);
                    Raylib.DrawText(score1, 100, 100, 50, Color.BLACK);
                    Raylib.DrawText("Ammo used", 100, 50, 50, Color.BLACK);


                }







                Raylib.EndDrawing();

            }

        }
    }
}
