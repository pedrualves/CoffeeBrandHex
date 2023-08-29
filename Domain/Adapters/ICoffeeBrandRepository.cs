using Domain.Entities;

namespace Domain.Service
{
    public interface ICoffeeBrandRepository
    {
        IEnumerable<CoffeeBrandModel> GetAll();
    }
}
