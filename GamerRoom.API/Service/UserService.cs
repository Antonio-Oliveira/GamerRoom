using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Dtos.ViewModel;
using GamerRoom.API.Entities;
using GamerRoom.API.Repositories.Interface;
using GamerRoom.API.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GameViewModel> GetGame(Guid idGame, string userId)
        {
            var gameUser = await _userRepository.GetGame(idGame, userId);

            var gameVM = new GameViewModel()
            {
                Rating = gameUser.Rating,
                Description = gameUser.Game.Description,
                Developer = gameUser.Game.Developer,
                Genre = gameUser.Game.Genre,
                Mode = gameUser.Game.Mode,
                Name = gameUser.Game.Name,
                Platform = gameUser.Game.Platform,
                Publisher = gameUser.Game.Publisher,
                ReleaseDate = gameUser.Game.ReleaseDate,
                Id = gameUser.GameId
            };

            return gameVM;
        }

        public async Task<List<GameViewModel>> MyListGames(string userId)
        {
            var userGames = await _userRepository.ListGames(userId);

            return userGames.Select(gameUser => new GameViewModel()
            {
                Rating = gameUser.Rating,
                Description = gameUser.Game.Description,
                Developer = gameUser.Game.Developer,
                Genre = gameUser.Game.Genre,
                Mode = gameUser.Game.Mode,
                Name = gameUser.Game.Name,
                Platform = gameUser.Game.Platform,
                Publisher = gameUser.Game.Publisher,
                ReleaseDate = gameUser.Game.ReleaseDate,
                Id = gameUser.GameId
            }).ToList();
        }

        public async Task AddGame(GameListInputModel gameListIM, string userId)
        {
            var exist = await _userRepository.GetGame(gameListIM.IdGame, userId);

            if (exist != null)
                throw new Exception("Game já adicionado a lista");

            var gameListUser = new UserGame()
            {
                GameId = gameListIM.IdGame,
                UserId = userId,
                Rating = gameListIM.Rating
            };

            await _userRepository.InsertGame(gameListUser);
        }

        public async Task RemoveGame(Guid idGame, string userId)
        {
            var game = await _userRepository.GetGame(idGame, userId);

            if (game == null)
                throw new Exception("Game já adicionado a lista");

            await _userRepository.RemoveGame(game);
        }

        public async Task UpdateRating(Guid idGame, double rating, string userId)
        {
            var game = await _userRepository.GetGame(idGame, userId);

            if (game != null)
                throw new Exception("Game já adicionado a lista");

            var updateGame = new UserGame()
            {
                UserId = userId,
                Rating = rating,
                GameId = idGame,
                Id = game.Id
            };

            await _userRepository.UpdateRating(updateGame);
        }

    }
}
