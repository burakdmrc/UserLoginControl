using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro
{
    interface IUserValidationManager
    {
        bool Validate(GamerDetails gamerDetails);
    }
}
