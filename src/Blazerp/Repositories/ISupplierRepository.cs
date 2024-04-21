using Blazerp.Models;

namespace Blazerp.Repositories;

public interface ISupplierRepository
{
    Task<List<Supplier>> Search();
}
