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
            Console.WriteLine("Welecome " + name + " Please select a role");
            //This variable is used to store health
            float health = 100.0f;
            //This value is used to heal the player
           float healthRegen = 20.0f;
            string role = Console.ReadLine();
             bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
              bool ready = true;
             Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Player Health: " + health);
             //Create an application that gets the user's name
            //along with an additional input. Print the user's name and input
            //to the console along with their stats. Must use all data type.
          
           
          
             

          



            
        }
    }
}
