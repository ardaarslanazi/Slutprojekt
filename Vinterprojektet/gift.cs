using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class gift
    {
        Random generator = new Random();
        public Texture2D giftbild = Raylib.LoadTexture("gift.png");

        public int giftX;

        public int giftY;

    }
}