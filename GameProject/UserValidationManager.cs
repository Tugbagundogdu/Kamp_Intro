using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "TUĞBA" && gamer.LastName == "GÜNDOĞDU" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;     
            }
        }

    }
}
