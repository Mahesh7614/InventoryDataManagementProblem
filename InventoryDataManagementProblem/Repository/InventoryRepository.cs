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
            string JsonFileData = File.ReadAllText(JsonFilePath);

            InventoryModel InvenData = JsonConvert.DeserializeObject<InventoryModel>(JsonFileData);

            Console.WriteLine(
                "Name : " + InvenData.Rice.Name + "\n" +
                "Weight : " + InvenData.Rice.Weight + "\n" +
                "PricePerKG : " + InvenData.Rice.PricePerKG + "\n\n" +
                "Name : " + InvenData.Wheats.Name + "\n" +
                "Weight : " + InvenData.Wheats.Weight + "\n" +
                "PricePerKG : " + InvenData.Wheats.PricePerKG + "\n\n" +
                "Name : " + InvenData.Pulses.Name + "\n" +
                "Weight : " + InvenData.Pulses.Weight + "\n" +
                "PricePerKG : " + InvenData.Pulses.PricePerKG + "\n"
                );

            Console.WriteLine("Json Data : \n" + JsonFileData);
        }
    }
}
