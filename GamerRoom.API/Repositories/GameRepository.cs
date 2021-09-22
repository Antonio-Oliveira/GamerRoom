using GamerRoom.API.Data.Context;
using GamerRoom.API.Entities;
using GamerRoom.API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _context;

        public GameRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Delete(Game game)
        {
            var exist = _context.Games.FirstOrDefault(item => item.Id == game.Id);

            if (exist != null)
            {
                _context.Games.Remove(exist);
                await _context.SaveChangesAsync();
            }
            
        }

        public Task<IEnumerable<Game>> Get()
        {
            var games = _context.Games.ToList();
            return Task.FromResult(games);
        }

        public Task<Game> GetGameById(Guid idGame)
        {
            var game = _context.Games.FirstOrDefault(games => games.Id == idGame);
            return Task.FromResult(game);
        }

        public Task<Game> GetGameByName(string name)
        {
            var game = _context.Games.FirstOrDefault(games => games.Name == name);
            return Task.FromResult(game);
        }

        public async Task Insert(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Game game)
        {
            _context.Games.Update(game);
            await _context.SaveChangesAsync();
        }
    }
}

