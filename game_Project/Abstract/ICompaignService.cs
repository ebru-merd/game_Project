using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Abstract
{
    public interface ICompaignService
    {
        void Add(Compaign compaign);
        void Update(Compaign compaign);
        void Delete(Compaign compaign);
    }
}
