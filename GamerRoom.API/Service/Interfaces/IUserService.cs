using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Dtos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Service.Interfaces
{
    public interface IUserService
    {
        Task<List<GameViewModel>> MyListGames(string userId);

        Task<GameViewModel> GetGame(Guid idGame, string userId);

        Task AddGame(GameListInputModel gameListIM, string userId);

        Task UpdateRating(Guid idGame, double rating, string userId);

        Task RemoveGame(Guid idGame, string userId);
    }
}
