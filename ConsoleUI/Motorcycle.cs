using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasTrunk { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("testytest");
        }
    }
}
