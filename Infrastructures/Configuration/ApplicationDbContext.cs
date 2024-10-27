using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<UserActivity> UsersActivies { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<MessageLog> MessageLogs { get; set; }

        public DbSet<QueueMessage> QueueMessages { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>();
            modelBuilder.Entity<UserActivity>();
            modelBuilder.Entity<Message>();
            modelBuilder.Entity<MessageLog>();
            modelBuilder.Entity<QueueMessage>();
            modelBuilder.Entity<BankAccount>();
            modelBuilder.Entity<Transaction>();
        }
    }
}