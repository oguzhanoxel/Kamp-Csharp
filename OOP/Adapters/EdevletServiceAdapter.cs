using OOP.Abstract.Interface;
using OOP.Entities;

namespace OOP.Adapters
{
    public class EdevletServiceAdapter:IVerificationService
    {
        public bool Verification(User user)
        {
            // edevleten dogrulama için gerekli kodlar ...
            return true;
        }
    }
}