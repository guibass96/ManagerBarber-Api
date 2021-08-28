using System.Collections.Generic;
using System.Threading.Tasks;
using ManagerBarber_Api.Domain.Services;
using ManagerBarber_Api.Domain.Repositories;
using ManagerBarber_Api.Domain.Models;
namespace ManagerBarber_Api.Services
{
    public class ClienteService: IClienteService
    {
      private readonly IClientesRepository _clienteRepository;
        public ClienteService(IClientesRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> ListAsync()
        {
            return await _clienteRepository.ListAsync();
        }
       
    }
}