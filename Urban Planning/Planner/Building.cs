using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planning.Planner
{
    class Building
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get; private set; }


        string _designer;
        DateTime _dateConstructed;
        string _address;
        string _owner;

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _designer = "Chris";
            _dateConstructed = DateTime.Now;
            Volume = Width * Depth * (3 * Stories);

            Console.WriteLine($"{_address} ----------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

        public void Purchase(string buildingBuyer)
        {
            _owner = buildingBuyer;
            Console.WriteLine($"Building purchased by {buildingBuyer}");
        }

    }
}
