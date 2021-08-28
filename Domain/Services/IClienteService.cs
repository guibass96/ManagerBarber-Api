
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagerBarber_Api.Domain.Models;

namespace ManagerBarber_Api.Domain.Services
{
    public interface IClienteService
    {
           Task<IEnumerable<Cliente>> ListAsync();
       
    }
}