using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineMassacre.Classes.Helpers
{
    public class Die
    {
        public static int Flip(int originalDie)
        {
            if (originalDie == 100)
            {
                return 100;
            }
            else
            {
                int counter = 0;
                while (originalDie >= 10)
                {
                    originalDie = originalDie - 10;
                    counter++;
                }
                return 10 * originalDie + counter;
            }
        }

        public static int Roll(int numberOfSides)
        {
            var Random = new Random();
            return Random.Next(1, numberOfSides + 1);
        }


    }
}
