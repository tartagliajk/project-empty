using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Village
    {
        static string smith_range;
        public static string weapon;
        public static void room()
        {
            Console.WriteLine("Sunset.");
            Console.WriteLine("A mix of pink and blue starts to emerge onto the sky.");
            Console.WriteLine("From a distance the player spots a tree.");
            Console.WriteLine("The player decides to make a temporary base there for the night.");
            Console.WriteLine("A tent.");
            Console.WriteLine("A roof over the head.");
            Console.WriteLine("Night.");
            Console.WriteLine("Quietness, darkness, stars that sparkle.");
            Console.WriteLine("...\n...\n...");
            Console.WriteLine("Sunrise.");
            Console.WriteLine("The player stands.");
            Console.WriteLine("The village bell starts to ring.");
            Console.WriteLine("r i n g   r i n g");
            Console.WriteLine("Villagers walk out from the house.");
            Console.WriteLine("Ready to work, ready to repeat their daily chores.");

            Console.Write("Does the player go to the weapon smith or the archer range? [Smith / Range]\n>");
            while (true)
            {
                smith_range = Console.ReadLine();
                if (smith_range.ToLower() == "range")
                {
                    Console.WriteLine("steps. steps. steps.");
                    Console.WriteLine("Bow meets air.");
                    Console.WriteLine("Tsurune.");
                    Console.WriteLine("The player hears the arrow being released.");
                    Console.WriteLine("Cutting through air.");
                    Console.WriteLine("The villager says something.");
                    Console.WriteLine("Words that don't mean anything.");
                    Console.WriteLine("The player points at the…");

                    Console.Write("Bow or Crossbow?\n>");
                    while (true)
                    {
                        weapon = Console.ReadLine();
                        if (weapon.ToLower() == "bow")
                        {
                            Console.WriteLine("\nQuick.\nEasy to use.\nPrecise.\n");
                            break;
                        }
                        if (weapon.ToLower() == "crossbow")
                        {
                            Console.WriteLine("\nSlow.\nuntrustworthy.\n");
                            break;
                        }
                    }
                    break;
                }
                if (smith_range.ToLower() == "smith")
                {
                    Console.WriteLine("steps. steps. steps.");
                    Console.WriteLine("Metal meets metal.");
                    Console.WriteLine("The player hears loud clings.");
                    Console.WriteLine("The villager says something.");
                    Console.WriteLine("Words that don't mean anything.");
                    Console.WriteLine("The player points…");

                    Console.Write("Sword or Axe\n>");
                    while (true)
                    {
                        weapon = Console.ReadLine();
                        if (weapon.ToLower() == "sword")
                        {
                            Console.WriteLine("\nSharp.\nHandle.\nEasy to cut.\nBut yet so weak.\n");
                            break;
                        }
                        if (weapon.ToLower() == "axe")
                        {
                            Console.WriteLine("\nHeavy.\nSlow.\nGreat damage.\n");
                            break;
                        }
                    }
                    break;
                }
            }
            Console.WriteLine("The villager points towards the city centre.");
            Console.WriteLine("Tall purple portal.");
            Console.WriteLine("It’s secured.");
            Console.WriteLine("Risk?");
            Console.WriteLine("Yes.");
            Console.WriteLine("The player runs towards the portal.");
            Console.WriteLine("Over the guards it goes.");
            Console.WriteLine("Into the portal it goes.");
        }
    }
}
