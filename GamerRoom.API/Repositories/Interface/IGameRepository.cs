using GamerRoom.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Repositories.Interface
{
    public interface IGameRepository
    {
        Task<List<Game>> Get();

        Task<Game> GetGameById(Guid idGame);

        Task<Game> GetGameByName(string name);

        Task Insert(Game game);

        Task Update(Game game);

        Task Delete(Game game);
    }
}
