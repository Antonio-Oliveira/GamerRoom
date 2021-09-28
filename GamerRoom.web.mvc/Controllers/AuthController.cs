using GamerRoom.web.mvc.Models.Auth;
using GamerRoom.web.mvc.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginInputModel loginInputModel)
        {
            try
            {
                var user = await _authService.Login(loginInputModel);
                return RedirectToAction("Index", "Home");
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
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterInputModel registerInputModel)
        {
            try
            {
                if (!ModelState.IsValid) 
                {
                    throw new Exception("Error registering user, try again.");
                }

                var user = await _authService.Register(registerInputModel);
                return RedirectToAction("Index", "Home");
            }
            catch (ApiException err)
            {
                ModelState.AddModelError(" ", "Erro na api");
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
