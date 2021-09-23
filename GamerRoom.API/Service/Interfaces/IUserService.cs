using GamerRoom.API.Dtos.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Service.Interfaces
{
    public interface IUserService
    {
        Task Register(RegisterInputModel registerIM);

        Task Login(LoginInputModel loginIM);

        Task<string> GerarToken(string email);
    }
}
