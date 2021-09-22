using GamerRoom.API.Dtos.InputModel;
using GamerRoom.API.Entities;
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
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterInputModel registerIM)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.SelectMany(err => err.Errors));

                await _userService.Register(registerIM);
                return Created("", registerIM);
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

                await _userService.Login(loginIM);

                return Ok(await _userService.GerarToken(loginIM.Email));
            }
            catch (Exception err)
            {
                return NotFound(err.Message);
            }
        }
    }
}
