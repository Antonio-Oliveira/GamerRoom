using GamerRoom.web.mvc.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Models.Home
{
    public class HomeViewModel
    {
        public List<GameViewModel> TopTen { get; set; }

        public List<GameViewModel> General { get; set; }
    }
}
