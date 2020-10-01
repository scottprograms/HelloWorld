using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class enemy
    {
        public int health = 25;
        public int damage = 10;
        public string name = "";
        public int magic = 5;
        public void Takedamage()
        {
            health -= 50;
        }

    }   
    
}
