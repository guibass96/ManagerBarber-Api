using Microsoft.EntityFrameworkCore;
using ManagerBarber_Api.Domain.Models;
namespace ManagerBarber_Api.Data
{
    public class DataContext:DbContext
    {
        
        public DataContext(DbContextOptions<DataContext>options)
       :base(options)
       {
            
       }
         public DbSet<Cliente> Cliente{get;set;}
    }
}