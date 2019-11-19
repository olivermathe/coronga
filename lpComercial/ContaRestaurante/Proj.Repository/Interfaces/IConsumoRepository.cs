using restaurante.domain;

namespace Proj.Repository.Interfaces
{
    public interface IConsumoRepository : IBaseRepository<Consumo>
    {
        Consumo GetMenorPreco();
        Consumo GetMaiorPreco();
    }
}