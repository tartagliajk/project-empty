using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Spawn
    {
        static string trees;
        public static string tools;
        public static void room()
        {
            Console.WriteLine("Sunrise... something the player hasn't experienced in ages.");
            Console.WriteLine("Something so beautiful but yet so wrong.");
            Console.WriteLine("The player looks around.");
            Console.WriteLine("The player spots a village from a distance.");
            Console.Write("\nDoes the player wither go to the village or get some trees? [Village / Trees]\n>");
            while (true)
            {
                trees = Console.ReadLine();
                if (trees.ToLower() == "trees")
                {
                    Console.WriteLine("\nThe player has never seen trees this tall.");
                    Console.WriteLine("Is it the player that is short or is it the trees that are tall?");
                    Console.Write("\nDoes the player want to make tools or go to the village? [Village / Tools]\n>");
                    while (true)
                    {
                        tools = Console.ReadLine();
                        if (tools.ToLower() == "tools")
                        {
                            Console.WriteLine("\nPicaxe? Shovel? Hoe?");
                            Console.WriteLine("Somehow the player still remembers how to create them.");
                            Console.WriteLine("The player looks at the creation.");
                            Console.WriteLine("Turns it...");


                            break;
                        }
                        if (tools.ToLower() == "village")
                        {
                            break;
                        }
                    }
                    break;
                }
                if (trees.ToLower() == "village")
                {
                    Console.WriteLine("\nThe player decides to explore a bit but it doesn't find anything useful.");
                    break;
                }
            }
            Console.WriteLine("\nIt looks up to the sky.");
            Console.WriteLine("It's getting late.");
            Console.WriteLine("It heads towards the village.");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}
