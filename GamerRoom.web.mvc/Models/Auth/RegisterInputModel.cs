﻿using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc.Models.Auth
{
    public class RegisterInputModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo {0} está inválido")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "O campo {0} está inválido")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        [JsonProperty(PropertyName = "confirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
