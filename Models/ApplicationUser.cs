﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MPSecureVMS.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

    }
}
