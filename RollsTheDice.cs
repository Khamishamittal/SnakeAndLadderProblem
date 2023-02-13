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
            Random random= new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine($"The player rolls a dice and gets: {dice}");    
        }
    }
}
