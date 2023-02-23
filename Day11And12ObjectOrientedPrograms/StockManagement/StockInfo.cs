using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12ObjectOrientedPrograms.StockManagement
{
    public class StockInfo
    {
        public List<TypesOfShares> typesOfShares;
    }

    public class TypesOfShares
    {
        public string StockName;
        public int NumberOfShare;
        public int Price;
    }
}
