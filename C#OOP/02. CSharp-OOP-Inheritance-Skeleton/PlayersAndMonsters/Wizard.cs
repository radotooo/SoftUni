using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level)
            : base(name, level)

        {
            this.Username = name;
            this.Level = level;
        }
    }
}
