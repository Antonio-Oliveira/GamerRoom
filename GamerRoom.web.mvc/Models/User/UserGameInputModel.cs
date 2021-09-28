using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Models.User
{
    public class UserGameInputModel
    {
        public Guid IdGame { get; set; }

        public double Rating { get; set; }

    }
}
