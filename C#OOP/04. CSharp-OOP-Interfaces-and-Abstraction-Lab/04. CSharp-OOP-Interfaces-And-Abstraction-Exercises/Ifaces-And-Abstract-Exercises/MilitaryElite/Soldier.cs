using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Soldier : ISoldier
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }
    }
}
