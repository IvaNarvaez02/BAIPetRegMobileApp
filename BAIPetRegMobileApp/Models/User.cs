﻿namespace BAIPetRegMobileApp.Models;
public class User
{
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}
