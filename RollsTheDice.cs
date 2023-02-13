using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RollsTheDice
    {
        public static void GetANumber()
        {
            int position = 0;

            Console.WriteLine("Welcome Player 1, Let's start the Game");
            Console.WriteLine("Player 1 is at position : " + position);

            Random random = new Random();
            while (position < 100)
            {
                int temp = position;

                int dice = random.Next(1, 7);
                Console.WriteLine($"The player rolls a dice and gets: {dice}");

                int option = random.Next(0, 3);
                if (option == 0)
                {
                    Console.WriteLine("Player stays at the same position");


                }
                else if (option == 1)
                {
                    Console.WriteLine("Player Moves Ahead by {0} from ladder", dice);
                    position += dice;


                }
                else
                {
                    Console.WriteLine("Player Moves behind by {0} from ladder", dice);
                    position -= dice;

                }
                if (position < 0)
                {
                    position = 0;
                }
                else if (position >100)
                {
                    position = temp;
                }
                Console.WriteLine(" Player Current Position is at : {0}", position);
            }
            Console.WriteLine("Player position is : {0}", position);
        }
    }
}
