using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;

namespace Vinterprojektet
{   // specs på spawn objektet
    public class Ground
    {

        static Random generator = new Random();
        public Boolean invisibility = false;
        public int posX = generator.Next(100, 900);

        public int posY = generator.Next(100, 600);
        public int mouseX = Raylib.GetMouseX();

        public int mouseY = Raylib.GetMouseY();


    }

}