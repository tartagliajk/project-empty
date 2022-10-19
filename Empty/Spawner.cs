using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Spawner
    {
        public static void fight()
        {
            Console.WriteLine("\nBurning beings.\nWho gave powders.\nThe player walks with definite steps.");
            if (Village.weapon == "sword")
            {
                Console.WriteLine("The player rise its sword and swing it at the enemies.");
            }
            if (Village.weapon == "axe")
            {
                Console.WriteLine("With a hasty motion the player raises its axe and chops the opponents.");
            }
            if (Village.weapon == "bow")
            {
                Console.WriteLine("Arrow in íts hand.\nPutting it next to the bow string.\nA sound of arrow swoshing past and into the opponents soul.");
            }
            if (Village.weapon == "crossbow")
            {
                Console.WriteLine("The arrow has been loaded.\nThe player charge press the fire button.");
            }
            Console.WriteLine("Lifeless powder on the ground.\nThe player picks some of it up.\n");
        }
    }
}
