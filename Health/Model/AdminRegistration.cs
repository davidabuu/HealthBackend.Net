﻿
using Microsoft.AspNetCore.Identity;

namespace Health.Model
{
    public class AdminRegistration : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }
    }
}
