using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GamerRoom.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("MyList")]
        public async Task<ActionResult> MyList()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var myList = await _userService.MyListGames(userId);

            if (myList == null)
                return NoContent();

            return Ok(myList);
        }

        [HttpGet("MyGame/{idGame:guid}")]
        public async Task<ActionResult> GetGame([FromRoute] Guid idGame)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var game = await _userService.GetGame(idGame, userId);

            if (game == null)
                return NotFound();

            return Ok(game);
        }

        [HttpPost("MyGame")]
        public async Task<ActionResult> AddGame([FromBody] GameListInputModel gameListIM)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _userService.AddGame(gameListIM, userId);
                return Created("", gameListIM);
            }
            catch (Exception err)
            {
                return NotFound(err.Message);
            }
        }

        [HttpPatch("MyGame/{idGame:guid}/rating/{rating:double}")]
        public async Task<ActionResult> UpdateRating([FromRoute] Guid idGame, [FromRoute] double rating)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _userService.UpdateRating(idGame, rating, userId);
                return Ok();
            }
            catch (Exception err)
            {
                return NotFound(err.Message);
            }
        }

        [HttpDelete("MyGame/{idGame:guid}")]
        public async Task<ActionResult> RemoveGame([FromRoute] Guid idGame)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _userService.RemoveGame(idGame, userId);
                return Ok();
            }
            catch (Exception err)
            {
                return NotFound(err.Message);
            }
        }

    }
}
