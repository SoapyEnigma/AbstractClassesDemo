using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving my car in an abstracted way!");
        }
    }
}
