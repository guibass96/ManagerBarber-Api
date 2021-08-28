using System.Collections.Generic;
using ManagerBarber_Api.Domain.Models;
using ManagerBarber_Api.Domain.Repositories;
using ManagerBarber_Api.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace ManagerBarber_Api.Repositories
{
    public class ClienteRepository:BaseRepository,IClientesRepository
    {
        public ClienteRepository(DataContext context):base(context)
        {}
       public async Task<IEnumerable<Cliente>> ListAsync()
        {
            return await _context.Cliente.ToListAsync();
    }
    }
}