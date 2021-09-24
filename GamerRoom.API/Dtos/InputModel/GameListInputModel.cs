using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Dtos.InputModel
{
    public class GameListInputModel
    {
        [Required]
        public Guid IdGame { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
