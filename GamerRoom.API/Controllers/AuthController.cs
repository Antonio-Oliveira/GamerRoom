using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Dtos.ViewModel;
using GamerRoom.API.Entities;
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
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserViewModel>> Register(RegisterInputModel registerIM)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.SelectMany(err => err.Errors));

                await _authService.Register(registerIM);
                var token = await _authService.GerarToken(registerIM.Email);

                var userVM = new UserViewModel()
                {
                    Email = registerIM.Email,
                    Token = token,
                };

                return Ok(userVM);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost("Login")]
        public async Task<ActionResult<UserViewModel>> Login(LoginInputModel loginIM)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.SelectMany(err => err.Errors));

                await _authService.Login(loginIM);
                var token = await _authService.GerarToken(loginIM.Email);

                var userVM = new UserViewModel()
                {
                    Email = loginIM.Email,
                    Token = token,
                }; 

                return Ok(userVM);
            }
            catch (Exception err)
            {
                return NotFound(err.Message);
            }
        }
    }
}
