using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpecialSoldier : IPrivate
    {
        string Corps { get; }
    }
}
