using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Dtos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Service.Interfaces
{
    public interface IGameService
    {
        Task<List<GameViewModel>> Get();

        Task<GameViewModel> GetGameById(Guid idGame);

        Task<GameViewModel> InsertGame(GameInputModel gameInputModel);

        Task<GameViewModel> UpdateGame(Guid idGame, GameInputModel gameInputModel);

        Task Delete(Guid idGame);

    }
}
