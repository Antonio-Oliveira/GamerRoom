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
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IUserRepository _userRepository;

        public GameService(IGameRepository gameRepository, IUserRepository userRepository)
        {
            _gameRepository = gameRepository;
            _userRepository = userRepository;
        }

        public async Task Delete(Guid idGame)
        {
            var game = await _gameRepository.GetGameById(idGame);

            if (game == null)
                throw new Exception("Game não encontrado");

            await _gameRepository.Delete(game);
        }

        public async Task<List<GameViewModel>> Get()
        {
            var games = await _gameRepository.Get();

            return games.Select(games => new GameViewModel
            {
                Id = games.Id,
                Name = games.Name,
                Description = games.Description,
                Developer = games.Developer,
                Publisher = games.Publisher,
                Genre = games.Genre,
                Platform = games.Platform,
                Mode = games.Mode
            }).ToList();
        }

        public async Task<GameViewModel> GetGameById(Guid idGame)
        {
            var game = await _gameRepository.GetGameById(idGame);

            if (game == null)
                return null;

            return new GameViewModel()
            {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description,
                Developer = game.Developer,
                Publisher = game.Publisher,
                Platform = game.Platform,
                Genre = game.Genre,
                Mode = game.Mode
            };
        }

        public async Task<GameViewModel> InsertGame(GameInputModel gameInputModel)
        {
            var game = _gameRepository.GetGameByName(gameInputModel.Name);

            if (game != null)
                throw new Exception("Game já cadastrado");

            var gameInsert = new Game()
            {
                Id = Guid.NewGuid(),
                Name = gameInputModel.Name,
                Description = gameInputModel.Description,
                Developer = gameInputModel.Developer,
                Publisher = gameInputModel.Publisher,
                Platform = gameInputModel.Platform,
                Genre = gameInputModel.Genre,
                Mode = gameInputModel.Mode
            };

            await _gameRepository.Insert(gameInsert);

            return new GameViewModel()
            {
                Id = gameInsert.Id,
                Name = gameInsert.Name,
                Description = gameInsert.Description,
                Developer = gameInsert.Developer,
                Publisher = gameInsert.Publisher,
                Platform = gameInsert.Platform,
                Genre = gameInsert.Genre,
                Mode = gameInsert.Mode
            };
        }

        public async Task<GameViewModel> UpdateGame(Guid idGame, GameInputModel gameInputModel)
        {
            var game = _gameRepository.GetGameById(idGame);

            if (game == null)
                throw new Exception("Game não cadastrado");

            var gameUpdate = new Game()
            {
                Id = idGame,
                Name = gameInputModel.Name,
                Description = gameInputModel.Description,
                Developer = gameInputModel.Developer,
                Publisher = gameInputModel.Publisher,
                Platform = gameInputModel.Platform,
                Genre = gameInputModel.Genre,
                Mode = gameInputModel.Mode
            };

            await _gameRepository.Update(gameUpdate);

            return new GameViewModel()
            {
                Id = gameUpdate.Id,
                Name = gameUpdate.Name,
                Description = gameUpdate.Description,
                Developer = gameUpdate.Developer,
                Publisher = gameUpdate.Publisher,
                Platform = gameUpdate.Platform,
                Genre = gameUpdate.Genre,
                Mode = gameUpdate.Mode
            };
        }
    }
}
