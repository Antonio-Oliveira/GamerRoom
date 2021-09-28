using GamerRoom.web.mvc.Models;
using GamerRoom.web.mvc.Models.Home;
using GamerRoom.web.mvc.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService _gameService;

        public HomeController(ILogger<HomeController> logger, IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<HomeViewModel>> Index()
        {
            try
            {
                var games = await _gameService.ListGames();
                var topTen = games.OrderByDescending(x => x.Rating).Take(10).ToList();
                var alphabeticalOrder = games.OrderBy(x => x.Name).ToList();

                var homeVM = new HomeViewModel()
                {
                    General = alphabeticalOrder,
                    TopTen = topTen
                };

                return View(homeVM);
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

        [Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<ActionResult> Favorites()
        {
            var games = await _gameService.ListGames();
            return View(games);
        }

        public async Task<IActionResult> Gamelist()
        {
            var games = await _gameService.ListGames();
            return View(games);
        }

        public IActionResult EditorPick() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
