using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AuthenticationService
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {

            IEnumerable<User> users = new List<User>() 
            {
            new User(){FirstName="Alex", Email="alex@mail.com", Id = Guid.NewGuid(), LastName = "Petrov", Login="alex", Password="6s5da4fs6d5fs6af"},
            new User(){FirstName="John", Email="john@mail.com", Id = Guid.NewGuid(), LastName = "Ruska", Login="john", Password = "5465s4d4cfvxcvds"},
            new User(){FirstName="Mike", Email="mike@mail.com", Id = Guid.NewGuid(), LastName = "Salt", Login="mike", Password = "123324tefsrasfds"} 
            };
            return users;

        }

        public User GetByLogin(string login)
        {
            IEnumerable<User> users = GetAll();

            
            foreach (User user in users)
            {
                //if (user.Login == login)
                //{
                //    return user;
                if(user==users.FirstOrDefault(user => user.Login == login))
                {
                    return user;
                };

            }
            return null;




        }
    }
}
