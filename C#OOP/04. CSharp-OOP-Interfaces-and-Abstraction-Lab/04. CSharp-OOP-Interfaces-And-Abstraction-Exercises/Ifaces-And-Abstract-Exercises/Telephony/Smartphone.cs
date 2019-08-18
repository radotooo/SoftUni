using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowse, ICall
    {


        public string Browse(string url)
        {
            if (url.ToCharArray().Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
           if(number.ToCharArray().Any(x => !char.IsDigit(x)))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }
    }
}
