using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public  interface IBuyer
    {
        int Food { get; set; }
        string Name { get; }
        void BuyFood();

    }
}
