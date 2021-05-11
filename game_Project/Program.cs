using game_Project.Concrete;
using game_Project.Entities;
using System;

namespace game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {

                Id = 1,
                FirstName = "EBRU",
                LastName = "MERD",
                BirthYear="2002",
                IdentityId="123456"

            };

            Game game = new Game
            {
                Id=2,
                GameName="Valorant",
                GamePrice=70

            };

            Compaign compaign = new Compaign
            {
                Id=3,
                CampaignName="3 al 1 öde",
                CampaignDiscount=1
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer,game,compaign);

        }
    }
}
