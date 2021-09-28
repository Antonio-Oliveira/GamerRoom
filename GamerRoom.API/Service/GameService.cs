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

        public async Task<List<GameViewModel>> Get()
        {
            var games = await _gameRepository.Get();
            var gamesVM = new List<GameViewModel>();

            foreach (var game in games)
            {
                var sumRating = await _userRepository.SumRatingGames(game.Id);
                var count = await _userRepository.CountGamesById(game.Id);
                var calcRating = 0.0;

                if (sumRating != 0 && count != 0)
                    calcRating = sumRating / count;
                

                gamesVM.Add(new GameViewModel() 
                {
                    Id = game.Id,
                    Name = game.Name,
                    Description = game.Description,
                    Developer = game.Developer,
                    Publisher = game.Publisher,
                    Genre = game.Genre,
                    Platform = game.Platform,
                    Mode = game.Mode,
                    ReleaseDate = game.ReleaseDate,
                    Rating = calcRating,
                    TrailerUri = game.TrailerUri,
                    ImageUri = game.ImageUri
                });
            }

            return gamesVM;
        }

        public async Task<GameViewModel> GetGameById(Guid idGame)
        {
            var game = await _gameRepository.GetGameById(idGame);

            if (game == null)
                return null;

            var sumRating = await _userRepository.SumRatingGames(game.Id);
            var count = await _userRepository.CountGamesById(game.Id);
            var calcRating = 0.0;

            if (sumRating != 0 && count != 0)
                calcRating = sumRating / count;

            return new GameViewModel()
            {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description,
                Developer = game.Developer,
                Publisher = game.Publisher,
                Platform = game.Platform,
                Genre = game.Genre,
                Mode = game.Mode,
                ReleaseDate = game.ReleaseDate,
                Rating = calcRating,
                ImageUri = game.ImageUri,
                TrailerUri = game.TrailerUri
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
                Mode = gameInputModel.Mode,
                ImageUri = gameInputModel.ImageUri,
                ReleaseDate = gameInputModel.ReleaseDate,
                TrailerUri = gameInputModel.TrailerUri
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
                Mode = gameInsert.Mode,
                TrailerUri = gameInsert.TrailerUri,
                ReleaseDate = gameInsert.ReleaseDate,
                ImageUri = gameInsert.ImageUri,
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
                Mode = gameInputModel.Mode,
                ImageUri = gameInputModel.ImageUri,
                ReleaseDate = gameInputModel.ReleaseDate,
                TrailerUri = gameInputModel.TrailerUri
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
                Mode = gameUpdate.Mode,
                ImageUri = gameUpdate.ImageUri,
                TrailerUri = gameInputModel.TrailerUri,
                ReleaseDate = gameInputModel.ReleaseDate
            };
        }

        public async Task Delete(Guid idGame)
        {
            var game = await _gameRepository.GetGameById(idGame);

            if (game == null)
                throw new Exception("Game não encontrado");

            await _gameRepository.Delete(game);
        }
    }
}
