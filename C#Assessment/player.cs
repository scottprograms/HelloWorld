using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{

    class player : enemy
    {
        private string _role;
        public player() : base()
        {
            _role = "human";
        }
        public player(string nameVal, int healthVal, int damageVal, string role) : base(healthVal, damageVal, nameVal, 20)
        {
            _role = role;
        }
        public string getRole()
        {
            return _role;
        }
        public void Save(StreamWriter writer)
        {
            writer.WriteLine(getName());
            writer.WriteLine(getHealth());
            writer.WriteLine(getDamage());
            writer.WriteLine(getRole());
        }
        public override bool Load(StreamReader reader)
        {
            if (base.Load(reader))
            {
                string role = reader.ReadLine();
                _role = role;
            }
            return true;
        }
    }
}
