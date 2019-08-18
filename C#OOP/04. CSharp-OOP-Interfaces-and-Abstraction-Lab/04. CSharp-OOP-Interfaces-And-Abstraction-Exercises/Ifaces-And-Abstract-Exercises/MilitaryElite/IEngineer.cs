using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IEngineer : ISpecialSoldier/*,IRepair*/
    {
        List<IRepair> RepairList { get; }
    }
}
