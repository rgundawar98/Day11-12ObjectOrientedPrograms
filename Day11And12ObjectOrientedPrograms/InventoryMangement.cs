using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11And12ObjectOrientedPrograms
{
    public class InventoryMangement
    {
       public InventoryDetails Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
