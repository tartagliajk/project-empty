using System.Runtime.InteropServices;

namespace Empty
{
    internal class Program
    {

        static string option_village_trees;
        static string option_village_tools;
        /*Console.Write(""); Console.ReadLine för att få input på samma linje som output*/
        /* naming variables https://www.informit.com/articles/article.aspx?p=24472
         * tolower() https://www.geeksforgeeks.org/c-sharp-tolower-method/
         * 
        */

        static void Main(string[] args)
        {
            Console.Write("Welcome to Empty, click enter to continue.");
            Console.Read();
            Intro();
            Console.Read();
            Spawn();
        }

        static void Intro()
        {
            Console.WriteLine("-------------------------------------------------------------------------\n");
            Console.WriteLine("The world is loading.");
            Console.WriteLine("Every block is being placed.");
            Console.WriteLine("Trees and oceans are creating.");
            Console.WriteLine("Everything is simply being built up.");
            Console.WriteLine("Now it's the player's time to either set a footprint or to be forgotten.");
            Console.WriteLine("\n-------------------------------------------------------------------------");
            Console.Read();
        }

        static void Spawn()
        {
            Console.WriteLine("Sunrise... something the player hasn't experienced in ages");
            Console.WriteLine("Something so beautiful but yet so wrong.");
            Console.WriteLine("The player looks around.");
            Console.WriteLine("The player spots a village from a distance.");
            Console.Write("Does the player wither go to the village or get some trees? [Village / Trees]\n>");
            while (true)
            {
                option_village_trees = Console.ReadLine();
                if(option_village_trees.ToLower() == "trees")
                {
                    Console.WriteLine("\nThe player has never seen trees this tall.");
                    Console.WriteLine("Is it the player that is short or is it the trees that are tall?");
                    Console.Write("Does the player want to make tools or go to the village? [Village / Tools]\n>");
                    while (true)
                    {
                        option_village_tools = Console.ReadLine();
                        if(option_village_tools.ToLower() == "tools")
                        {
                            Console.WriteLine("\nPicaxe? Shovel? Hoe?");
                            Console.WriteLine("Somehow the player still remembers how to create them.");
                            Console.WriteLine("The player looks at the creation.");
                            Console.WriteLine("Turns it...");
                            break;
                        }if(option_village_tools.ToLower() == "village")
                        {
                            break;
                        }
                    }break;
                }if(option_village_trees.ToLower() == "village")
                {
                    Console.WriteLine("\n The player decides to explore a bit but it doesn't find anything useful.");
                    break;
                }
            }
            Console.WriteLine("\nIt looks up to the sky.");
            Console.WriteLine("It's getting late.");
            Console.WriteLine("It heads towards the village.");
        }
    }
}