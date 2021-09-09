using System.Collections.Generic;
using ManagerBarber_Api.Domain.Models;
using ManagerBarber_Api.Domain.Repositories;
using ManagerBarber_Api.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Text;
namespace ManagerBarber_Api.Repositories
{
    public class ClienteRepository:BaseRepository,IClientesRepository<Cliente>
    {
        public ClienteRepository(DataContext context):base(context)
        {}

  
       public async Task<IEnumerable<Cliente>> ListAsync()
        {
            return await _context.Cliente.ToListAsync();
        }
        public async Task<Cliente> Create(Cliente _object)
        {
            var obj =  await _context.Cliente.AddAsync(_object);
            _context.SaveChanges();
            return obj.Entity;
           
        }       
        public void Update(Cliente _object)
        {
            var ex = _context.Cliente.Where(c=> c.Id == _object.Id).FirstOrDefault();
            if(ex != null){
           ex.Nome = _object.Nome;
            _context.SaveChanges();
            }
          
        }

          public void Delete(Cliente _object)
        {
            _context.Remove(_object);
            _context.SaveChanges();
        }
        public IEnumerable<Cliente> GetAll()
        {
            try
            {
                return _context.Cliente.ToList();
            }
            catch (Exception ee)
            {
                System.Console.WriteLine(ee);
                throw;
            }
        }
    }
}