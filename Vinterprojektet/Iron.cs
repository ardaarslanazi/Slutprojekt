using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Iron : Ground
    {
        public Texture2D ironSight = Raylib.LoadTexture("ironsight.png");

        public void Sight()
        {
            Raylib.DrawTexture(ironSight, mouseX, mouseY, Color.WHITE);
        }


    }
}