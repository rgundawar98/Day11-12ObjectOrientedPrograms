using System;

namespace Day11And12ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the object oriented programs");
            string path = "E:\\Rahul's WorkSpace\\New VisualStudio\\Day11And12ObjectOrientedPrograms\\Day11And12ObjectOrientedPrograms\\Inventory.json";
            InventoryMangement inventoryMangement = new InventoryMangement();
            InventoryDetails data =inventoryMangement.Read(path);
            Console.WriteLine("Types of Rice");
            Console.WriteLine("*************");
            for(var rice=0;rice<data.typesOfRice.Count;rice++)
            {
                Console.WriteLine(data.typesOfRice[rice].Name);
                Console.WriteLine(data.typesOfRice[rice].Weight);
                Console.WriteLine(data.typesOfRice[rice].Price);
            }
            Console.WriteLine("Types of pulses");
            Console.WriteLine("************");
            for(var pulses=0;pulses<data.typesOfPulses.Count;pulses++)
            {
                Console.WriteLine(data.typesOfPulses[pulses].Name);
                Console.WriteLine(data.typesOfPulses[pulses].Weight);
                Console.WriteLine(data.typesOfPulses[pulses].Price);
            }
            Console.WriteLine("Types of Wheat");
            Console.WriteLine("************");
            for (var wheat=0;wheat<data.typesOfWheats.Count;wheat++)
            {
                Console.WriteLine(data.typesOfWheats[wheat].Name);
                Console.WriteLine(data.typesOfWheats[wheat].Weight);
                Console.WriteLine(data.typesOfWheats[wheat].Price);
            }
        }
    }
}
