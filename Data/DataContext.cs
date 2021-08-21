using Microsoft.EntityFrameworkCore;
using ManagerBarber_Api.Models;
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