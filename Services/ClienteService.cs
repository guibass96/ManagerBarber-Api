using System.Collections.Generic;
using System.Threading.Tasks;
using ManagerBarber_Api.Domain.Repositories;
using ManagerBarber_Api.Domain.Models;
namespace ManagerBarber_Api.Services
{
    public class ClienteService
    {
      private readonly IClientesRepository<Cliente> _clienteRepository;
        public ClienteService(IClientesRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> ListAsync()
        {
            return await _clienteRepository.ListAsync();
        }
       
          public async Task<Cliente> AddPerson(Cliente cliente)
        {
           return await _clienteRepository.Create(cliente);
 
        }
    }
}