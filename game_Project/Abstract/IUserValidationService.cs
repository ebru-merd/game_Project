using game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace game_Project.Abstract
{
   public  interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
