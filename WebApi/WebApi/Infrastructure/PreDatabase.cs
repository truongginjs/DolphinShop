using System;
using Microsoft.EntityFrameworkCore;
using WebApi.Helpers.Extensions;
using WebApi.Models;

namespace WebApi.Infrastructure
{
    public static class PreDatabase
    {

        private static readonly DateTime now = DateTime.Now;
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(SeedRoles());
            modelBuilder.Entity<User>().HasData(SeedUsers());
        }

        private static User[] SeedUsers()
        {
            var amdminPass = "Abc123!";

            var result = new User[]{
                new User {
                    Id=1,
                    Fullname="admin",
                    Username="admin",
                    Password=amdminPass.HashPassword("admin"),
                    PhoneNumber= "190000000",
                    Email ="admin@domain",
                    Description="user",
                    CreatedDate=now,
                    UpdatedDate=now,
                    RoleId = 1
                },

            };
            return result;
        }

        private static Role[] SeedRoles()
        {
            var result = new Role[]{
                new Role {
                    Id=2,
                    Name="user",
                    Description="user",
                    CreatedDate=now,
                    UpdatedDate=now,
                },

                    new Role {
                    Id=1,
                    Name="admin",
                    Description="admin",
                    CreatedDate=now,
                    UpdatedDate=now,
                }
            };
            return result;
        }
    }
}