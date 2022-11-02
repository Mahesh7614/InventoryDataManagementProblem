using InventoryDataManagementProblem.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagementProblem.Repository
{
    public class InventoryRepository
    {
        public String JsonFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\InventoryDataManagementProblem\InventoryDataManagementProblem\JSON File\InventoryData.json";
    
        public void CalculateInventoryValue()
        {
            var JsonFileData = File.ReadAllText(JsonFilePath);

            InventoryModel InvenData = JsonConvert.DeserializeObject<InventoryModel>(JsonFileData);

            foreach (var Rice in InvenData.Rice)
            {
                Console.Write("Name : " + Rice.Name + "\n" +
                "Weight : " + Rice.Weight + "\n" +
                "PricePerKG : " + Rice.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Rice.Name} is : {Rice.Weight * Rice.PricePerKG} \n");
            }
            foreach (var Wheats in InvenData.Wheats)
            {
                Console.Write("Name : " + Wheats.Name + "\n" +
                "Weight : " + Wheats.Weight + "\n" +
                "PricePerKG : " + Wheats.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Wheats.Name} is : {Wheats.Weight * Wheats.PricePerKG} \n");
            }
            foreach (var Pulses in InvenData.Pulses)
            {
                Console.Write("Name : " + Pulses.Name + "\n" +
                "Weight : " + Pulses.Weight + "\n" +
                "PricePerKG : " + Pulses.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Pulses.Name} is : {Pulses.Weight * Pulses.PricePerKG} \n");
            }
            foreach (var Sorghum in InvenData.Sorghum)
            {
                Console.Write("Name : " + Sorghum.Name + "\n" +
                "Weight : " + Sorghum.Weight + "\n" +
                "PricePerKG : " + Sorghum.PricePerKG + "\n");

                Console.WriteLine($"Total Price Of {Sorghum.Name} is : {Sorghum.Weight * Sorghum.PricePerKG} \n");
            }
            Console.WriteLine("Json Data : \n" + JsonFileData);
        }
    }
}
