using GamerRoom.web.mvc.Models.Game;
using GamerRoom.web.mvc.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<GameViewModel>> Index()

        {
            try
            {
                var games = await _gameService.ListGames();
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

        [HttpGet]
        public async Task<ActionResult<GameViewModel>> GetGame(Guid idGame)
        {
            try
            {
                var game = await _gameService.GetGame(idGame);
                return View(game);
            }
            catch (ApiException err)
            {
                ModelState.AddModelError(" ", err.StatusCode + " " + err.Message);
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
