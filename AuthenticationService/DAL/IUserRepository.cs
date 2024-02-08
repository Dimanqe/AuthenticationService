using System.Collections;
using System.Collections.Generic;

namespace AuthenticationService.DAL
{
    public interface IUserRepository
    {

        IEnumerable<User> GetAll();

        User GetByLogin(string login);
    }
}
