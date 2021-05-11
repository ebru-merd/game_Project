using game_Project.Abstract;
using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Gamer gamer, Game game, Compaign compaign)
        {
            Console.WriteLine("'{0}' oyuncu eklendi. '{1}' oyun eklendi. '{2}' kampanya eklendi. ",gamer.FirstName,game.GameName,compaign.CampaignName);
        }

        public void Delete(Gamer gamer, Game game, Compaign compaign)
        {
            Console.WriteLine("'{0}' oyuncu silindi. '{1}' oyun silindi. '{2}' kampanya silindi. ", gamer.FirstName, game.GameName, compaign.CampaignName);
        }

        public void Update(Gamer gamer, Game game, Compaign compaign)
        {
            Console.WriteLine("'{0}' oyuncu güncellendi. '{1}' oyun güncellendi. '{2}' kampanya güncellendi. ", gamer.FirstName, game.GameName, compaign.CampaignName);
        }
    }
}
