using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public Knight(string name, int level)
            : base(name, level)

        {
            this.Username = name;
            this.Level = level;
        }
    }
}
