using game_Project.Abstract;
using game_Project.Entities;

namespace game_Project
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}