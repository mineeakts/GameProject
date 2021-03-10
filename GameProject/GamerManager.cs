using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
           _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Olundu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer game)
        {
            Console.WriteLine("Kayıt Silindi.");

        }

        public void Update(Gamer game)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
