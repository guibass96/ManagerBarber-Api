using System.Collections.Generic;
using System.Threading.Tasks;
using ManagerBarber_Api.Domain.Repositories;
using ManagerBarber_Api.Domain.Models;
using System.Linq;
using System.Text;
using System;
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

       public bool UpdatePerson(Cliente person)
        {
            try
            {       
               _clienteRepository.Update(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeletePerson(int id)
        {

            try
            {
              var clienteDelete = _clienteRepository.GetAll().Where(c=> c.Id == id).FirstOrDefault();
               _clienteRepository.Delete(clienteDelete);
                
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }

    }
}