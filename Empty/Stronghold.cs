using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Stronghold
    {
        static string direction;
        static string cave_library;
        static string book;
        static string strange_storage;
        public static void room()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Stone. Stone bricks. Stonewalls.\nTwo paths. Left. Right.\n");
            Console.Write("Does the player take the left or the right? [Left / Right]\n>");
            while (true)
            {
                direction = Console.ReadLine();
                if (direction.ToLower() == "left")
                {
                    Console.WriteLine("At the end of the path there are two ways.");
                    Console.WriteLine("The left one leads to a cave and the other to a library.");
                    Console.Write("Does the player go to the cave or the library? [Cave / library]\n>");
                    while (true)
                    {
                        cave_library = Console.ReadLine();
                        if (cave_library.ToLower() == "cave")
                        {
                            Console.WriteLine("\nThe darkness wraps around the player.");
                            Console.WriteLine("One step. Two steps. Three steps, Four steps. Five steps.");
                            Console.WriteLine("“tsk…”\n“tsk…”");
                            Console.WriteLine("Light.\nDarkness.");
                            Console.WriteLine("“Failure” it thought as a high pitched sound made it deaf.");
                            Console.WriteLine("“Back to black”");

                            Death.message();
                            break;
                        }
                        if (cave_library.ToLower() == "library")
                        {
                            Console.WriteLine("Books upon books.");
                            Console.WriteLine("Taller than the player could reach.");
                            Console.WriteLine("In the middle of the room there is a book.");
                            Console.WriteLine("Shining a red flame.");
                            Console.WriteLine("The player senses a feeling of familiarity.");
                            Console.Write("Does the player open the book? [Yes / No]\n>");
                            while (true)
                            {
                                book = Console.ReadLine();
                                if (book.ToLower() == "no")
                                {
                                    Console.WriteLine("\nMaybe it's best to let it be.");
                                    Portal.room();
                                    break;
                                }
                                if (book.ToLower() == "yes")
                                {
                                    Console.WriteLine("\nIt walks up to the book.");
                                    Console.WriteLine("Take a closer look.");
                                    Console.WriteLine("“Art of war” the book says.");
                                    Console.WriteLine("The player opens the book.");
                                    Console.WriteLine("Skips a few pages until it stops.");
                                    Console.WriteLine("The player can’t continue.");
                                    Console.WriteLine("With golden letters it says:");
                                    Console.Read();
                                    Console.WriteLine("“Thus the crown of your, once belonged to a king”");
                                    Console.WriteLine("“The king ruled over the ash land”");
                                    Console.WriteLine("“Some might argue he was a kind ruler, though some say he was cruel.”");
                                    Console.WriteLine("“But when the crown is passed down, the king falls”");
                                    Console.WriteLine("“He last wish shall stand like stone”");
                                    Console.WriteLine("“Within the crown the name of the king stands”");
                                    Console.WriteLine("“Thus language might be a problem, but shall not be anymore”");
                                    Console.Read();
                                    Console.WriteLine("The player takes off the crown once again.");
                                    Console.WriteLine("It looks inside the crown where the text once was.");
                                    Console.WriteLine("The golden text starts to change form and now the player can read it.");
                                    Console.WriteLine("“Emperor T.”");
                                    Console.WriteLine("A tear drops as the player puts the crown back on its head.");

                                    Portal.room();
                                    break;
                                }
                            }
                        }
                        break;
                    }

                }
                if (direction.ToLower() == "right")
                {
                    Console.WriteLine("\nAt the end of the path there are two ways.");
                    Console.WriteLine("The left one leads to a strange room and the other to a storage room.");
                    Console.Write("Does the player go to the strange room or the storage? [Strange / Storage]\n>");
                    while (true)
                    {
                        strange_storage = Console.ReadLine();
                        if (strange_storage.ToLower() == "strange")
                        {
                            Portal.room();
                            break;
                        }
                        if (strange_storage.ToLower() == "storage")
                        {
                            Console.WriteLine("Storage room.");
                            Console.WriteLine("Chests, barrels.");
                            Console.WriteLine("Sounds of echo casts in the room.");
                            Console.WriteLine("Some have hoppers on them.");
                            Console.WriteLine("Others have furnaces in them.");
                            Console.WriteLine("Big signs indicate what stuff is where.");
                            Console.WriteLine("A bit too sorted for the player.");
                            Console.WriteLine("Not wanting to destroy anything the player leaves.");
                            Portal.room();
                            break;
                        }
                    }
                }
                break;
            }
            
        }
    }
    
}
