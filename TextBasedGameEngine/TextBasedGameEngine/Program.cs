using System;
using TextBasedGameEngine.src;

namespace TextBasedGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine(menu.welcome());
        }
    }
}
