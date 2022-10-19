using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class End
    {
        static string distance;
        public static void room()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The player looks around.");
            Console.WriteLine("It sees a big island floating over emptiness and it can glimpse smaller islands.");
            Console.WriteLine("But between the big island and the smaller ones are void.");
            Console.WriteLine("The material that builds the islands seems weird to the player.");
            Console.WriteLine("No water can be spotted.");
            Console.WriteLine("No daylight cycle.");
            Console.WriteLine("Limited by some living organisms.");
            Console.WriteLine("\nThe player decides to build a bridge towards the island.");
            Console.WriteLine("One block. Two blocks. Three blocks.");
            Console.WriteLine("“Weird material” it murmurs to itself.");
            Console.WriteLine("As the player looks up, it’s greeted with 10 obsidian towers with a floating crystal on the top.");
            Console.WriteLine("A dragon is flying in the sky.");
            Console.WriteLine("“It’s probably the ruler in this dimension” the player thought.");
            if (Village.weapon == "bow" || Village.weapon == "crossbow")
            {
                Console.WriteLine("The player decides to shoot at the crystals which resulted in them exploding.");
                Console.WriteLine("One after one they explode.");
                Console.WriteLine("Until there is only one left.");
                Console.WriteLine("Boom.");
            }
            if (Village.weapon == "axe" || Village.weapon == "sword")
            {
                Console.WriteLine("With the only option building up to destroy the crystals.");
                Console.WriteLine("As the player builds up the more the ground gets dimmed.");
                Console.WriteLine("Last block.");
                Console.Write("Does the player stand far away from the crystal or near it? [Far / Near]\n>");
                while (true)
                {
                    distance = Console.ReadLine();
                    if (distance.ToLower() == "near")
                    {
                        Console.WriteLine("It walks near the crystal.");
                        Console.WriteLine("The crystal is shaped like a polyhedron and has a purple centre with text written on it.");
                        Console.WriteLine("As the player hits it.");
                        Console.WriteLine("A light beam shines from the crystal.");
                        Console.WriteLine("No explosion was heard.");
                        Console.WriteLine("“Failure” it thought as the darkness wrapped around it.");
                        Console.WriteLine("“Back to black”");
                        Death.message();
                        break;
                    }
                    if (distance.ToLower() == "far")
                    {
                        Console.WriteLine("The player decides to stand away from the crystal.");
                        Console.WriteLine("Though it can be depicted that the crystal is shaped like a polyhedron and has a purple centre with text written on it.");
                        Console.WriteLine("As the player hits it.");
                        Console.WriteLine("A light beam shines from the crystal.");
                        Console.WriteLine("An explosion was heard.");
                        Console.WriteLine("Quickly the player made its way down the tower.");
                        Console.WriteLine("As the dragon gets closer to the ground the player rushes towards the middle.");
                        Console.WriteLine("Every second counted.");
                        Console.WriteLine("As the dragon was about to land, the player struck.");
                        Console.WriteLine("A purple/pink light shines from the dragon and as it elevates towards the sky it explodes and tiny green particles land on the ground.");
                        Outro.message();
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
