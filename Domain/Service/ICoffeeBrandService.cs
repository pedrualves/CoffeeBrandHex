using Domain.Entities;

namespace Domain.Service
{
    public interface ICoffeeBrandService
    {
        IEnumerable<CoffeeBrandModel> GetCoffeeBrands();
    }
}
