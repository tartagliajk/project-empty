using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Empty
{
    internal class Program
    {

        static string option_village_trees;
        static string option_village_tools;
        static string option_smith_range;
        static string option_weapon;
        static string option_spawner_chests;
        static string option_chests_return;
        static string option_lava_dig;
        /*Console.Write(""); Console.ReadLine för att få input på samma linje som output*/
        /* naming variables https://www.informit.com/articles/article.aspx?p=24472
         * tolower() https://www.geeksforgeeks.org/c-sharp-tolower-method/
         * color text https://www.tutorialspoint.com/how-to-change-the-foreground-color-of-text-in-chash-console
         * fanns ej möjligeheten att göra terminal texten bold för vissa ord T_T
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
            Console.Read();
            Nether();
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
            }Console.WriteLine("The villager points towards the city centre.\nTall purple portal.\nIt’s secured.\nRisk?\nYes.\nThe player runs towards the portal.\nOver the guards it goes.\nInto the portal it goes.");
        }

        static void Spawner_fight()
        {
            Console.WriteLine("\nBurning beings.\nWho gave powders.\nThe player walks with definite steps.");
            if(option_weapon == "sword")
            {
                Console.WriteLine("The player rise its sword and swing it at the enemies.");
            }if(option_weapon == "axe")
            {
                Console.WriteLine("With a hasty motion the player raises its axe and chops the opponents.");
            }if(option_weapon == "bow")
            {
                Console.WriteLine("Arrow in íts hand. Putting it next to the bow string. A sound of arrow swoshing past and into the opponents soul.");
            }if(option_weapon == "crossbow")
            {
                Console.WriteLine("The arrow has been loaded. The player charge press the fire button.");
            }
            Console.WriteLine("Lifeless powder on the ground.\nThe player picks some of it up.\n");
        }
        static void Chest_Room()
        {
            Console.WriteLine("\nChestroom.\nThe player finds gold, diamonds, rubies, emeralds etc.\nBut nothing useful.\nSo it puts everything back.");
        }
        static void Nether()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Heat.\nHugging the player.\nAsh, some even might say it’s comforting.\nThick air.\nNot far away the player spots a building.\nThe fortress, which they have heard about before.\nThe player crosses the lava.\nA building.\nTwo ways.\n");
            Console.Write("Does the player want to go to the spawner or explore chests? [Spawner / Chests]\n>");
            while (true)
            {
                option_spawner_chests = Console.ReadLine();
                if(option_spawner_chests.ToLower() == "spawner")
                {
                    Spawner_fight();
                    Console.Write("Does the player want to explore the chestroom or return back? [Chests / Return]\n>");
                    while (true)
                    {
                        option_chests_return = Console.ReadLine();
                        if(option_chests_return.ToLower() == "chests")
                        {
                            Chest_Room();
                            break;
                        }if(option_chests_return.ToLower() == "return")
                        {
                            break;
                        }
                    }
                    break;
                }if(option_spawner_chests.ToLower() == "chests")
                {
                    Chest_Room();
                    Console.WriteLine("Still in need of the powder, the player walks towards the spawner.");
                    Spawner_fight();
                    break;
                }
            }
            Console.Write("\nDoes it bridge over the lava or does the player dig its way through? [Lava / Dig]\n>");
            while (true)
            {
                option_lava_dig = Console.ReadLine();
                if(option_lava_dig.ToLower() == "lava")
                {
                    Console.WriteLine("One block, Two blocks, Three blocks, Four blocks.\nMisplaced.\nIt falls from its own creation.\n“Failure” it thought as the lava wrapped around it.\n“Back to black”.\nDeath.");
                    break;
                }if(option_lava_dig.ToLower() == "dig")
                {
                    Console.WriteLine("One block, Two blocks, Three blocks, Four blocks.\nThe smell of ash made it hard to breathe in the limited area.\nPig? Man? Pigman? King?\nThe player looked at it.\nIt had a bloody robe.\nCrown? With some jewels on.");
                    Console.Read();
                    Console.WriteLine("Red, green, blue, purple.\nIt looked at the player.\nNodded and reached out a hand.\nThe player looked at it.\nHesitant the player gave it its hand.\nThe pigman walked with confident steps towards a tunnel.\n");
                    Console.WriteLine("It signalled that the player should go through the tunnel.\nThe player walked towards it. \nIt looked at the player with a smile and it took off its crown. \nIt held it towards the player.");
                    Console.WriteLine("The player bowed and the pigman put the crown on the player's head.\nIt waved a hand towards the tunnel.\n“Don’t look back,” it said.");
                    Console.Read();
                    Console.WriteLine("\nThe player walked through the tunnel not daring to look back.\\nPurple blue light shines through the tunnel.");
                    Console.WriteLine("The player walks through the portal, it wanted to look back but didn’t have the courage to do it. \nInstead it took off the brown and held it closer so it could get a better view.");
                    Console.WriteLine("On the band inside the crown there was text.\nIt could not read it.\nIt put the crown back on its head and looked at the surroundings.\n");
                    stronghold();
                    break;
                }
            }
        }
        static void stronghold()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Stone. Stone bricks. Stonewalls.\nTwo paths. Left. Right.\n");

        }
    }
}