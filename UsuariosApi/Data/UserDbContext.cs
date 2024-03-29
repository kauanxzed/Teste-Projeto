﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using UsuariosApi.Models;

namespace UsuariosApi.Data
{
    public class UserDbContext : IdentityDbContext<CustomIdentityUser, IdentityRole<int>, int>
    {

        public UserDbContext(DbContextOptions<UserDbContext> opt) : base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            CustomIdentityUser admin = new CustomIdentityUser
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Id = 99999
            };

            PasswordHasher<CustomIdentityUser> hasher = new PasswordHasher<CustomIdentityUser>();
            
            admin.PasswordHash = hasher.HashPassword(admin,"Senha123.");
            
            builder.Entity<CustomIdentityUser>().HasData(admin);
            
            builder.Entity<CustomRole>().HasData(
                new CustomRole { Id = 99999, Name = "admin", NormalizedName = "ADMIN" }
            );
            builder.Entity<CustomRole>().HasData(
                new CustomRole { Id = 99997, Name = "regular", NormalizedName = "REGULAR" }
            );

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { RoleId = 99999, UserId = 99999 }
                );
             
        }
    }
}
