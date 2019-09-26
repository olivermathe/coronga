using Microsoft.EntityFrameworkCore;

namespace TarefasArnaldo.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
            {
            }
        public DbSet <Tarefas> TarefasArnaldo { get; set; }    
    }
} 