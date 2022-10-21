using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Empty
{
    internal class Program
    {
        /*Console.Write(""); Console.ReadLine för att få input på samma linje som output*/
        /* naming variables https://www.informit.com/articles/article.aspx?p=24472
         * tolower() https://www.geeksforgeeks.org/c-sharp-tolower-method/
         * color text https://www.tutorialspoint.com/how-to-change-the-foreground-color-of-text-in-chash-console
         * fanns ej möjligeheten att göra terminal texten bold för vissa ord T_T
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empty, click enter to continue.");
            Console.ReadLine();
            intro();
            Console.ReadLine();
            Spawn.room();
            Console.ReadLine();
            Village.room();
            Console.ReadLine();
            Nether.room();
        }

        static void intro()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The world is loading.");
            Console.WriteLine("Every block is being placed.");
            Console.WriteLine("Trees and oceans are creating.");
            Console.WriteLine("Everything is simply being built up.");
            Console.WriteLine("Now it's the player's time to either set a footprint or to be forgotten.");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.Read();
        }

    } 
}