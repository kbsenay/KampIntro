using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
