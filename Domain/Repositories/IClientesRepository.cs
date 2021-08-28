using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagerBarber_Api.Domain.Models;

namespace ManagerBarber_Api.Domain.Repositories
{
    public interface IClientesRepository
    {
          Task<IEnumerable<Cliente>> ListAsync();
    }
}