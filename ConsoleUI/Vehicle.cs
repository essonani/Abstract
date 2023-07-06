using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "value x";
        public string Model { get; set; }= "value x";
        public string Make { get; set; } = "value x";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("default drive method");
        }
    }
}
