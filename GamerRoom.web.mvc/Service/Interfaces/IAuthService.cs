using GamerRoom.web.mvc.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Service.Interfaces
{
    public interface IAuthService
    {
        [Post("/api/Auth/Login")]
        Task<UserViewModel> Login(LoginInputModel loginInputModel);

        [Post("/api​/Auth/Register")]
        Task<RegisterInputModel> Register(RegisterInputModel registerInputModel);
    }
}
