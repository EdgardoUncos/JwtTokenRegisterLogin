﻿using System.ComponentModel.DataAnnotations;

namespace JwtTokenRegisterLogin.DTOs
{
    public class UserRegistrationRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
