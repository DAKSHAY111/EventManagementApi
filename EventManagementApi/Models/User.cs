﻿namespace EventManagementApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
