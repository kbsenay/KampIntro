using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjem
{
    class PlayerManager : IUserProfileService
    {
        IUserValidationService userValidationService;
        private IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService) 
        {
            _userValidationService = userValidationService;
        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + player.LastName + " isimli kullanıcı silindi!");
        }

        public void SignUp(Player player)
        {
            if (_userValidationService.Validate(player)==true)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " isimli kullanıcı kaydedildi!");
                Console.WriteLine("Hoşgeldiniz " + player.FirstName +" "+ player.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Lütfen bilgilerinizi kontrol edin.");
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " isimli kullanıcının profili güncellendi!");
        }

        public void View(Player player)
        {
            Console.WriteLine(player.FirstName + player.LastName + " isimli kullanıcı profili görüntülendi!");
        }
    }
}
