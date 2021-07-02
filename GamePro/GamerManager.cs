using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro
{
    class GamerManager : IGamerManager
    {
        IUserValidationManager _userValidationManager;

        public GamerManager(IUserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(GamerDetails gamerDetails)
        {
            if (_userValidationManager.Validate(gamerDetails)==true)
            {
                Console.WriteLine("Kayıt Olundu.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız. Bilgileri kontrol ediniz.");
            }

        }

        public void Delete(GamerDetails gamerDetails)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(GamerDetails gamerDetails)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
