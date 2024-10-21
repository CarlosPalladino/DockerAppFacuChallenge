using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<UserActivity> UsersActivies { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<MessageLog> MesssageLogs { get; set; }

        public DbSet<QueueMessage> QueueMessages { get; set; }

        public class UserConfig : IEntityTypeConfiguration<User>
        {

            // Configuración de User
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable("Users");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.Name).HasColumnName("name").IsRequired();
                builder.Property(x => x.Email).HasColumnName("email").IsRequired();
                builder.Property(x => x.RegisteredAt).HasColumnName("registredAt").IsRequired();
                // Relaciones
                builder.HasMany(x => x.BankAccounts).WithOne().HasForeignKey(ba => ba.UserId);
                builder.HasMany(x => x.Transactions).WithOne().HasForeignKey(t => t.UserId);
                builder.HasMany(x => x.UserActivities).WithOne().HasForeignKey(ua => ua.UserId);
                builder.HasMany(x => x.MessageLogs).WithOne().HasForeignKey(ml => ml.UserId);
            }

            // Configuración de UserActivity
            public void Configure(EntityTypeBuilder<UserActivity> builder)
            {
                builder.ToTable("UserActivities");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.UserId).HasColumnName("userId").IsRequired();
                builder.Property(x => x.Activity).HasColumnName("activity").IsRequired();
                builder.Property(x => x.ActivityAt).HasColumnName("activityAt").IsRequired();
                builder.Property(x => x.Status).HasColumnName("status").IsRequired();
                // Relaciones
                builder.HasOne(x => x.User).WithMany(u => u.UserActivities).HasForeignKey(x => x.UserId);
            }

            // Configuración de QueueMessage
            public void Configure(EntityTypeBuilder<QueueMessage> builder)
            {
                builder.ToTable("QueueMessages");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.SentAt).HasColumnName("sentAt").IsRequired();
                builder.Property(x => x.QuueMessage).HasColumnName("queueMessage").IsRequired();
                // Relaciones
                builder.HasOne(x => x.Message).WithMany(m => m.QueueMessages).HasForeignKey(x => x.MessageId);
            }

            // Configuración de MessageLog
            public void Configure(EntityTypeBuilder<MessageLog> builder)
            {
                builder.ToTable("MessageLogs");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.QueueName).HasColumnName("queueName").IsRequired();
                builder.Property(x => x.MessageContent).HasColumnName("messageContent").IsRequired();
                builder.Property(x => x.ProcessedAt).HasColumnName("processedAt").IsRequired();
                builder.Property(x => x.Status).HasColumnName("status").IsRequired();
                // Relaciones
                builder.HasOne(x => x.Message).WithMany(m => m.MessageLogs).HasForeignKey(x => x.MessageId);
                builder.HasOne(x => x.User).WithMany(u => u.MessageLogs).HasForeignKey(x => x.UserId);
            }

            // Configuración de Message
            public void Configure(EntityTypeBuilder<Message> builder)
            {
                builder.ToTable("Messages");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.Content).HasColumnName("content").IsRequired();
                builder.Property(x => x.CreatedAt).HasColumnName("createdAt").IsRequired();
                builder.Property(x => x.MessageType).HasColumnName("messageType").IsRequired();
                builder.Property(x => x.Status).HasColumnName("status").IsRequired();
                // Relaciones
                builder.HasMany(x => x.MessageLogs).WithOne(ml => ml.Message).HasForeignKey(ml => ml.MessageId);
                builder.HasMany(x => x.QueueMessages).WithOne(qm => qm.Message).HasForeignKey(qm => qm.MessageId);
            }

            // Configuración de Transaction
            public void Configure(EntityTypeBuilder<Transaction> builder)
            {
                builder.ToTable("Transactions");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.UserId).HasColumnName("userId").IsRequired();
                builder.Property(x => x.Amount).HasColumnName("amount").IsRequired();
                builder.Property(x => x.TransactionType).HasColumnName("transactionType").IsRequired();
                builder.Property(x => x.TransactionDate).HasColumnName("transactionDate").IsRequired();
                builder.Property(x => x.Status).HasColumnName("status").IsRequired();
                // Relaciones
                builder.HasOne(x => x.User).WithMany(u => u.Transactions).HasForeignKey(x => x.UserId);
                builder.HasOne(x => x.BankAccount).WithMany(ba => ba.Transactions).HasForeignKey(x => x.BankAccountId);
            }

            // Configuración de BankAccount
            public void Configure(EntityTypeBuilder<BankAccount> builder)
            {
                builder.ToTable("BankAccounts");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("id").IsRequired();
                builder.Property(x => x.UserId).HasColumnName("userId").IsRequired();
                builder.Property(x => x.AccountNumber).HasColumnName("accountNumber").IsRequired();
                builder.Property(x => x.Balance).HasColumnName("balance").IsRequired();
                builder.Property(x => x.AccountType).HasColumnName("accountType").IsRequired();
                builder.Property(x => x.CreatedAt).HasColumnName("createdAt").IsRequired();
                // Relaciones
                builder.HasOne(x => x.User).WithMany(u => u.BankAccounts).HasForeignKey(x => x.UserId);
                builder.HasMany(x => x.Transactions).WithOne(t => t.BankAccount).HasForeignKey(t => t.BankAccountId);
            }

        }



    }
}
