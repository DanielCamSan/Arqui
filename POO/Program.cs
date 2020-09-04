using System;
using POO.Interfaces;
namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport volley = new VolleyBall("vole");
            IHandSports basket = new BasketBall("Bakse");


            Sport besibol = new BaseBall("Basebol");
            IToolSports tenis = new Tennis("Tenis");


        }
    }
}
