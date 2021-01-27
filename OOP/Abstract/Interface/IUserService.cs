using OOP.Entities;

namespace OOP.Abstract.Interface
{
    public interface IUserService
    {
         void Register(User user);
         void Update(User user);
         void Delete(User user);
    }
}