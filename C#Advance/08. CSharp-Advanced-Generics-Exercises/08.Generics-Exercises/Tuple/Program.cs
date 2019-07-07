using System;
using System.Collections.Generic;

namespace Tuple
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string[] beerInfo = Console.ReadLine().Split();
            string[] nameAndBankBalanceInfo = Console.ReadLine().Split();

            string personName = personInfo[0] + " " + personInfo[1];
            string personAdres = personInfo[2];

            string personCity = personInfo.Length > 4 ? personInfo[3] + " " + personInfo[4] : personInfo[3];

            var personInfoTuple = new Tuple<string, string, string>(personName, personAdres, personCity);

            string beerPersonName = beerInfo[0];
            int beersCount = int.Parse(beerInfo[1]);
            string chek = beerInfo[2];
            bool result = chek == "drunk" ? true : false;
            var personBeerTuple = new Tuple<string, int, bool>(beerPersonName, beersCount, result);

            string bankPersonName = nameAndBankBalanceInfo[0];
            double bankAccBalance = double.Parse(nameAndBankBalanceInfo[1]);

            string bankName = nameAndBankBalanceInfo[2];
            
            var bankTuple = new Tuple<string, double, string>(bankPersonName, bankAccBalance, bankName);


            personInfoTuple.Print();
            personBeerTuple.Print();
            bankTuple.Print();











        }
    }
}
