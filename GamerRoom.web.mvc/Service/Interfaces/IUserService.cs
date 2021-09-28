using GamerRoom.web.mvc.Models.User;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Service.Interfaces
{
    public interface IUserService
    {
        [Post("/api/User/MyGame")]
        [Headers("Authorization: Bearer")]
        Task<UserGameInputModel> AddGame(UserGameInputModel userGameInputModel);
    }
}
