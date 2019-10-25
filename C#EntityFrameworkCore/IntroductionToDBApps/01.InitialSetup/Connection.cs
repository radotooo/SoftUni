using System;
using System.Collections.Generic;
using System.Text;

namespace _01.InitialSetup
{
   public static class Connection
    {
        public static string Connect = "Server=DESKTOP-2N08KCV\\SQLEXPRESS;" +
                                            "Initial Catalog=Master;" +
                                            "Integrated Security=true;";

        public static string MySqlConnection = "Server=DESKTOP-2N08KCV\\SQLEXPRESS;" +
                                                 "Initial Catalog=MinionsDB;" +
                                                 "Integrated Security=true;";


    }

}