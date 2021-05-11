using game_Project.Abstract;
using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Concrete
{
    public class CompaignManager : ICompaignService
    {
        public void Add(Compaign compaign)
        {
            Console.WriteLine("kampanya eklendi..");
        }

        public void Delete(Compaign compaign)
        {
            Console.WriteLine("kampanya silindi..");
        }

        public void Update(Compaign compaign)
        {
            Console.WriteLine("kampanya güncellendi..");
        }
    }
}
