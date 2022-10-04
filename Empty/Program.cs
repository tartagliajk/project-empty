using System.Runtime.InteropServices;

namespace Empty
{
    internal class Program
    {

        static string option_village_trees;
        static string option_village_tools;
        static string option_smith_range;
        static string option_weapon;
        /*Console.Write(""); Console.ReadLine för att få input på samma linje som output*/
        /* naming variables https://www.informit.com/articles/article.aspx?p=24472
         * tolower() https://www.geeksforgeeks.org/c-sharp-tolower-method/
         * color text https://www.tutorialspoint.com/how-to-change-the-foreground-color-of-text-in-chash-console
         * 
        */

        static void Main(string[] args)
        {
            Console.Write("Welcome to Empty, click enter to continue.");
            Console.Read();
            Intro();
            Console.Read();
            Spawn();
            Console.Read();
            Village();
        }

        static void Intro()
        {
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("The world is loading.\nEvery block is being placed.\nTrees and oceans are creating.\nEverything is simply being built up.\nNow it's the player's time to either set a footprint or to be forgotten.");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.Read();
        }

        static void Spawn()
        {
            Console.WriteLine("Sunrise... something the player hasn't experienced in ages.\nSomething so beautiful but yet so wrong.\nThe player looks around.\nThe player spots a village from a distance.");
            Console.Write("\nDoes the player wither go to the village or get some trees? [Village / Trees]\n>");
            while (true)
            {
                option_village_trees = Console.ReadLine();
                if(option_village_trees.ToLower() == "trees")
                {
                    Console.WriteLine("\nThe player has never seen trees this tall.\nIs it the player that is short or is it the trees that are tall?");
                    Console.Write("\nDoes the player want to make tools or go to the village? [Village / Tools]\n>");
                    while (true)
                    {
                        option_village_tools = Console.ReadLine();
                        if(option_village_tools.ToLower() == "tools")
                        {
                            Console.WriteLine("\nPicaxe? Shovel? Hoe?\nSomehow the player still remembers how to create them.\nThe player looks at the creation.\nTurns it...");
                            break;
                        }if(option_village_tools.ToLower() == "village")
                        {
                            break;
                        }
                    }break;
                }if(option_village_trees.ToLower() == "village")
                {
                    Console.WriteLine("\nThe player decides to explore a bit but it doesn't find anything useful.");
                    break;
                }
            }
            Console.WriteLine("\nIt looks up to the sky.\nIt's getting late.\nIt heads towards the village.");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        static void Village()
        {
            Console.WriteLine("Sunset.\nA mix of pink and blue starts to emerge onto the sky.\nFrom a distance the player spots a tree.\nThe player decides to make a temporary base there for the night.\nA tent.\nA roof over the head.\nNight.\nQuietness, darkness, stars that sparkle.");
            Console.WriteLine("...\n...\n...");
            Console.WriteLine("\nSunrise.\nThe player stands.\nThe village bell starts to ring.\nr i n g   r i n g \nVillagers walk out from the house.\nReady to work, ready to repeat their daily chores.\n");
            Console.Write("Does the player go to the weapon smith or the archer range? [Smith / Range]\n>");
            while (true){
                option_smith_range = Console.ReadLine();
                if(option_smith_range.ToLower() == "range") {
                    Console.WriteLine("\nsteps. steps. steps.\nBow meets air.\nTsurune.\nThe player hears the arrow being released.\nCutting through air.\nThe villager says something.\nWords that don't mean anything.\nThe player points at the…\n");
                    Console.Write("Bow or Crossbow?\n>");
                    while (true)
                    {
                        option_weapon = Console.ReadLine();
                        if(option_weapon.ToLower() == "bow")
                        {
                            Console.WriteLine("\nQuick.\nEasy to use.\nPrecise.\n");
                            break;
                        }if(option_weapon.ToLower() == "crossbow")
                        {
                            Console.WriteLine("\nSlow.\nuntrustworthy.\n");
                            break;
                        }
                    }break;
                }if(option_smith_range.ToLower() == "smith")
                {
                    Console.WriteLine("\nsteps. steps. steps.\nMetal meets metal.\nThe player hears loud clings.\nThe villager says something.\nWords that don't mean anything.\nThe player points…\n");
                    Console.Write("Sword or Axe\n>");
                    while (true)
                    {
                        option_weapon = Console.ReadLine();
                        if(option_weapon.ToLower() == "sword")
                        {
                            Console.WriteLine("\nSharp.\nHandle.\nEasy to cut.\nBut yet so weak.\n");
                            break;
                        }if(option_weapon.ToLower() == "axe")
                        {
                            Console.WriteLine("\nHeavy.\nSlow.\nGreat damage.\n");
                            break;
                        }
                    }break;
                }
            }Console.WriteLine("The villager points towards the city centre.\nTall purple portal.\nIt’s secured.\nRisk?\nYes.\nThe player runs towards the portal.\nOver the guards it goes.\nInto the portal it goes.\n");
        }
    }
}