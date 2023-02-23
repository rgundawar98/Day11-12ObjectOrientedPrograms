using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12ObjectOrientedPrograms.StockManagement
{
    public class StockInfoManagement
    {
        public StockInfo Read(string path1)
        {
            using (StreamReader sr = new StreamReader(path1))
            {
                try
                {
                    string json = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockInfo>(json);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
