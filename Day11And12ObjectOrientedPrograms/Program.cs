using System;
using Day11And12ObjectOrientedPrograms.StockManagement;

namespace Day11And12ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the object oriented programs");
            //string path = "E:\\Rahul's WorkSpace\\New VisualStudio\\Day11And12ObjectOrientedPrograms\\Day11And12ObjectOrientedPrograms\\Inventory.json";
            //InventoryMangement inventoryMangement = new InventoryMangement();
            //InventoryDetails data =inventoryMangement.Read(path);
            //Console.WriteLine("Types of Rice");
            //Console.WriteLine("*************");
            //for(var rice=0;rice<data.typesOfRice.Count;rice++)
            //{
            //    Console.WriteLine(data.typesOfRice[rice].Name);
            //    Console.WriteLine(data.typesOfRice[rice].Weight);
            //    Console.WriteLine(data.typesOfRice[rice].Price);
            //    int PriceForRice = data.typesOfRice[rice].Weight * data.typesOfRice[rice].Price;
            //    Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfRice[rice].Name, data.typesOfRice[rice].Weight,
            //        PriceForRice);
            //}
            //Console.WriteLine("Types of pulses");
            //Console.WriteLine("************");
            //for(var pulses=0;pulses<data.typesOfPulses.Count;pulses++)
            //{
            //    Console.WriteLine(data.typesOfPulses[pulses].Name);
            //    Console.WriteLine(data.typesOfPulses[pulses].Weight);
            //    Console.WriteLine(data.typesOfPulses[pulses].Price);
            //    int PrintForPulses = data.typesOfPulses[pulses].Weight * data.typesOfPulses[pulses].Price;
            //    Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfPulses[pulses].Name, data.typesOfPulses[pulses].Weight,
            //        PrintForPulses);
            //}
            //Console.WriteLine("Types of Wheat");
            //Console.WriteLine("************");
            //for (var wheat=0;wheat<data.typesOfWheats.Count;wheat++)
            //{
            //    Console.WriteLine(data.typesOfWheats[wheat].Name);
            //    Console.WriteLine(data.typesOfWheats[wheat].Weight);
            //    Console.WriteLine(data.typesOfWheats[wheat].Price);
            //    int PriceForWheat = data.typesOfWheats[wheat].Weight*data.typesOfWheats[wheat].Price;
            //    Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfWheats[wheat].Name, data.typesOfWheats[wheat].Weight,
            //        PriceForWheat);
            //}

            string path1 = "E:\\Rahul's WorkSpace\\New VisualStudio\\Day11And12ObjectOrientedPrograms\\Day11And12ObjectOrientedPrograms\\StockManagement\\Shares.json";
            StockInfoManagement stockInfoManagement = new StockInfoManagement();
            StockInfo details = stockInfoManagement.Read(path1);
            Console.WriteLine("Types of stocks");
            Console.WriteLine("********");
            for(var Data=0; Data<details.typesOfShares.Count;Data++)
            {
                Console.WriteLine(details.typesOfShares[Data].StockName);
                Console.WriteLine(details.typesOfShares[Data].NumberOfShare);
                Console.WriteLine(details.typesOfShares[Data].Price);
                Console.WriteLine("The value of {0} stock is {1}INR",details.typesOfShares[Data].StockName,details.typesOfShares[Data].Price);
                int TotalValueOfShare = details.typesOfShares[Data].NumberOfShare * details.typesOfShares[Data].Price;
                Console.WriteLine("For Stock {0} having {1} number of share has totalvalue is of {2}INR",details.typesOfShares[Data].StockName,
                    details.typesOfShares[Data].NumberOfShare,TotalValueOfShare);
            }
        }
    }
}
