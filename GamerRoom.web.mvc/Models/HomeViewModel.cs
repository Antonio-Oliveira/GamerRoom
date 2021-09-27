using GamerRoom.web.mvc.Dtos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Models
{
    public class HomeViewModel
    {
        public List<GameViewModel> TopTen { get; set; }

        public List<GameViewModel> General { get; set; }
    }
}
