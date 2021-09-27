using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Entities
{
    public class Game
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public string Platform { get; set; }

        public string Mode { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ImageUri { get; set; }
    }
}
