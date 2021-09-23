using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Dtos.ViewModel;
using GamerRoom.API.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        /// <summary>
        /// Buscar todos os Games
        /// </summary>
        /// <response code="200">Retorna a lista dos Games</response>
        /// <response code="204">Caso não haja Games</response>  
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao obter Games")]
        [SwaggerResponse(statusCode: 204, description: "Nenhum Game encontrado")]
        [HttpGet]
        public async Task<ActionResult<GameViewModel>> Get()
        {
            var games = await _gameService.Get();

            if (games.Count() == 0)
              return NoContent();

            return Ok(games);
        }

        /// <summary>
        /// Buscar Games por ID
        /// </summary>
        /// <param name="idGame">Id do Game a ser pesquisado</param>
        /// <response code="200">Retorna o Game pesquisado</response>
        /// <response code="204">Caso não haja o Game</response>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao obter Game")]
        [SwaggerResponse(statusCode: 204, description: "Game não cadastrado")]
        [HttpGet("{idGame:guid}")]
        public async Task<ActionResult<GameViewModel>> Get([FromRoute] Guid idGame)
        {
            var game = await _gameService.GetGameById(idGame);

            if (game == null)
                return NoContent();

            return Ok(game);
        }

        /// <summary>
        /// Adicionar Games
        /// </summary>
        /// <param name="gameInputModel">Dados do novo game</param>
        /// <response code="201">Retorna o Game cadastrado</response>
        /// <response code="422">Caso haja Game com o mesmo name que o solicitado</response>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao Cadastrar Games")]
        [SwaggerResponse(statusCode: 422, description: "Game já existe")]
        [HttpPost]
        public async Task<ActionResult<GameViewModel>> Insert([FromBody] GameInputModel gameInputModel)
        {
            try
            {
                var game = await _gameService.InsertGame(gameInputModel);
                return Created("", game);
            }
            catch (Exception err)
            {
                return UnprocessableEntity(err.Message);
            }
        }

        /// <summary>
        /// Atualizar Games
        /// </summary>
        /// <param name="idGame">Id do Game a ser atualizado</param>
        /// <param name="gameInputModel">Novos dados para o game que será atualizado</param>
        /// <response code="200">Retorna o Game atualizado</response>
        /// <response code="404">Caso não haja o Game</response>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao obter Game")]
        [SwaggerResponse(statusCode: 404, description: "Game não encontrado")]
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

        /// <summary>
        /// Remover Games
        /// </summary>
        /// <param name="idGame">Id do Game a ser excluído</param>
        /// <response code="200">Caso o game seja removido </response>
        /// <response code="404">Caso não haja o Game</response>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao remover Game")]
        [SwaggerResponse(statusCode: 404, description: "Game não encontrado")]
        [HttpDelete("{idGame:guid}")]
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
