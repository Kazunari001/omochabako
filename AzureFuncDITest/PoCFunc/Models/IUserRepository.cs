using System.Collections.Generic;

namespace Company.Function.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserMaster> GetAll();
        void SaveChanges();
    }
}