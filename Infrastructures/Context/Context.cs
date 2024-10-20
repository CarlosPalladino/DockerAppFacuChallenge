using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}


        public DbSet<User> Users { get; set; }
        public DbSet<UserActivity> UsersActivies { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<MessageLog> MesssageLogs { get; set; }

        public DbSet<QueueMessage> QueueMessages { get; set; }

        public class UserConfig : IEntityTypeConfiguration<User> { }

                

    }
}
