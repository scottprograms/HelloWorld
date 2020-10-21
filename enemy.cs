using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class enemy
    {

        private int _health;
        protected int _damage;
        protected string _name;
        private int _magic;
        // Enemy Constructor
        public enemy()
        {
            _health = 25;
            _damage = 50;
            _name = "???";
            _magic = 5;
        }
        public enemy(int healthVal, int damageVal, string nameVal, int magicVal)
        {
            _health = healthVal;
            _damage = damageVal;
            _name = nameVal;
            _magic = magicVal;
        }

        public virtual void Takedamage(int damageVal)
        {
            _health -= damageVal;
        }
        public virtual void Attack(enemy enemy)
        {
            enemy.Takedamage(_damage);
        }
        public string getName()
        {
            return _name;
        }
        public int getHealth()
        {
            return _health;
        }
        public int getDamage()
        {
            return _damage;
        }
        public bool stillAlive()
        {
            return _health > 0;
        }
        public virtual bool Load(StreamReader reader)
        {
            if (File.Exists("SaveData.txt") == false)
            {
                return false;
            }
            string name = reader.ReadLine();
            int damage = 0;
            int health = 0;
            if (int.TryParse(reader.ReadLine(), out health) == false)
            {
                return false;
            }
            if (int.TryParse(reader.ReadLine(), out damage) == false)
            {
                return false;
            }
            _name = name;
            _damage = damage;
            _health = health;
            
            return true;
       
        }
    }   
    
}
