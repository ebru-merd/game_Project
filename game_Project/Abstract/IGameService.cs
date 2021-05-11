using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
