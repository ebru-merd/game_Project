using game_Project.Abstract;
using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Concrete
{
    public class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;

        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kişi doğrulandı. '{0}' eklendi",gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Kişi doğrulanamadı. '{0}' eklenemedi", gamer.FirstName);
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi..");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi..");
        }
    }
}
