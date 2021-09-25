using GamerRoom.API.Dtos.InputModel;
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
        public async Task<IActionResult> Register(RegisterInputModel registerIM)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.SelectMany(err => err.Errors));

                await _authService.Register(registerIM);
                var token = await _authService.GerarToken(registerIM.Email);

                return Created("", token);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginInputModel loginIM)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.SelectMany(err => err.Errors));

                await _authService.Login(loginIM);
                var token = await _authService.GerarToken(loginIM.Email);

                return Ok(token);
            }
            catch (Exception err)
            {
                return NotFound(err.Message);
            }
        }
    }
}
