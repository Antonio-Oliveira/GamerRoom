using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Dtos.ViewModel
{
    public class GameViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public double Score { get; set; }

        public int Members { get; set; }

    }
}
