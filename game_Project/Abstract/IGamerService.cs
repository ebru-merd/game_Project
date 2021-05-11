using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
