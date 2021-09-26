using GamerRoom.web.mvc.Dtos.ViewModel;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Service.Interfaces
{
    public interface IGameService
    {
        [Get("/api/Games")]
        Task<List<GameViewModel>> ListGames();

        [Get("/api​/Games​/{idGame}")]
        Task<List<GameViewModel>> GetGame(Guid idGame);


    }
}
