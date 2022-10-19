using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    internal class Nether
    {
        static string chests_near_spawner;
        static string chests_return;
        static string lava_dig;
        public static void room()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Heat.");
            Console.WriteLine("Hugging the player.");
            Console.WriteLine("Ash, some even might say it’s comforting.");
            Console.WriteLine("Thick air.");
            Console.WriteLine("Not far away the player spots a building.");
            Console.WriteLine("The fortress, which they have heard about before.");
            Console.WriteLine("The player crosses the lava.");
            Console.WriteLine("A building.");
            Console.WriteLine("Two ways.");

            Console.Write("Does the player want to go to the spawner or explore chests? [Spawner / Chests]\n>");
            while (true)
            {
                chests_near_spawner = Console.ReadLine();
                if (chests_near_spawner.ToLower() == "spawner")
                {
                    Spawner.fight();
                    Console.Write("Does the player want to explore the chestroom or return back? [Chests / Return]\n>");
                    while (true)
                    {
                        chests_return = Console.ReadLine();
                        if (chests_return.ToLower() == "chests")
                        {
                            Chest_Room();
                            break;
                        }
                        if (chests_return.ToLower() == "return")
                        {
                            break;
                        }
                    }
                    break;
                }
                if (chests_near_spawner.ToLower() == "chests")
                {
                    Chest_Room();
                    Console.WriteLine("Still in need of the powder, the player walks towards the spawner.");
                    Spawner.fight();
                    break;
                }
            }
            Console.Write("\nDoes it bridge over the lava or does the player dig its way through? [Lava / Dig]\n>");
            while (true)
            {
                lava_dig = Console.ReadLine();
                if (lava_dig.ToLower() == "lava")
                {
                    Console.WriteLine("One block, Two blocks, Three blocks, Four blocks.");
                    Console.WriteLine("Misplaced.");
                    Console.WriteLine("It falls from its own creation.");
                    Console.WriteLine("“Failure” it thought as the lava wrapped around it.");
                    Console.WriteLine("“Back to black”.");

                    Death.message();
                    break;
                }
                if (lava_dig.ToLower() == "dig")
                {
                    Console.WriteLine("\nOne block, Two blocks, Three blocks, Four blocks.");
                    Console.WriteLine("The smell of ash made it hard to breathe in the limited area.");
                    Console.WriteLine("Pig? Man? Pigman? King?");
                    Console.WriteLine("The player looked at it.");
                    Console.WriteLine("It had a bloody robe.");
                    Console.WriteLine("Crown? With some jewels on.");
                    Console.ReadLine();
                    Console.WriteLine("Red, green, blue, purple.");
                    Console.WriteLine("It looked at the player.");
                    Console.WriteLine("Nodded and reached out a hand.");
                    Console.WriteLine("The player looked at it.");
                    Console.WriteLine("Hesitant the player gave it its hand.");
                    Console.WriteLine("The pigman walked with confident steps towards a tunnel.");
                    Console.WriteLine("It signalled that the player should go through the tunnel.");
                    Console.WriteLine("The player walked towards it.");
                    Console.WriteLine("It looked at the player with a smile and it took off its crown. ");
                    Console.WriteLine("It held it towards the player.");
                    Console.WriteLine("The player bowed and the pigman put the crown on the player's head.");
                    Console.WriteLine("It waved a hand towards the tunnel.");
                    Console.WriteLine("“Don’t look back,” it said.");
                    Console.ReadLine();
                    Console.WriteLine("The player walked through the tunnel not daring to look back.");
                    Console.WriteLine("Purple blue light shines through the tunnel.");
                    Console.WriteLine("The player walks through the portal, it wanted to look back but didn’t have the courage to do it.");
                    Console.WriteLine("Instead it took off the brown and held it closer so it could get a better view.");
                    Console.WriteLine("On the band inside the crown there was text.");
                    Console.WriteLine("It could not read it.");
                    Console.WriteLine("It put the crown back on its head and looked at the surroundings.");
                    Stronghold.room();
                    break;
                }
            }
        }
        static void Chest_Room()
        {
            Console.WriteLine("Chestroom.");
            Console.WriteLine("The player finds gold, diamonds, rubies, emeralds etc.");
            Console.WriteLine("But nothing useful");
            Console.WriteLine("So it puts everything back.");
        }
    }
}
