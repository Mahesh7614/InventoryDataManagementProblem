using InventoryDataManagementProblem.Repository;

namespace InventoryDataManagementProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryRepository repository = new InventoryRepository();
            repository.CalculateInventoryValue();
        }
    }
}