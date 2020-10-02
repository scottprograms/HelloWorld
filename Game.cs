using System;

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
<<<<<<< HEAD

=======
>>>>>>> master
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

<<<<<<< HEAD
=======

>>>>>>> master
            if (input == '1')
            {
                health = 250;
                damage = 50;
                role = "Knight";
            }
            else if (input == '2')
            {
                health = 300;
                damage = 70;
                role = "Wizzard";
            }
            else if (input == '3')
            {
                health = 150;
                damage = 25;
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
            input = Console.ReadKey().KeyChar;
            Console.Clear();
            Console.WriteLine("An old lady approaches you.");
            Console.WriteLine("She offers you a beverage that is to increase your health");
            Console.WriteLine("Do you accept?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            input = Console.ReadKey().KeyChar;

<<<<<<< HEAD
=======

>>>>>>> master
            if (input == '1')
            {
                health = 50;
                damage = 250;
                Console.WriteLine("A sudden rush of courage and strength come about");
                Console.WriteLine("The rush is so overwhelming and powerful it give you an aneurysm");
                Console.WriteLine("Once you finally wake up the lady is nowhere to be found and all of your gold & weapons are gone.");
                Console.WriteLine("Press any key to continue");
                input = Console.ReadKey().KeyChar;
<<<<<<< HEAD
=======



>>>>>>> master
            }
            else if (input == '2')
            {
                Console.WriteLine("You decline and go on with your journey");
            }
            {
<<<<<<< HEAD
=======

>>>>>>> master
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
                Console.WriteLine("Press any key to continue");
                input = Console.ReadKey().KeyChar;
<<<<<<< HEAD
                Console.Clear();
                Console.WriteLine("After dealing with the little girl a man come to you and says you look familiar, but you tell him that you're a travelor from the East.");
                Console.WriteLine("The man says Where are you heading sir?");
                Console.WriteLine("Your response to the man is that you're on a quest to slay a dragon for a reward");
                Console.WriteLine("THE DRAGON!!! says the man.");
                Console.WriteLine("You nod your head as your reply.");
                Console.WriteLine("Goodluck!! says the man. Then you continue down the trail.");
                Console.WriteLine("Press Space to continue");
                input = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine("As you continue the journey and find a small pond to rest.");
                Console.WriteLine("While taking your rest you see by a tree that there is a chest");
                Console.WriteLine("You walk up to the chest and open it and find.....");
                Console.WriteLine("Press Space to continue");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine("You've found a Sword and a Potion!!!");






















=======
                Console.WriteLine("Along the path you find a bag");
                Console.WriteLine("Would you like to pick it up?");
                Console.WriteLine("Press 1 for Yes.");
                Console.WriteLine("Press 2 for No");
                input = Console.ReadKey().KeyChar;
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
                Console.WriteLine("Would you dare to enter?");
                Console.WriteLine("Press 1 for Yes.");
                Console.WriteLine("Press 2 for No");
                input = Console.ReadKey().KeyChar;
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
                
                enemy[] enemies = new enemy[3];

                enemies[0] = new enemy();
                enemies[1] = new enemy();
                enemies[2] = new enemy();

                enemies[0].name = "Goblin";
                enemies[1].name = "Troll";
                enemies[2].name = "Fairy";

                Console.WriteLine("Your first enemy is a Goblin");
                Console.WriteLine("Do you want to fight?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;

                if (input == '1')
                {
                    Console.WriteLine("You begin to fight the Goblin");
                    Console.WriteLine("You attack the Goblin and kill it.");
                    enemies[0].Takedamage();
                }

                if (input == '2')
                {
                    Console.WriteLine("You try and run away, but you trip and fall.");
                    Console.WriteLine(name + " Has taken 5 damage for falling");
                    health -= 5;
                    Console.WriteLine(health);
                }
                Console.WriteLine("Now a Troll appears would you like to fight?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine("You begin to fight the Troll.");
                    Console.WriteLine("You attack the Goblin and kill it.");
                    enemies[1].Takedamage();
                }

                if (input == '2')
                {
                    Console.WriteLine("You try and run away, but you trip and fall.");
                    Console.WriteLine(name + " Has taken 5 damage for falling");
                    health -= 5;
                    Console.WriteLine(health);
                }
                Console.WriteLine("A Fairy flies up to you and wants to challenges you. Do you want to fight?");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine("You begin to fight the Fairy.");
                    Console.WriteLine("You attack the Goblin and kill it.");
                    enemies[2].Takedamage();
                }

                if (input == '2')
                {
                    Console.WriteLine("You try and run away, but you trip and fall.");
                    Console.WriteLine(name + " Has taken 5 damage for falling");
                    health -= 5;
                    Console.WriteLine(health);
                }
                Console.WriteLine("Press any key to continue");
                input = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine("After fighting the enemies we find the Dragon's cave.");
                Console.WriteLine("You walk into the cave and find the Dragon sleeping but you kick a rock and it wakes up.");
                
                Dragon[] Dragons = new Dragon[2];
                Dragons[0] = new Dragon()
                {
                    name = "Mr.flame"
                };
                
                Dragons[1] = new Dragon();

                Console.WriteLine("You begin to fight the Dragon");
                Console.WriteLine("You attack the Dragon but dont make any noticable damage");
                Console.WriteLine("The Dragon attacks you and you die!");
                Dragons[0].gameOver();

















>>>>>>> master









<<<<<<< HEAD


            //Create an application that gets the user's name
            //along with an additional input. Print the user's name and input
            // the console along with their stats. Must use all data type.














=======
>>>>>>> master










<<<<<<< HEAD
=======







                //Create an application that gets the user's name
                //along with an additional input. Print the user's name and input
                // the console along with their stats. Must use all data type.
























            }
>>>>>>> master
        }
    }
}
