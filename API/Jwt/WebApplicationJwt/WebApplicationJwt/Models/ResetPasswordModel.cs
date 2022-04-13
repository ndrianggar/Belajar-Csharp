﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationJwt.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "New Password is required")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm New Password is required")]
        public string ConfirmNewPassword { get; set; }

        public string Token { get; set; }
    }
}
