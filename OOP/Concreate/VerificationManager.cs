using OOP.Abstract.Interface;
using OOP.Entities;

namespace OOP.Concreate
{
    public class VerificationManager : IVerificationService
    {
        public bool Verification(User user)
        {
            return true;
        }
    }
}