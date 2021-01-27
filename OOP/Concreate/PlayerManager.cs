using System;
using OOP.Abstract.Interface;
using OOP.Abstract;
using OOP.Entities;

namespace OOP.Concreate
{
    public class PlayerManager:UserManager
    {
        private IVerificationService _verificationService;

        public PlayerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }

        public override void Register(User user)
        {
            if (_verificationService.Verification(user))
            {
                user.IsAdmin = false;
                base.Register(user);
            }
            else
            {
                throw new Exception("Not a valid user information");
            }
        }
    }
}