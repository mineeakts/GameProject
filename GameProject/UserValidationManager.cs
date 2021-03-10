using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.Name == "Mine"
                &&gamer.LastName=="Aktaş" &&gamer.IdentityNumber==12345) 
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
