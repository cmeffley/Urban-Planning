using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Planning.Planner
{
    class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int YearFounded { get; set; }

        private List<Building> Buildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public void ShowBuildings()
        {
            Console.WriteLine($"Buildings currently in {Name}");

            foreach (Building structure in Buildings)
            {
                Console.WriteLine(structure.Name);
            }
        }

        public City(string name, string mayor, int yearFounded)
        {
            Name = name;
            Mayor = mayor;
            YearFounded = yearFounded;
        }

        

      

    }
}
