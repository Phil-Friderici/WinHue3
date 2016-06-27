﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleHandler.ExecuteCommand(args.Any() ? args : new string[] {"-help"});
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(@"Error : Sorry, this program cannot be run alone by itself and require to be located in it's original folder.");
            }
        }
    }
}
