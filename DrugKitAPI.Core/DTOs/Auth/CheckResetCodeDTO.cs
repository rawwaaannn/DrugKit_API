﻿using System.ComponentModel.DataAnnotations;

namespace DrugKitAPI.Core.DTOs.Auth
{
    public class CheckResetCodeDTO
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ResetCode { get; set; }
    }
}
