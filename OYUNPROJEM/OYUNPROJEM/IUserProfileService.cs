using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    interface IUserProfileService
    {
        void SignUp(Player player);
        void Update(Player player);
        void View(Player player);
        void Delete(Player player);


    }
}
