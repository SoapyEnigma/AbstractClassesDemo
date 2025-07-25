using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving my car in an abstracted way!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Driving my motorcycle in a virtual way!");
        }
    }
}
