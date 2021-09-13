using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Dtos.ViewModel;
using GamerRoom.API.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<GameViewModel>> Get()
        {
            var games = await _gameService.Get();

            if (games.Count() == 0)
                return NoContent();

            return Ok(games);
        }

        [HttpGet("{idGame:guid}")]
        public async Task<ActionResult<GameViewModel>> Get([FromRoute] Guid idGame)
        {
            var game = await _gameService.GetGameById(idGame);

            if (game == null)
                return NoContent();

            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<GameViewModel>> Insert([FromBody] GameInputModel gameInputModel)
        {
            try
            {
                var game = await _gameService.InsertGame(gameInputModel);
                return Ok(game);
            }
            catch (Exception err)
            {
                return UnprocessableEntity("Já existe um game com este nome para esta produtora");
            }
        }

        [HttpPut("{idGame:guid}")]
        public async Task<ActionResult<GameViewModel>> Update([FromRoute] Guid idGame, [FromBody] GameInputModel gameInputModel)
        {
            try
            {
                var game = await _gameService.UpdateGame(idGame, gameInputModel);
                return Ok(game);
            }
            catch (Exception err)
            {
                return NotFound("Game não existe");
            }
        }

        [HttpDelete("{igGame:guid}")]
        public async Task<ActionResult> Delete([FromRoute] Guid idGame)
        {
            try
            {
                await _gameService.Delete(idGame);
                return Ok();
            }
            catch (Exception err)
            {
                return NotFound("Game não existe");
            }
        }


    }
}
