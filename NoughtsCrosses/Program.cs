using System;
using static System.Console;
using System.Threading.Tasks.Dataflow;

namespace Pluralsight.BegCShCollections.NoughtsCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayGame();
            WriteLine("Game Over!");
        }
    }
}
