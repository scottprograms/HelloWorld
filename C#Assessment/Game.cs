using System;
using System.IO;

namespace HelloWorld
{
   
    class Game
    {
        public float healthRegen = 20.0f;
        public bool maxLevelReached = false;
        public int level = 1;
        public bool ready = true;
        private enemy troll = new enemy(50, 50, "Troll", 0);
        private enemy goblin = new enemy(25, 5, "Goblin", 0);
        private enemy fairy = new enemy(40, 35, "Fairy", 50);
        private player player = new player("douche", 100, 20, "none");
        enemy[] enemies = new enemy[3];
     
        
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("invalid input!");
                }
            }

        }
        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void Run()
        {

            Start();
         
            char input;
            
            Console.WriteLine("An old lady approaches you.");
            Console.WriteLine("She offers you a beverage that is to increase your health");
            GetInput(out input, "yes", "no", "Do you accept?");
            if (input == '1')
            {
               
                Console.WriteLine("A sudden rush of courage and strength come about");
                Console.WriteLine("The rush is so overwhelming and powerful it give you an aneurysm");
                Console.WriteLine("Once you finally wake up the lady is nowhere to be found and all of your gold & weapons are gone.");
                Console.WriteLine("Press any key to continue");
                input = Console.ReadKey().KeyChar;

            }
            else if (input == '2')
            {
                Console.WriteLine("You decline and go on with your journey");
            }


            Console.WriteLine("A little girl comes running up to you, and asks if you'd like some water and a map?");
            
            GetInput(out input, "yes", "no", " Would you like to accept?");

          


            if (input == '1')
            {
               
                Console.WriteLine("You thank the little girl.");
                Console.WriteLine("You continue on your quest.");
            }
            else if (input == '2')
            {
                Console.WriteLine("You tell the girl to piss off!");
            }
            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;
            Console.WriteLine("Along the path you find a bag");
            
            GetInput(out input, "yes", "no", "Would you like to pick it up?");
            if (input == '1')
            {
                Console.WriteLine("You open the bag and find some Mushrooms");
            }
            else if (input == '2')
            {
                Console.WriteLine("Leave the bag as is");
            }
            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;
            Console.WriteLine("Along the journey you look around and come across a small house");
            ;
            GetInput(out input, "yes", "no", "Would you dare to enter");
            if (input == '1')
            {
                Console.WriteLine("You enter the house and see a pile of dead courpes on the floor and slowly backup and close the door");
            }
            else if (input == '2')
            {
                Console.WriteLine("You pay no mind to the house and continue on the quest");
            }
            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;
            Console.WriteLine("As you are walking down the trail a man comes up to you and asks Where are you heading?");
            Console.WriteLine("You reply to the man I am heading to the cave to slay the dragon.");
            Console.WriteLine("The man response with THE DRAGON!!!!");
            Console.WriteLine("You nod your head");
            Console.WriteLine("I wish you the best of luck the man says.");
            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;
            Console.Clear();
            Console.WriteLine("After deling with the man, you notice a pond in the woods.");
            Console.WriteLine("You take a moment to rest and drink some water by the pond and see a chest off in the distance by a tree.");
            Console.WriteLine("You open the chest and find WEAPONS!!!");
            Console.WriteLine("You find a sword, a dagger,a wand, and morning star.");
            Console.WriteLine("Press 1 for the sword");
            Console.WriteLine("Press 2 for the dagger");
            Console.WriteLine("Press 3 for the wand");
            Console.WriteLine("Press 4 for the morning star");
            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine("You have selected the Sword");
            }
            if (input == '2')
            {
                Console.WriteLine("You have selected the Dagger");
            }
            if (input == '3')
            {
                Console.WriteLine("You have selected the Wand");
            }
            if (input == '4')
            {
                Console.WriteLine("You have selected the Morning Star");
            }
            Console.WriteLine("After you selected your weapon, while walking you find a group of enemies");
            //Array #1
            

            enemies[0] = troll;
            enemies[1] = goblin;
            enemies[2] = fairy;
            Update();

            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;
            Console.Clear();
            Console.WriteLine("After fighting the enemies you find the Dragon's cave.");
            Console.WriteLine("You walk into the cave and find the Dragon sleeping but you kick a rock and it wakes up.");

            Console.WriteLine("You begin to fight the Dragon");
            Console.WriteLine("You attack the Dragon but dont make any noticable damage");
            Console.WriteLine("The Dragon attacks you and you die!");
            
            End();

        }
        
        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
           
            writer.Close();
        }

        //loads stats and level for the player
        public bool Load()
        {
            if (File.Exists("SaveData.txt") == false)
            {
                return false;
            }
           
            StreamReader reader = new StreamReader("SaveData.txt");
           
            reader.Close();
            return true;
        }
        public virtual void gameOver()
        {
            Dragon[] Dragons = new Dragon[2];
            Dragons[0] = new Dragon();
            
            Dragons[1] = new Dragon();

            Dragons[0].gameOver();
            int health = 0;
        }
        

        public void Battle(enemy enemy)
        {
            char input;
            Console.WriteLine("you ran into " + enemy.getName());
            while (player.stillAlive() && enemy.stillAlive())
            {


                GetInput(out input, "yes", "no", "Do you want to fight?");

                if (input == '1')
                {

                    Console.WriteLine("You begin to fight the" + enemy.getName());
                    Console.WriteLine("You attack the" + enemy.getName() + " and kill it."); ;
                    player.Attack(enemy);
                }

                if (input == '2')
                {
                    Console.WriteLine("You try and run away, but you trip and fall.");
                    Console.WriteLine(player.getName() + " Has taken 5 damage for falling");
                    player.Takedamage(5);
                    Console.WriteLine(player.getHealth());
                }
            }
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello Friend! What do you go by?");
            string name = Console.ReadLine();
            char input;
            GetInput(out input, "knight", "wizzard", "mage", "Welecome " + name + " !" + " Please select a role");


            if (input == '1')
            {
                player = new player(name, 250, 50, "Knight");
            }

            else if (input == '2')
            {
                player = new player(name, 300, 70, "Wizzard");
            }

            else if (input == '3')
            {
                player = new player(name, 150, 25, "Mage");
            }
            else
            {
                Console.WriteLine("Invalid input. Using default stats");

            }
            //Prints player stats to the screen
            Console.WriteLine("Player Name: " + player.getName());
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + player.getRole());
            Console.WriteLine("Player Health: " + player.getHealth());
            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;
            Console.Clear();
        } 



        public void Update()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Battle(enemies[i]);
            }
        }
        public void End()
        {
            gameOver();
        }
     

        






















































        //Create an application that gets the user's name
        //along with an additional input. Print the user's name and input
        // the console along with their stats. Must use all data type.
































        //Create an application that gets the user's name
        //along with an additional input. Print the user's name and input
        // the console along with their stats. Must use all data type.
























    }

}        
    

