namespace Empty
{
    internal class Program
    {

        static int number;
        /*Console.Write("");
        Console.Read();*/

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
            Console.Write("\n-------------------------------------------------------------------------\n\n");
            Console.Write("The world is loading.");
            Console.WriteLine(" Every block is being placed.");
            Console.WriteLine("Trees and oceans are creating.");
            Console.WriteLine("Everything is simply being built up.");
            Console.Write("Now it's the player's time to either set a footprint or to be forgotten.");
            Console.Write("\n\n-------------------------------------------------------------------------");
            Console.Read();
        }

        static void Spawn()
        {
            Console.WriteLine("hello");
        }
    }
}