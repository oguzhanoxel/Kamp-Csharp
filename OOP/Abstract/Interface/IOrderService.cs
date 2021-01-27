using OOP.Entities;

namespace OOP.Abstract.Interface
{
    public interface IOrderService
    {
         void Create(Order order);
         void Cancel(Order order);
    }
}