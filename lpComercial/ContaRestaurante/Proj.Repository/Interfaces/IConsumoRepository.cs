using Proj.Domain.Entities;

namespace Proj.Repository.Interfaces
{
    public interface IConsumoRepository : IBaseRepository<Consumo>
    {
        Consumo GetMenorPreco();
        Consumo GetMaiorPreco();
    }
}