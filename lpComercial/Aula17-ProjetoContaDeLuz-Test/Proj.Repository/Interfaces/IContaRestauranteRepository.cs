using Proj.Domain.Entities;

namespace Proj.Repository.Interfaces
{
    public interface IContaRestauranteRepository : IRepository<ContaRestaurante>
    {
        ContaRestaurante GetMenorPreco();
        ContaRestaurante GetMaiorPreco();
    }
}