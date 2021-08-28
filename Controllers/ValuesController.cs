using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ManagerBarber_Api.Data;
using ManagerBarber_Api.Models;
namespace ManangerBarberApi.Controllers
{
    
    [Route("/api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context) => _context = context;
        [HttpGet]
        public  async Task<IEnumerable<Cliente>> Get()
        {
          var a = await _context.Cliente.ToListAsync();
           //  var categoria = await _categoriaService.ListAsync();
            // return categoria;
          return a;
        }
    }
}
