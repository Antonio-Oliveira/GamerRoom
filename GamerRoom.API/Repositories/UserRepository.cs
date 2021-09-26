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
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserGame> GetGame(Guid idGame, string userId)
        {
            var game = await _context.ListUserGames.AsNoTracking().Include(x => x.Game).FirstOrDefaultAsync(x => x.GameId == idGame && x.UserId == userId);
            return game;
        }

        public async Task<List<UserGame>> GetGames()
        {
            var games = await _context.ListUserGames.Include(x => x.Game).ToListAsync();
            return games;
        }

        public async Task<List<UserGame>> ListGames(string userId)
        {
            var games = await _context.ListUserGames.Include(x => x.Game).Where(x => x.UserId == userId).ToListAsync();
            return games;
        }

        public async Task InsertGame(UserGame game)
        {
            _context.ListUserGames.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveGame(UserGame game)
        {
            _context.ListUserGames.Remove(game);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRating(UserGame game)
        {
            _context.ListUserGames.Update(game);
            await _context.SaveChangesAsync();
        }

        public async Task<double> SumRatingGames(Guid idGame)
        {
            var sum = await _context.ListUserGames.Where(x => x.GameId == idGame).Select(p => p.Rating).SumAsync();
            return sum;
        }

        public async Task<int> CountGamesById(Guid idGame)
        {
            var count = await _context.ListUserGames.Where(x => x.GameId == idGame).Select(p => p.Rating).CountAsync();
            return count;
        }
    }
}
