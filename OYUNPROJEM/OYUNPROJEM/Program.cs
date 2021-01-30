using System;

namespace OyunProjem

{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.SignUp(new Player
            {
                Id = 1,
                IdentityNumber = 12345678900,
                FirstName = "Engin",
                LastName = "Demiroğ",
                BirthYear = 1985,
                PhoneNumber = "05443331111"
            });
            Console.WriteLine("--------------EKLEME------------------------------");
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game
            {
                Id = 1,
                Name = "Fifa 2021",
                Cost = 500,
            });
            Console.WriteLine("--------------SİLME------------------------------");
            gameManager.Delete(new Game
            {
                Name = "Fifa 2020",
            });
            Console.WriteLine("--------------OYUN SATIN ALMA------------------------------");

            BuyGameManager buyGameManager = new BuyGameManager();
            buyGameManager.Buy(new Game { Name = "Fifa 2021" },
                new Player { FirstName = "Engin", LastName = "Demiroğ" });

            Console.WriteLine("--------------KAMPANYALI SATIN ALMA------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.MakeCampaing(new Campaing { CampaingName = "Şubat Kampanyası", DiscountRate = 10 },
                new Player { FirstName = "Engin" }, new Game { Name = "Fifa 2021", Cost = 500 });
            campaignManager.Message(new Player {FirstName = "Engin", LastName = "Demiroğ" }, 
                new Campaing {CampaingName = "Şubat Kampanyası" });
            Console.WriteLine("--------------DOSYAYA LOGLAMA------------------------------");

            FileLoggerManager fileLoggerManager = new FileLoggerManager();
            fileLoggerManager.Log(new Player { });

            Console.WriteLine("--------------SMS LOGLAMA------------------------------");

            SmsLoggerManager smsLoggerManager = new SmsLoggerManager();
            smsLoggerManager.Log(new Player {PhoneNumber = "05443331111" });






        }
    }
}
