using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static int id;
        static string firstName;
        static string lastName;
        static decimal salary;
        static string corp;





        static void Main(string[] args)
        {

            var privateList = new List<Private>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                else if (input[0] == "Private")
                {
                    id = int.Parse(input[1]);
                    firstName = input[2];
                    lastName = input[3];
                    salary = decimal.Parse(input[4]);

                    var privateSoldie = new Private(id, firstName, lastName, salary);
                    privateList.Add(privateSoldie);
                    Console.WriteLine(privateSoldie);
                }
                else if (input[0] == "Spy")
                {
                    id = int.Parse(input[1]);
                    firstName = input[2];
                    lastName = input[3];

                    int code = int.Parse(input[4]);


                    var spy = new Spy(id, firstName, lastName, code);
                    Console.WriteLine(spy);

                }
                else if (input[0] == "Engineer")
                {
                    id = int.Parse(input[1]);
                    firstName = input[2];
                    lastName = input[3];
                    salary = decimal.Parse(input[4]);
                    corp = input[5];
                    try
                    {
                        var engineer = new Engineer(id, firstName, lastName, salary, corp);
                        //string[] result = input.Skip(6).ToArray();
                        for (int i = 6; i < input.Length; i += 2)
                        {
                            string partname = input[i];
                            int hours = int.Parse(input[i + 1]);
                            var repair = new Repair(partname, hours);
                            engineer.Add(repair);
                        }
                        Console.WriteLine(engineer);
                    }
                    catch (ArgumentException)
                    {

                        //continue;
                    }



                }
                else if (input[0] == "Commando")
                {
                    id = int.Parse(input[1]);
                    firstName = input[2];
                    lastName = input[3];
                    salary = decimal.Parse(input[4]);
                    corp = input[5];

                    try
                    {
                        var commando = new Commando(id, firstName, lastName, salary, corp);
                        //string[] result = input.Skip(6).ToArray();

                        for (int i = 6; i < input.Length; i += 2)
                        {
                            string partname = input[i];
                            string state = input[i + 1];
                            try
                            {
                                var repair = new Mission(partname, state);
                                commando.Add(repair);
                            }
                            catch (ArgumentException)
                            {

                                //continue;
                            }

                        }
                        Console.WriteLine(commando);
                    }
                    catch (ArgumentException)
                    {

                        //continue;
                    }
                }
                else if (input[0] == "LieutenantGeneral")
                {
                    id = int.Parse(input[1]);
                    firstName = input[2];
                    lastName = input[3];
                    salary = decimal.Parse(input[4]);



                    var leutenant = new LieutenantGeneral(id, firstName, lastName, salary);
                    //string[] result = input.Skip(5).ToArray();

                    for (int i = 5; i < input.Length; i++)
                    {
                        int num = int.Parse(input[i]);
                        var currentPrivateSoldier = privateList.FirstOrDefault(x => x.Id == num);
                        leutenant.Add(currentPrivateSoldier);



                    }
                    Console.WriteLine(leutenant);



                }
            }
        }
    }
}
