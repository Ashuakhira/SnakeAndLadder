using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class RollDice
    {
        public static void call()
        {
            Console.WriteLine("start the snake and ladder game");
            Console.WriteLine("single player at start position 0");
            Random random = new Random();
            int RollDice = random.Next(1, 6);
            Console.WriteLine("player 1 rolls the die and get:" + RollDice);
        }
    }
}
