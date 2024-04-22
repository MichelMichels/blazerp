using Blazerp.Models;

namespace Blazerp.Repositories;

public class SupplierRepository : ISupplierRepository
{
    private readonly Random random = new Random();
    private readonly string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZ0123456789       ";

    public async Task<List<Supplier>> Search()
    {
        List<Supplier> suppliers = [];

        for (int i = 0; i < 100; i++)
        {
            suppliers.Add(new Supplier
            {
                Balance = (decimal)random.NextDouble() * random.Next(1000) + (decimal)random.NextDouble(),
                Name = string.Join("", Enumerable.Range(0, random.Next(100)).Select(x => characters[random.Next(characters.Length)])),
                VatNumber = string.Join("", Enumerable.Range(0, 10).Select(x => "0123456789"[random.Next(10)]))
            });
        }

        return suppliers;
    }
}
