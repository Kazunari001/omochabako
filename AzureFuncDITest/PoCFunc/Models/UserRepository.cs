using System.Collections.Generic;

namespace Company.Function.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserMaster> GetAll()
        {
            return _context.UserItems;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}