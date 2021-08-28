
using ManagerBarber_Api.Data;
namespace ManagerBarber_Api.Repositories
{
    public class BaseRepository
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context){
            _context = context;
        }
    }
}