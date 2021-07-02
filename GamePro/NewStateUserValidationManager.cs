using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro
{
    class NewStateUserValidationManager : IUserValidationManager
    {
        public bool Validate(GamerDetails gamerDetails)
        {
            return true;
        }
    }
}
