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


      public City(string name, string mayor, int yearFounded)
        {
            Name = name;
            Mayor = mayor;
            YearFounded = yearFounded;
        }

      

    }
}
