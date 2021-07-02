using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro
{
    class UserValidationManager : IUserValidationManager
    {
        public bool Validate(GamerDetails gamerDetails)
        {
            if (gamerDetails.BirthYear == 1995 
                && gamerDetails.FirstName == "Burak" 
                && gamerDetails.LastName== "Demircioğlu"
                && gamerDetails.IdentityNumber==123456789)
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