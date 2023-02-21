using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12ObjectOrientedPrograms
{
    public class InventoryDetails
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPulses> typesOfPulses;
        public List<TypesOfWheat> typesOfWheats;
    }
    public class TypesOfRice
    {
        public string Name;
        public int Weight;
        public int Price;
    }
    public class TypesOfPulses
    {
        public string Name;
        public int Weight;
        public int Price;
    } 
    public class TypesOfWheat
    {
        public string Name;
        public int Weight;
        public int Price;
    }
}
