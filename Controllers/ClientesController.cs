using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ManagerBarber_Api.Domain.Models;
using ManagerBarber_Api.Services;
using ManagerBarber_Api.Data;
namespace ManangerBarberApi.Controllers
{
    
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        /*private readonly DataContext _context;
        public ClientesController(DataContext context) => _context = context;
*/
        private readonly ClienteService _clienteService;
        public ClientesController(ClienteService clienteService){
            _clienteService = clienteService;
        }

        [HttpGet]
        public  async Task<IEnumerable<Cliente>> GetAllAsync()
        {
          var clientes = await _clienteService.ListAsync();
     
          return clientes;
        }

        [HttpPost("/api/AddPerson")]
        public async Task<Object> AddPerson([FromBody] Cliente cliente){
           try{
                 await _clienteService.AddPerson(cliente);
                 return true;
            }catch(Exception){
                return false;
            }
         
        }
    }
}
