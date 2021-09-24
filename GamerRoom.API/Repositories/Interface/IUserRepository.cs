using GamerRoom.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<List<UserGame>> ListGames(string userId);

        Task<List<UserGame>> GetGames();

        Task<UserGame> GetGame(Guid idGame, string userId);

        Task InsertGame(UserGame game);

        Task UpdateRating(UserGame game);

        Task RemoveGame(UserGame game);
    }
}
