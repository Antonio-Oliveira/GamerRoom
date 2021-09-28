using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Dtos.InputModel
{
    public class GameInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Nome do jogo deve conter entre 1 a 100 caracteres")]
        public string Name { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 1, ErrorMessage = "A descrição do jogo deve conter entre 1 a 300 caracteres")]
        public string Description { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O nome da Desenvolvedora do jogo deve conter entre 1 a 100 caracteres")]
        public string Developer { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O Nome da Publicadora deve conter entre 1 a 100 caracteres")]
        public string Publisher { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 1, ErrorMessage = "O gênero do jogo deve conter entre 1 a 300 caracteres")]
        public string Genre { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "A Nome da Publicadora deve conter entre 1 a 100 caracteres")]
        public string Platform { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "A Nome da Publicadora deve conter entre 1 a 100 caracteres")]
        public string Mode { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string ImageUri { get; set; }

        [Required]
        public string TrailerUri { get; set; }
    }
}
