using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("Hello Friend! What do you go by?");
            string name = Console.ReadLine();
            Console.WriteLine("Welecome " + name + " !" + " Please select a role");
            //This variable is used to store health
            float health = 100.0f;
            //This value is used to heal the player
           float healthRegen = 20.0f;

            bool maxLevelReached = false;
            int damage = 20;
            int level = 1;
            bool ready = true;
            string role = "none";
            //Asking player to select a role.
            Console.WriteLine("Press 1 for Knight");
            Console.WriteLine("Press 2 for Wizard");
            Console.WriteLine("Press 3 for Mage");
            char input = Console.ReadKey().KeyChar;
            
            if (input == '1')
            {
                health = 250;
                role = "Knight";
            }
            else if (input == '2')
            {
                damage = 70;
                role = "Wizzard";
            }
            else if (input == '3')
            {
                health = 150;
                role = "Mage";
            }
            else
            {
               Console.WriteLine("Invalid input. Using default stats");

            }
 //Prints player stats to the screen
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("An old lady approaches you.");
            Console.WriteLine("She offers you a beverage that is to increase your health");
            Console.WriteLine("Do you accept?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().KeyChar;
               
            if(input == '1')
            {
                health = 50;
                damage = 250;
                   Console.WriteLine("A sudden rush of courage and strength come about");
                Console.WriteLine("The rush is so overwhelming and powerful it give you an aneurysm");
                Console.WriteLine("Once you finally wake up the lady is nowhere to be found and all of your gold is gone.");
                Console.WriteLine("Press any key to continue");
                input = Console.ReadKey().KeyChar;
                


            }
            else if(input == '2')
            {
                Console.WriteLine("You decline and go on with your journey");
            }
           {
             
                Console.WriteLine("A little girl comes running up to you, and asks if you'd like some water and a map?");
                Console.WriteLine("Would you like to accept?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;

                if (input == '1')
                {
                    health = 100;
                    Console.WriteLine("You thank the little girl.");
                    Console.WriteLine("You continue on your quest.");
                }
                else if (input == '2')
                {
                    Console.WriteLine("You tell the girl to piss off!");
                }

                

                
             







            }

               
          

             //Create an application that gets the user's name
            //along with an additional input. Print the user's name and input
  // the console along with their stats. Must use all data type.
             
                
         
                     
                    
     

       

         




          
           
          
             

          



            
        }
    }
}
