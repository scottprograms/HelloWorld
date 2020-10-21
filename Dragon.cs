using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Dragon : enemy
    {
        public int fire = 999;
        public int claws = 888;
        public int scales = 1337;
        public int hearing = 100;

        public void gameOver()
        {
            Console.WriteLine("GAME OVER!");
        }
        public override void Attack(enemy enemy)
        {
            int totalDamage = _damage + claws;
            enemy.Takedamage(totalDamage);
        }
        public Dragon()
        {
            _name = "Mr. Flame";
        }


    }  
}  