﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle:Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("the motocycle is advancing");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("motorcycle virtual drive method ");
        }
    }
}
