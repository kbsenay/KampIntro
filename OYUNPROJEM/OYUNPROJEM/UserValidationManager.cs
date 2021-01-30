using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.IdentityNumber == 12345678900 && 
                player.FirstName == "Engin" && 
                player.LastName == "Demiroğ" &&
                player.BirthYear == 1985)

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
