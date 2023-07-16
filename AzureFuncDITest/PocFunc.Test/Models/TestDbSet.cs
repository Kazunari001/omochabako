using Moq;
using Company.Function.Models;

namespace PocFunc.Test.Models
{
    public class TestDbSet
    {
        public Mock<IUserRepository> _repo = new Mock<IUserRepository>();
        private readonly List<UserMaster> _data = new List<UserMaster>()
        {
            new UserMaster { Id = "1", Name = "Test User 1", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "2", Name = "Test User 2", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "3", Name = "Test User 3", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "4", Name = "Test User 4", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "5", Name = "Test User 5", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "6", Name = "Test User 6", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "7", Name = "Test User 7", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "8", Name = "Test User 8", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "9", Name = "Test User 9", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "10", Name = "Test User 10", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "11", Name = "Test User 11", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "12", Name = "Test User 12", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
            new UserMaster { Id = "13", Name = "Test User 13", Email = "1234567890", Tel = "1234567890", Address = "1234567890", Password = "1234567890", IsAdmin = false, EntryDateTime = DateTime.Now, UpdateDateTime = DateTime.Now, IsDeleteFlag = false },
        };
        public TestDbSet()
        {
            _repo.Setup(x => x.GetAll()).Returns(_data);
        }
    }
}