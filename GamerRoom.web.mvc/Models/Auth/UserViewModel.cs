using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Models.Auth
{
    public class UserViewModel
    {
        [AliasAs("token")]
        public string Token { get; set; }

        [AliasAs("email")]
        public string Email { get; set; }
    }
}
