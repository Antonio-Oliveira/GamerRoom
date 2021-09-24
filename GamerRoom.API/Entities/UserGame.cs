﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Entities
{
    public class UserGame
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public Guid GameId { get; set; }

        public double Rating { get; set; }

        public virtual Game Game { get; set; }
    }
}
