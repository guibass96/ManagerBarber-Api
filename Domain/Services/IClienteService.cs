
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagerBarber_Api.Domain.Models;

namespace ManagerBarber_Api.Domain.Services
{
    public interface IClienteService<T>
    {
           Task<IEnumerable<Cliente>> ListAsync();
           public Task<T> Create(T _object);
       
    }
}