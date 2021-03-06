﻿namespace Infrastructure.Entities
{
    /// <summary>
    /// Interface for application users
    /// </summary>
    public interface IUser : IEntity
    {
        string UserName { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
