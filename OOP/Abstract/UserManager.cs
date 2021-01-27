using System;
using OOP.Abstract.Interface;
using OOP.Entities;

namespace OOP.Abstract
{
    public abstract class UserManager : IUserService
    {
        public virtual void Register(User user)
        {
            Console.WriteLine(user.UserName + " user created");
        }

        public virtual void Update(User user)
        {
            Console.WriteLine(user.UserName + " user updated");
        }
        
        public virtual void Delete(User user)
        {
            Console.WriteLine(user.UserName + " user deleted");
        }
    }
}