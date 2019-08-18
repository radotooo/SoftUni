using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
  public   interface ICommando : ISpecialSoldier 
    {
        List<Imission> MissionList { get; }
    }
}
