using System;
using Urban_Planning.Planner;

namespace Urban_Planning
{
    class Program
    {
        static void Main(string[] args)
        {

         
            Console.WriteLine("Urban Planner");

            Building Building2 = new Building("123 Construction Lane")
            {
                Stories = 10,
                Width = 25,
                Depth = 100
            };

            Building2.Construct();
            Building2.Purchase("Bob Villa");

            Building Building3 = new Building("4643 Flannel Blvd")
            {
                Stories = 7,
                Width = 30,
                Depth = 150
            };

            Building3.Construct();
            Building3.Purchase("Al Borland");

            Building Building4 = new Building("7859 Descruction Ave")
            {
                Stories = 6,
                Width = 35,
                Depth = 120
            };

            Building4.Construct();
            Building4.Purchase("Tim Taylor");



        }
    }
}
