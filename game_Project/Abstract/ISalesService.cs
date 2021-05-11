using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Abstract
{
    public interface ISalesService
    {
        void Add(Gamer gamer,Game game,Compaign compaign);
        void Update(Gamer gamer,Game game,Compaign compaign);
        void Delete(Gamer gamer,Game game,Compaign compaign);
    }
}
