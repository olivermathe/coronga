using Microsoft.EntityFrameworkCore;

namespace Aula07CrudPeopleEF.Models
{

    public class DataContext : DbContext //está herdando da classe DbContext que já é do EF
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
    {
    }
    //dizer quais classes serão tabelas do banco
    //elas devem ser especificadas para o mapeamento relacional
    public DbSet <Person> People { get; set; }
    }
}