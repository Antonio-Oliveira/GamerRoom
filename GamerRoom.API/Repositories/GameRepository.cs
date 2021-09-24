using GamerRoom.API.Data.Context;
using GamerRoom.API.Entities;
using GamerRoom.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
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
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Game>> Get()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }

        public async Task<Game> GetGameById(Guid idGame)
        {
            var game = await _context.Games.FirstOrDefaultAsync(games => games.Id == idGame);
            return game;
        }

        public async Task<Game> GetGameByName(string name)
        {
            var game = await _context.Games.FirstOrDefaultAsync(games => games.Name == name);
            return game;
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

