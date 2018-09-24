using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean appRunState = true; //application run state control variable
            string checkForExit = "null";

            // create the Virtual pet
            VirtualPet myPet = new VirtualPet();

            //promt user for name and species for UI
            Console.WriteLine("Welcome to VirtualPet Please enter a Name for your Pet");
            myPet.PetName = Console.ReadLine();
            Console.WriteLine("Please enter a Species for your Pet");
            myPet.Species = Console.ReadLine();

            int tickCount = 0; //counts until mod 3 == 0 then call Tick()

            do
            { // run state of program/// option to exit loop.

                

                // display UI
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0} the {1} ", myPet.PetName, myPet.Species);
                Console.WriteLine();
                Console.WriteLine("Hunger:  " + myPet.Hunger);                                                    // display pet status
                Console.WriteLine("Thirst:  " + myPet.Thirst);
                Console.WriteLine("Boredom:  " + myPet.Boredom);
                Console.WriteLine("Sickness:  " + myPet.Sickness);
                Console.WriteLine();
                Console.WriteLine("What would you like to do");
                Console.WriteLine();
                Console.WriteLine("< 1 > Feed {0}",myPet.PetName);
                Console.WriteLine();
                Console.WriteLine("< 2 > Water {0}",myPet.PetName);
                Console.WriteLine();
                Console.WriteLine("< 3 > Play with {0}",myPet.PetName);              
                Console.WriteLine();
                Console.WriteLine("< 4 > Do Nothing");

                // prompt menu response
                int menuSelection = int.Parse(Console.ReadLine());

                //display action and call class methods
                if (menuSelection == 1)
                {
                    Console.WriteLine("You fed {0}", myPet.PetName);
                    myPet.Food();
                    tickCount++;
                }
                if (menuSelection == 2)
                {
                    Console.WriteLine("You watered {0}", myPet.PetName);

                    myPet.Water();
                    tickCount++;
                }
                if (menuSelection == 3)
                {
                    Console.WriteLine("You played with {0}", myPet.PetName);
                    myPet.PlayTime();
                    tickCount++;
                }
               
                if (menuSelection == 4)
                {
                    Console.WriteLine("You did nothing");
                    tickCount++;
                }

                if (tickCount % 3 == 0) 
                {
                    myPet.Tick();
                }






            
                





















                //EXIT PROGRAM OPTION
                Console.WriteLine();
                Console.WriteLine("Do you wish to Exit? Enter \"Yes\" or \"No\"");
                
                checkForExit = Console.ReadLine();
                checkForExit = checkForExit.ToLower();

                if (checkForExit.Equals("yes"))
                {
                    appRunState = false;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    // good bye message  exit system here !
                }

                //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER //NO CODE BEYOND HERE DANGER


            } while (appRunState);// end exit program loop

        }        
    }
}
