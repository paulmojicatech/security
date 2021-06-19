using System;
using Microsoft.EntityFrameworkCore;
using PaulMojicaTech.Security.Models;

namespace PaulMojicaTech.Security.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
