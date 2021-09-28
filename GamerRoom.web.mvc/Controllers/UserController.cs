using GamerRoom.web.mvc.Models.User;
using GamerRoom.web.mvc.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("AddGame/{idGame:guid}")]
        public IActionResult AddGame(Guid idGame)
        {
            var userGame = new UserGameInputModel()
            {
                IdGame = idGame
            };

            return View(userGame);
        }

        [HttpPost("AddGame")]
        public async Task<IActionResult> AddGame(UserGameInputModel userGameInputModel)
        {
            try
            {
                var games = await _userService.AddGame(userGameInputModel);
                return View(games);
            }
            catch (ApiException err)
            {
                ModelState.AddModelError(" ", err.Message);
                return View();
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                return View();
            }
        }

    }
}
